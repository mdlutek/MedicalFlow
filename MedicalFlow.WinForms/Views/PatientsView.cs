using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MedicalFlow.Contracts.Dtos;
using MedicalFlow.WinForms.ViewModels;
using Microsoft.Extensions.DependencyInjection; // Wymagany using dla GetRequiredService

namespace MedicalFlow.WinForms.Views
{
    public partial class PatientsView : XtraUserControl
    {
        public PatientsView()
        {
            InitializeComponent();
            if (!DesignMode)
                InitializeMvvm();
        }

        private void InitializeMvvm()
        {
            // 1. Pobranie ViewModelu z kontenera DI
            var viewModel = Program.ServiceProvider.GetRequiredService<PatientsViewModel>();
            mvvmContext1.SetViewModel(typeof(PatientsViewModel), viewModel);

            // Rejestracja serwisu dialogów
            mvvmContext1.RegisterService(DialogService.CreateXtraDialogService(this));

            var fluent = mvvmContext1.OfType<PatientsViewModel>();

            // 2. Automatyczne utworzenie kolumn, gdy dane z API trafią do siatki
            gridControl1.DataSourceChanged += (s, e) =>
            {
                if (gridView1.Columns.Count == 0 && gridControl1.DataSource != null)
                {
                    gridView1.PopulateColumns(); // Tworzy kolumny: Id, FirstName, LastName, Pesel, PhoneNumber
                    gridView1.BestFitColumns();  // Dopasowuje szerokość kolumn do tekstu
                }
            };

            // 3. Wiązanie listy pacjentów do GridControl
            fluent.SetBinding(gridControl1, gc => gc.DataSource, x => x.Patients);

            // 4. Wiązanie zaznaczonego rekordu w tabeli
            fluent.WithEvent<FocusedRowObjectChangedEventArgs>(gridView1, nameof(gridView1.FocusedRowObjectChanged))
                .SetBinding<PatientDto>(x => x.SelectedPatient, args => args.Row as PatientDto);

            // 5. Podwójne kliknięcie wywołuje edycję pacjenta
            fluent.WithEvent<RowClickEventArgs>(gridView1, nameof(gridView1.RowClick))
                .EventToCommand(x => x.EditPatient(), args => args.Clicks == 2);
        }
    }
}