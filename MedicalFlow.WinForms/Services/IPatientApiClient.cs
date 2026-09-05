using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalFlow.Contracts.Dtos;

namespace MedicalFlow.WinForms.Services
{
    // Kontrakt określający operacje na danych pacjentów
    public interface IPatientApiClient
    {
        Task<List<PatientDto>> GetPatientsAsync();
        Task<bool> CreatePatientAsync(CreateOrUpdatePatientDto dto);
        Task<bool> UpdatePatientAsync(int id, CreateOrUpdatePatientDto dto);
        Task<bool> DeletePatientAsync(int id);
    }
}