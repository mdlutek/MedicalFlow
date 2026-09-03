using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MedicalFlow.Domain.Dtos;
using MedicalFlow.Infrastructure.Xpo.Entities;
using System;

namespace MedicalFlow.WinForms.ViewModels
{
    [POCOViewModel]
    public class PatientEditViewModel
    {
        public virtual CreateOrUpdatePatientDto Patient { get; set; }
        public virtual bool IsNew { get; set; }

        protected PatientEditViewModel(CreateOrUpdatePatientDto dto, bool isNew)
        {
            Patient = dto;
            IsNew = isNew;
        }

        public static PatientEditViewModel Create(CreateOrUpdatePatientDto dto, bool isNew)
        {
            return ViewModelSource.Create(() => new PatientEditViewModel(dto, isNew));
        }

        // Walidacja poprawności danych przed zatwierdzeniem formularza
        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(Patient.FirstName) || string.IsNullOrWhiteSpace(Patient.LastName))
                return false;

            if (string.IsNullOrWhiteSpace(Patient.Pesel) || Patient.Pesel.Length != 11)
                return false;

            return true;
        }
    }
}