using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using MedicalFlow.Domain.Dtos;
using MedicalFlow.Domain.Interfaces;
using System;
using System.Windows.Forms;

namespace MedicalFlow.WinForms.ViewModels
{
    [POCOViewModel]
    // Dodano : ISupportParameter, aby DevExpress wiedział jak przekazać ID
    public class PatientEditViewModel : ISupportParameter
    {
        private readonly IPatientApiClient _apiClient;

        // Serwis do powrotu do poprzedniego ekranu
        protected INavigationService NavigationService => this.GetService<INavigationService>();

        public virtual CreateOrUpdatePatientDto Patient { get; set; }
        public virtual int? PatientId { get; set; }
        public virtual bool IsLoading { get; set; }
        public virtual bool IsNew => !PatientId.HasValue;

        // Implementacja ISupportParameter - DevExpress wstrzykuje tu parametr przekazany w Navigate()
        public object Parameter
        {
            get => PatientId;
            set
            {
                PatientId = (int?)value;
                OnParameterChanged();
            }
        }

        public PatientEditViewModel(IPatientApiClient apiClient)
        {
            _apiClient = apiClient;
            Patient = new CreateOrUpdatePatientDto();
        }

        //Fabryka POCO 
        public static PatientEditViewModel Create(IPatientApiClient apiClient)
        {
            return ViewModelSource.Create(() => new PatientEditViewModel(apiClient));
        }

        // Metoda wywoływana automatycznie po otrzymaniu parametru z nawigacji
        protected async void OnParameterChanged()
        {
            if (PatientId.HasValue)
            {
                // Tryb EDYCJI / KARTA PACJENTA: pobieramy dane z API
                IsLoading = true;
                var patients = await _apiClient.GetPatientsAsync();
                var existing = patients.Find(p => p.Id == PatientId.Value);

                if (existing != null)
                {
                    Patient = new CreateOrUpdatePatientDto
                    {
                        FirstName = existing.FirstName,
                        LastName = existing.LastName,
                        Pesel = existing.Pesel,
                        PhoneNumber = existing.PhoneNumber
                    };
                }
                IsLoading = false;
            }
            else
            {
                // Tryb NOWEGO PACJENTA: czysty formularz
                Patient = new CreateOrUpdatePatientDto();
            }
        }

        // Zapisanie zmian przez API i powrót do listy
        public async void Save()
        {
            // Weryfikacja danych przed wysłaniem do serwera
            if (!Validate()) 
            {
                XtraMessageBox.Show(
                    "Uzupełnij poprawnie wszystkie dane pacjenta.",
                    "Błąd formularza",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            IsLoading = true;
            bool success;

            if (IsNew)
                success = await _apiClient.CreatePatientAsync(Patient);
            else
                success = await _apiClient.UpdatePatientAsync(PatientId.Value, Patient);

            IsLoading = false;

            if (success)
            {
                // Po udanym zapisie wracamy do listy pacjentów
                GoBack();
            }
        }

        // Powrót bez zapisywania
        public void Cancel() => GoBack();

        private void GoBack()
        {
            NavigationService?.Navigate("PatientsView", null, this);
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