using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalFlow.Domain.Entities;

namespace MedicalFlow.Application.Interfaces
{
    // Abstrakcja dostępu do danych pacjenta wykorzystywana przez warstwę Application.
    public interface IPatientRepository
    {
        Task<Patient> GetByIdAsync(int id);
        Task<Patient> GetByPeselAsync(string pesel);
        Task<List<Patient>> GetAllAsync();
        Task AddAsync(Patient patient);
        Task UpdateAsync(Patient patient);
        Task DeleteAsync(int id);
    }
}