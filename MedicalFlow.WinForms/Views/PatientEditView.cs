using DevExpress.XtraEditors;
using MedicalFlow.WinForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalFlow.WinForms.Views
{
    public partial class PatientEditView : DevExpress.XtraEditors.XtraUserControl
    {
        public PatientEditView()
        {
            InitializeComponent();
            if (!DesignMode)
                InitializeMvvm();
        }

        private void InitializeMvvm()
        {
            var fluent = mvvmContext1.OfType<PatientEditViewModel>();

            // Dwukierunkowe wiązanie pól tekstowych z właściwościami encji Patient
            fluent.SetBinding(txtFirstName, txt => txt.EditValue, x => x.Patient.FirstName);
            fluent.SetBinding(txtLastName, txt => txt.EditValue, x => x.Patient.LastName);
            fluent.SetBinding(txtPesel, txt => txt.EditValue, x => x.Patient.Pesel);
            fluent.SetBinding(txtPhone, txt => txt.EditValue, x => x.Patient.PhoneNumber);
        }
    }
}
