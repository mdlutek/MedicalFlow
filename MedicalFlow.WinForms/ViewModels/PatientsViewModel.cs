using System.Collections.Generic;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MedicalFlow.Domain.Dtos;
using MedicalFlow.WinForms.Services;

namespace MedicalFlow.WinForms.ViewModels
{
    // Atrybut POCOViewModel automatycznie generuje implementację INotifyPropertyChanged
    [POCOViewModel]
    public class PatientsViewModel
    {
        private readonly PatientApiClient _apiClient;

        // Właściwości bindowane do DevExpress GridControl
        public virtual List<PatientDto> Patients { get; set; }
        public virtual PatientDto SelectedPatient { get; set; }
        public virtual bool IsLoading { get; set; }

        // Serwis okien dialogowych DevExpress
        protected IDialogService DialogService => this.GetService<IDialogService>();

        public PatientsViewModel()
        {
            _apiClient = new PatientApiClient();
            LoadData();
        }

        public static PatientsViewModel Create()
        {
            return ViewModelSource.Create(() => new PatientsViewModel());
        }

        // Asynchroniczne ładowanie listy pacjentów z Web API
        public async void LoadData()
        {
            IsLoading = true;
            Patients = await _apiClient.GetPatientsAsync();
            IsLoading = false;
        }

        // Dodawanie nowego pacjenta przez formularz dialogowy
        public async void AddPatient()
        {
            var newDto = new CreateOrUpdatePatientDto();
            var editViewModel = PatientEditViewModel.Create(newDto, isNew: true);

            if (DialogService.ShowDialog(MessageButton.OKCancel, "Dodaj nowego pacjenta", "PatientEditView", editViewModel) == MessageResult.OK)
            {
                IsLoading = true;
                bool success = await _apiClient.CreatePatientAsync(newDto);
                if (success)
                {
                    LoadData(); // Odświeżenie widoku po udanym zapisie przez API
                }
                IsLoading = false;
            }
        }

        // Edycja zaznaczonego pacjenta
        public async void EditPatient()
        {
            if (SelectedPatient == null) return;

            // Przygotowanie danych edytowanego pacjenta
            var editDto = new CreateOrUpdatePatientDto
            {
                FirstName = SelectedPatient.FirstName,
                LastName = SelectedPatient.LastName,
                Pesel = SelectedPatient.Pesel,
                PhoneNumber = SelectedPatient.PhoneNumber
            };

            var editViewModel = PatientEditViewModel.Create(editDto, isNew: false);

            if (DialogService.ShowDialog(MessageButton.OKCancel, "Edycja danych pacjenta", "PatientEditView", editViewModel) == MessageResult.OK)
            {
                IsLoading = true;
                bool success = await _apiClient.UpdatePatientAsync(SelectedPatient.Id, editDto);
                if (success)
                {
                    LoadData(); // Przeładowanie siatki ze świeżymi danymi
                }
                IsLoading = false;
            }
        }

        // Warunek aktywności przycisku Edytuj (aktywny tylko gdy zaznaczono wiersz)
        public bool CanEditPatient() => SelectedPatient != null;

        // Usuwanie pacjenta
        public async void DeletePatient()
        {
            if (SelectedPatient == null) return;

            IsLoading = true;
            bool success = await _apiClient.DeletePatientAsync(SelectedPatient.Id);
            if (success)
            {
                LoadData();
            }
            IsLoading = false;
        }

        // Warunek aktywności przycisku Usuń
        public bool CanDeletePatient() => SelectedPatient != null;
    }
}