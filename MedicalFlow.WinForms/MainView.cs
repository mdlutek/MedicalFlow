using System;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.XtraBars;
using MedicalFlow.WinForms.Views;

namespace MedicalFlow.WinForms
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Control _currentView;

        public MainView()
        {
            InitializeComponent();

            // DOMYŚLNY WIDOK STARTOWY: Pulpit / Dashboard
            ShowView(new DashboardView());
        }

        private void ShowView(Control newView)
        {
            mainNavigationFrame.Controls.Clear();
            _currentView = newView;
            _currentView.Dock = DockStyle.Fill;
            mainNavigationFrame.Controls.Add(_currentView);
        }

        #region --- NAWIGACJA ---

        // 1. Przycisk "Pulpit / Dashboard"
        private void btnDashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!(_currentView is DashboardView))
            {
                ShowView(new DashboardView());
            }
        }

        // 2. Przycisk "Lista Pacjentów"
        private void btnPatients_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!(_currentView is PatientsView))
            {
                ShowView(new PatientsView());
            }
        }

        // 3. Przycisk "Kalendarz Wizyt"
        private void btnCalendar_ItemClick(object sender, ItemClickEventArgs e)
        {
            // ShowView(new CalendarView());
            DevExpress.XtraEditors.XtraMessageBox.Show("Moduł Kalendarza Wizyt - w trakcie budowy", "Nawigacja");
        }

        #endregion

        #region --- AKCJE DLA MODUŁU PACJENTÓW ---

        private void btnAddPatient_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!(_currentView is PatientsView))
            {
                ShowView(new PatientsView());
            }

            Messenger.Default.Send("AddPatient", "AddPatient");
        }

        private void btnRefreshPatients_ItemClick(object sender, ItemClickEventArgs e)
        {
            Messenger.Default.Send("RefreshPatients", "RefreshPatients");
        }

        #endregion
    }
}