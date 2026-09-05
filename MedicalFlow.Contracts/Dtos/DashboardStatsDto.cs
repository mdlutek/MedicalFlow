namespace MedicalFlow.Contracts.Dtos
{
    // Model danych podsumowujących dla ekranu głównego (Pulpitu)
    public class DashboardStatsDto
    {
        public int TodayVisitsCount { get; set; }     // Liczba wizyt na dziś
        public int WaitingInQueueCount { get; set; }  // Pacjenci oczekujący w poczekalni
        public int CompletedVisitsCount { get; set; } // Zakończone wizyty dzisiaj
        public int TotalPatientsCount { get; set; }   // Wszyscy zarejestrowani pacjenci
    }
}