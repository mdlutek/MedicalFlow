using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace MedicalFlow.WinForms.ViewModels
{
    [POCOViewModel]
    public class MainViewModel
    {
        // Serwis nawigacji dostarczany automatycznie przez DevExpress MVVM
        protected INavigationService NavigationService => this.GetService<INavigationService>();

        public static MainViewModel Create() =>
            ViewModelSource.Create(() => new MainViewModel());

        // Metoda wywoływana przy starcie aplikacji
        public void OnLoaded()
        {
            ShowDashboard();
        }

        // Komendy nawigacyjne powiązane z przyciskami na wstążce
        public void ShowDashboard()
        {
            // Przełączenie widoku po nazwie zarejestrowanej w serwisie nawigacji
            NavigationService?.Navigate("DashboardView", null, this);
        }

        public void ShowCalendar()
        {
            NavigationService?.Navigate("CalendarView", null, this);
        }

        public void ShowPatients()
        {
            NavigationService?.Navigate("PatientsView", null, this);
        }

        public void ShowPatientEdit()
        {
            NavigationService?.Navigate("PatientEditView", null, this);
        }
    }
}