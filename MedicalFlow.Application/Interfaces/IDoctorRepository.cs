using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalFlow.Domain.Entities;

namespace MedicalFlow.Application.Interfaces
{
    public interface IDoctorRepository
    {
        Task<Doctor> GetByIdAsync(int id);
        Task<List<Doctor>> GetAllAsync();
        Task AddAsync(Doctor doctor);
        Task UpdateAsync(Doctor doctor);
    }
}