using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using MedicalFlow.WinForms.Services;
using MedicalFlow.WinForms.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using System.Windows.Forms;
using App = System.Windows.Forms.Application;

namespace MedicalFlow.WinForms
{
    internal static class Program
    {
        // Globalny dostawca usług DI dla aplikacji
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            App.EnableVisualStyles();
            App.SetCompatibleTextRenderingDefault(false);

            // 1. Uruchomienie ekranu powitalnego (SplashScreen) na dedykowanym wątku
            SplashScreenManager.ShowForm(typeof(AppSplashScreen));

            // Informacja o konfiguracji usług
            SplashScreenManager.Default?.SendCommand(
                AppSplashScreen.SplashScreenCommand.SetStatus,
                "Inicjalizacja modułów i kontenera usług..."
            );

            // 2. Konfiguracja Dependency Injection
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            // Aktualizacja tekstu statusu na ekranie powitalnym
            SplashScreenManager.Default?.SendCommand(
                AppSplashScreen.SplashScreenCommand.SetStatus,
                "Sprawdzanie połączenia z serwerem API..."
            );

            // 3. Pobranie serwisu ApiHealthChecker z kontenera DI
            var healthChecker = ServiceProvider.GetRequiredService<ApiHealthChecker>();
            var isServerOnline = healthChecker.CheckConnection(timeoutSeconds: 5);

            if (!isServerOnline)
            {
                // Zamykamy SplashScreen przed pokazaniem okna błędu
                SplashScreenManager.CloseForm(false);

                XtraMessageBox.Show(
                    "Nie udało się połączyć z serwerem API.\n\n" +
                    "Upewnij się, że kontener 'medicalflow-app' jest włączony pod adresem http://localhost:8080.",
                    "Błąd połączenia z serwerem",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                // Bezpiecznie kończymy program, nie uruchamiając pustego okna
                return; 
            }

            // 4. Sukces - informujemy użytkownika i przygotowujemy start okna
            SplashScreenManager.Default?.SendCommand(
                AppSplashScreen.SplashScreenCommand.SetStatus,
                "Serwer aktywny. Uruchamianie aplikacji..."
            );

            // Krótkie opóźnienie dla płynności wizualnej
            Thread.Sleep(500);

            // 5. Pobranie głównego okna z kontenera DI (z automatycznie rozwiązanymi zależnościami)
            var mainView = ServiceProvider.GetRequiredService<MainView>();

            // Zamknięcie SplashScreen tuż przed pokazaniem okna
            SplashScreenManager.CloseForm(false);

            App.Run(mainView);
        }

        // Rejestracja wszystkich zależności w aplikacji
        private static void ConfigureServices(IServiceCollection services)
        {
            // Serwisy
            services.AddSingleton<IPatientApiClient, PatientApiClient>();
            services.AddSingleton<ApiHealthChecker>();

            // Rejestracja ViewModeli przez fabryki DevExpress ViewModelSource:
            services.AddTransient(sp =>
                MainViewModel.Create());

            // 1. Przekazujemy apiClient do DashboardViewModel
            services.AddTransient(sp =>
                DashboardViewModel.Create(sp.GetRequiredService<IPatientApiClient>()));

            // 2. Przekazujemy apiClient do PatientsViewModel
            services.AddTransient(sp =>
                PatientsViewModel.Create(sp.GetRequiredService<IPatientApiClient>()));

            // 3. Przekazujemy apiClient do PatientEditViewModel
            services.AddTransient(sp =>
                PatientEditViewModel.Create(sp.GetRequiredService<IPatientApiClient>()));

            // Formularze
            services.AddTransient<MainView>();
        }
    }
}
