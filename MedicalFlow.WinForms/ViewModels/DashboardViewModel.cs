using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MedicalFlow.Contracts.Dtos;
using MedicalFlow.WinForms.Services;

namespace MedicalFlow.WinForms.ViewModels
{
    [POCOViewModel]
    public class DashboardViewModel
    {
        private readonly IPatientApiClient _apiClient;

        // Właściwości bindowane do kafelków i wykresów
        public virtual DashboardStatsDto Stats { get; set; }
        public virtual bool IsLoading { get; set; }

        public DashboardViewModel(IPatientApiClient apiClient)
        {
            _apiClient = apiClient;
            Stats = new DashboardStatsDto();
            LoadDashboardData();
        }

        public static DashboardViewModel Create(IPatientApiClient apiClient)
        {
            return ViewModelSource.Create(() => new DashboardViewModel(apiClient));
        }

        public async void LoadDashboardData()
        {
            IsLoading = true;

            // Pobieramy aktualną liczbę pacjentów z API
            var patients = await _apiClient.GetPatientsAsync();

            // Przykładowe podsumowanie statystyk
            Stats = new DashboardStatsDto
            {
                TotalPatientsCount = patients?.Count ?? 0,
                TodayVisitsCount = 0,
                WaitingInQueueCount = 0,
                CompletedVisitsCount = 0
            };

            IsLoading = false;
        }
    }
}