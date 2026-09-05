using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalFlow.Domain.Entities;

namespace MedicalFlow.Application.Interfaces
{
    public interface IVisitRepository
    {
        Task<Visit> GetByIdAsync(int id);
        Task<List<Visit>> GetTodayVisitsAsync();
        Task<List<Visit>> GetVisitsByDoctorAsync(int doctorId, DateTime date);
        Task<List<Visit>> GetVisitsByPatientAsync(int patientId);
        Task AddAsync(Visit visit);
        Task UpdateAsync(Visit visit);
    }
}