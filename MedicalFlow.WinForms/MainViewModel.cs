using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalFlow.WinForms
{
    [POCOViewModel()]
    public class MainViewModel
    {
        public string Title
        {
            get;
        }

        public MainViewModel()
        {
            Title = "Ribbon Based Application (MVVM)";
        }

        public async Task OnCreate()
        {
            // Do some initialization (if required)
            await Task.CompletedTask;
        }

        public async Task OnDestroy()
        {
            // Do some cleanup (if required)
            await Task.CompletedTask;
        }
    }
}
