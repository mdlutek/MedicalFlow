using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using MedicalFlow.WinForms.ViewModels;

namespace MedicalFlow.WinForms.Views
{
    public partial class DashboardView : XtraUserControl
    {
        public DashboardView()
        {
            InitializeComponent();
            if (!DesignMode)
                InitializeMvvm();
        }

        private void InitializeMvvm()
        {
            var fluent = mvvmContext1.OfType<DashboardViewModel>();

            // Wiązanie statystyk liczbowych do etykiet na pulpicie
            fluent.SetBinding(lblTotalPatients, lbl => lbl.Text, x => x.Stats.TotalPatientsCount);
            fluent.SetBinding(lblWaitingQueue, lbl => lbl.Text, x => x.Stats.WaitingInQueueCount);
            fluent.SetBinding(lblTodayVisits, lbl => lbl.Text, x => x.Stats.TodayVisitsCount);
        }
    }
}