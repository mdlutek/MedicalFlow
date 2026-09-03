using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraSplashScreen;
using MedicalFlow.Domain.Enums;
using MedicalFlow.Infrastructure.Xpo;
using MedicalFlow.Infrastructure.Xpo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MedicalFlow.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Uruchomienie ekranu powitalnego (SplashScreen) na dedykowanym wątku
            SplashScreenManager.ShowForm(typeof(AppSplashScreen));

            // Aktualizacja tekstu statusu na ekranie powitalnym
            SplashScreenManager.Default?.SendCommand(
                AppSplashScreen.SplashScreenCommand.SetStatus,
                "Łączenie z serwerem bazy danych..."
            );

            // 2. Inicjalizacja połączenia XPO i generowanie schematu bazy danych
            XpoConnectionHelper.InitXpo();

            // Aktualizacja statusu
            SplashScreenManager.Default?.SendCommand(
                AppSplashScreen.SplashScreenCommand.SetStatus,
                "Weryfikacja danych i konfiguracji..."
            );

            // 3. Sprawdzenie i zasilenie bazy danymi początkowymi
            XpoConnectionHelper.SeedInitialData();

            // Opcjonalne: krótkie opóźnienie, aby splash screen nie mignął zbyt szybko przy szybkim dysku
            Thread.Sleep(500);

            // 4. Zamknięcie SplashScreen i otwarcie głównego okna programu
            SplashScreenManager.CloseForm(false);

            Application.Run(new MainView());
        }        
    }
}
