using System.Collections.Generic;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MedicalFlow.Domain.Dtos;
using MedicalFlow.Domain.Interfaces;

namespace MedicalFlow.WinForms.ViewModels
{
    // Atrybut POCOViewModel automatycznie generuje implementację INotifyPropertyChanged
    [POCOViewModel]
    // ISupportNavigation zapewnia odświeżenie danych po powrocie z karty edycji
    public class PatientsViewModel : ISupportNavigation
    {
        private readonly IPatientApiClient _apiClient;

        // Właściwości bindowane do DevExpress GridControl
        public virtual List<PatientDto> Patients { get; set; }
        public virtual PatientDto SelectedPatient { get; set; }
        public virtual bool IsLoading { get; set; }

        // Wymagane przez interfejs ISupportNavigation
        public object Parameter { get; set; }

        // Pobieramy serwis nawigacji
        protected INavigationService NavigationService => this.GetService<INavigationService>();

        public PatientsViewModel(IPatientApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public static PatientsViewModel Create(IPatientApiClient apiClient)
        {
            return ViewModelSource.Create(() => new PatientsViewModel(apiClient));
        }

        // Automatyczne odświeżenie danych, gdy użytkownik wraca na ten ekran
        public void OnNavigatedTo()
        {
            LoadData();
        }

        public void OnNavigatedFrom() { }

        // Asynchroniczne ładowanie listy pacjentów z Web API
        public async void LoadData()
        {
            IsLoading = true;
            Patients = await _apiClient.GetPatientsAsync();
            IsLoading = false;
        }

        // 1. Dodawanie: nawigujemy z parametrem 'null' (nowy pacjent)
        public void AddPatient()
        {
            NavigationService?.Navigate("PatientEditView", null, this);
        }

        // 2. Edycja: nawigujemy przekazując ID zaznaczonego pacjenta
        public void EditPatient()
        {
            if (SelectedPatient == null) return;

            NavigationService?.Navigate("PatientEditView", SelectedPatient.Id, this);
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