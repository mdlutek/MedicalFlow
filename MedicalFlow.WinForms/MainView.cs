using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Ribbon;
using MedicalFlow.WinForms.ViewModels;
using System;

namespace MedicalFlow.WinForms
{
    public partial class MainView : RibbonForm
    {
        public MainView()
        {
            InitializeComponent();

            // Całkowite wyłączenie animacji - natychmiastowe przełączanie ekranów w 0 ms
            mainNavigationFrame.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;

            if (!DesignMode)
                InitializeMvvm();
        }

        private void InitializeMvvm()
        {
            // Rejestracja serwisu nawigacji
            mvvmContext1.RegisterService(NavigationService.Create(mainNavigationFrame));

            // Ustawienie sformatowanej dzisiejszej daty w stopce
            bsiDate.Caption = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            var fluent = mvvmContext1.OfType<MainViewModel>();

            // Start z Pulpitem
            fluent.WithEvent(this, "Load").EventToCommand(x => x.ShowDashboard());

            // Wiązanie przycisków wstążki z komendami
            fluent.BindCommand(btnDashboard, x => x.ShowDashboard());
            fluent.BindCommand(btnPatients, x => x.ShowPatients());
            fluent.BindCommand(btnPatientEdit, x => x.ShowPatientEdit());
        }
    }
}