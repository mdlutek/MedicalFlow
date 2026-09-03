using System.Threading.Tasks;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MedicalFlow.Domain.Dtos;
using MedicalFlow.WinForms.Services;

namespace MedicalFlow.WinForms.ViewModels
{
    [POCOViewModel]
    public class DashboardViewModel
    {
        private readonly PatientApiClient _apiClient;

        // Właściwości bindowane do kafelków i wykresów
        public virtual DashboardStatsDto Stats { get; set; }
        public virtual bool IsLoading { get; set; }

        public DashboardViewModel()
        {
            _apiClient = new PatientApiClient();
            Stats = new DashboardStatsDto();
            LoadDashboardData();
        }

        public static DashboardViewModel Create() =>
            ViewModelSource.Create(() => new DashboardViewModel());

        public async void LoadDashboardData()
        {
            IsLoading = true;

            // Pobieramy aktualną liczbę pacjentów z API
            var patients = await _apiClient.GetPatientsAsync();

            // Przykładowe podsumowanie statystyk
            Stats = new DashboardStatsDto
            {
                TotalPatientsCount = patients?.Count ?? 0,
                TodayVisitsCount = 12,
                WaitingInQueueCount = 3,
                CompletedVisitsCount = 5
            };

            IsLoading = false;
        }
    }
}