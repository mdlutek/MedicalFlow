using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Xpo;
using MedicalFlow.Domain.Entities;
using MedicalFlow.Application.Interfaces;
using MedicalFlow.Domain.ValueObjects;
using MedicalFlow.Infrastructure.Xpo.Entities;

namespace MedicalFlow.Infrastructure.Xpo.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        public async Task<Patient> GetByIdAsync(int id)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = await uow.GetObjectByKeyAsync<PatientEntity>(id);
                return entity != null ? MapToDomain(entity) : null;
            }
        }

        public async Task<Patient> GetByPeselAsync(string pesel)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = await new XPQuery<PatientEntity>(uow).FirstOrDefaultAsync(p => p.Pesel == pesel);
                return entity != null ? MapToDomain(entity) : null;
            }
        }

        public async Task<List<Patient>> GetAllAsync()
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entities = await new XPQuery<PatientEntity>(uow).ToListAsync();
                return entities.Select(MapToDomain).ToList();
            }
        }

        public async Task AddAsync(Patient patient)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = new PatientEntity(uow)
                {
                    FirstName = patient.FirstName,
                    LastName = patient.LastName,
                    Pesel = patient.Pesel.Value, // Zapisujemy wartość string z Value Object
                    PhoneNumber = patient.PhoneNumber
                };

                await uow.CommitChangesAsync();
            }
        }

        public async Task UpdateAsync(Patient patient)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = await uow.GetObjectByKeyAsync<PatientEntity>(patient.Id);
                if (entity != null)
                {
                    entity.FirstName = patient.FirstName;
                    entity.LastName = patient.LastName;
                    entity.Pesel = patient.Pesel.Value;
                    entity.PhoneNumber = patient.PhoneNumber;

                    await uow.CommitChangesAsync();
                }
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = await uow.GetObjectByKeyAsync<PatientEntity>(id);
                if (entity != null)
                {
                    entity.Delete();
                    await uow.CommitChangesAsync();
                }
            }
        }

        // Mapowanie z encji bazy XPO na obiekt Domeny
        private static Patient MapToDomain(PatientEntity entity)
        {
            return new Patient(
                entity.Oid,
                entity.FirstName,
                entity.LastName,
                new Pesel(entity.Pesel),
                entity.PhoneNumber
            );
        }
    }
}