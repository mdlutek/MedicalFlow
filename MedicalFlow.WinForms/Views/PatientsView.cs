using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MedicalFlow.Domain.Dtos;
using MedicalFlow.Infrastructure.Xpo.Entities;
using MedicalFlow.WinForms.ViewModels;

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
            // Rejestracja serwisu okien dialogowych dla kontekstu MVVM
            mvvmContext1.RegisterService(DialogService.CreateXtraDialogService(this));

            var fluent = mvvmContext1.OfType<PatientsViewModel>();

            // 1. Bindowanie listy pacjentów do GridControl
            fluent.SetBinding(gridControl1, gc => gc.DataSource, x => x.Patients);

            // 2. Wiązanie zaznaczonego rekordu w tabeli z polem SelectedPatient (jawnym typem PatientDto)
            fluent.WithEvent<FocusedRowObjectChangedEventArgs>(gridView1, nameof(gridView1.FocusedRowObjectChanged))
                .SetBinding<PatientDto>(x => x.SelectedPatient, args => args.Row as PatientDto);

            // 3. Podwójne kliknięcie na wiersz w tabeli wywołuje edycję pacjenta
            fluent.WithEvent<DevExpress.XtraGrid.Views.Grid.RowClickEventArgs>(gridView1, nameof(gridView1.RowClick))
                .EventToCommand(x => x.EditPatient(), args => args.Clicks == 2);
        }
    }
}