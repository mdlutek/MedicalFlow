using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Xpo;
using MedicalFlow.Domain.Entities;
using MedicalFlow.Application.Interfaces;
using MedicalFlow.Infrastructure.Xpo.Entities;

namespace MedicalFlow.Infrastructure.Xpo.Repositories
{
    public class VisitRepository : IVisitRepository
    {
        public async Task<Visit> GetByIdAsync(int id)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = await uow.GetObjectByKeyAsync<VisitEntity>(id);
                return entity != null ? MapToDomain(entity) : null;
            }
        }

        public async Task<List<Visit>> GetTodayVisitsAsync()
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var today = DateTime.Today;
                var tomorrow = today.AddDays(1);

                // Pobranie wizyt zaplanowanych na dzisiejszy dzień
                var entities = await new XPQuery<VisitEntity>(uow)
                    .Where(v => v.ScheduledStartTime >= today && v.ScheduledStartTime < tomorrow)
                    .OrderBy(v => v.ScheduledStartTime)
                    .ToListAsync();

                return entities.Select(MapToDomain).ToList();
            }
        }

        public async Task<List<Visit>> GetVisitsByDoctorAsync(int doctorId, DateTime date)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var start = date.Date;
                var end = start.AddDays(1);

                var entities = await new XPQuery<VisitEntity>(uow)
                    .Where(v => v.Doctor.Oid == doctorId && v.ScheduledStartTime >= start && v.ScheduledStartTime < end)
                    .OrderBy(v => v.ScheduledStartTime)
                    .ToListAsync();

                return entities.Select(MapToDomain).ToList();
            }
        }

        public async Task<List<Visit>> GetVisitsByPatientAsync(int patientId)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entities = await new XPQuery<VisitEntity>(uow)
                    .Where(v => v.Patient.Oid == patientId)
                    .OrderByDescending(v => v.ScheduledStartTime)
                    .ToListAsync();

                return entities.Select(MapToDomain).ToList();
            }
        }

        public async Task AddAsync(Visit visit)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = new VisitEntity(uow)
                {
                    Patient = await uow.GetObjectByKeyAsync<PatientEntity>(visit.PatientId),
                    Doctor = await uow.GetObjectByKeyAsync<DoctorEntity>(visit.DoctorId),
                    ScheduledStartTime = visit.ScheduledStartTime,
                    ScheduledEndTime = visit.ScheduledEndTime,
                    Status = visit.Status,
                    Notes = visit.Notes
                };

                if (visit.QueueTicketId.HasValue)
                {
                    entity.QueueTicket = await uow.GetObjectByKeyAsync<QueueTicketEntity>(visit.QueueTicketId.Value);
                }

                await uow.CommitChangesAsync();
            }
        }

        public async Task UpdateAsync(Visit visit)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = await uow.GetObjectByKeyAsync<VisitEntity>(visit.Id);
                if (entity != null)
                {
                    entity.ScheduledStartTime = visit.ScheduledStartTime;
                    entity.ScheduledEndTime = visit.ScheduledEndTime;
                    entity.Status = visit.Status;
                    entity.Notes = visit.Notes;

                    if (visit.QueueTicketId.HasValue)
                    {
                        entity.QueueTicket = await uow.GetObjectByKeyAsync<QueueTicketEntity>(visit.QueueTicketId.Value);
                    }

                    await uow.CommitChangesAsync();
                }
            }
        }

        private static Visit MapToDomain(VisitEntity entity)
        {
            return new Visit(
                entity.Oid,
                entity.Patient?.Oid ?? 0,
                entity.Doctor?.Oid ?? 0,
                entity.ScheduledStartTime,
                entity.ScheduledEndTime,
                entity.Status,
                entity.Notes,
                entity.QueueTicket?.Oid
            );
        }
    }
}