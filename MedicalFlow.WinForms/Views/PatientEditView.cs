using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using MedicalFlow.WinForms.ViewModels;

namespace MedicalFlow.WinForms.Views
{
    public partial class PatientEditView : XtraUserControl
    {
        public PatientEditView()
        {
            InitializeComponent();
            if (!DesignMode)
                InitializeMvvm();
        }

        private void InitializeMvvm()
        {
            // 1. Pobieramy ViewModel z kontenera DI
            var viewModel = Program.ServiceProvider.GetRequiredService<PatientEditViewModel>();
            mvvmContext1.SetViewModel(typeof(PatientEditViewModel), viewModel);

            var fluent = mvvmContext1.OfType<PatientEditViewModel>();

            // 2. Dwukierunkowe bindowanie pól tekstowych
            fluent.SetBinding(txtFirstName, txt => txt.EditValue, x => x.Patient.FirstName);
            fluent.SetBinding(txtLastName, txt => txt.EditValue, x => x.Patient.LastName);
            fluent.SetBinding(txtPesel, txt => txt.EditValue, x => x.Patient.Pesel);
            fluent.SetBinding(txtPhone, txt => txt.EditValue, x => x.Patient.PhoneNumber);

            // 3. Wiązanie przycisków akcji z komendami ViewModelu
            fluent.BindCommand(btnSave, x => x.Save());
            fluent.BindCommand(btnCancel, x => x.Cancel());
        }
    }
}