using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Xpo;
using MedicalFlow.Domain.Entities;
using MedicalFlow.Application.Interfaces;
using MedicalFlow.Infrastructure.Xpo.Entities;

namespace MedicalFlow.Infrastructure.Xpo.Repositories
{
    // Repozytorium tłumaczące obiekty bazodanowe XPO na czyste obiekty Domenowe
    public class DoctorRepository : IDoctorRepository
    {
        public async Task<Doctor> GetByIdAsync(int id)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = await uow.GetObjectByKeyAsync<DoctorEntity>(id);
                return entity != null ? MapToDomain(entity) : null;
            }
        }

        public async Task<List<Doctor>> GetAllAsync()
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entities = await new XPQuery<DoctorEntity>(uow).ToListAsync();
                return entities.Select(MapToDomain).ToList();
            }
        }

        public async Task AddAsync(Doctor doctor)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = new DoctorEntity(uow)
                {
                    FirstName = doctor.FirstName,
                    LastName = doctor.LastName,
                    Specialization = doctor.Specialization,
                    CabinetNumber = doctor.CabinetNumber
                };

                await uow.CommitChangesAsync();
            }
        }

        public async Task UpdateAsync(Doctor doctor)
        {
            using (var uow = XpoConnectionHelper.CreateUnitOfWork())
            {
                var entity = await uow.GetObjectByKeyAsync<DoctorEntity>(doctor.Id);
                if (entity != null)
                {
                    entity.FirstName = doctor.FirstName;
                    entity.LastName = doctor.LastName;
                    entity.Specialization = doctor.Specialization;
                    entity.CabinetNumber = doctor.CabinetNumber;

                    await uow.CommitChangesAsync();
                }
            }
        }

        // Pomocnicza metoda mapująca encję XPO na obiekt Domeny
        private static Doctor MapToDomain(DoctorEntity entity)
        {
            return new Doctor(
                entity.Oid,
                entity.FirstName,
                entity.LastName,
                entity.Specialization,
                entity.CabinetNumber
            );
        }
    }
}