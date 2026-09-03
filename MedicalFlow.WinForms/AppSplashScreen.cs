using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicalFlow.WinForms
{
    public partial class AppSplashScreen : SplashScreen
    {
        public AppSplashScreen()
        {
            InitializeComponent();
            this.labelCopyright.Text = $"Copyright © {DateTime.Now.Year}";            
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);

            // Obsługa komendy przysłanej z głównego wątku (Program.cs)
            if (cmd is SplashScreenCommand command)
            {
                switch (command)
                {
                    case SplashScreenCommand.SetStatus:
                        // Aktualizacja etykiety ze statusem na ekranie ładowania
                        labelStatus.Text = arg as string;
                        break;
                }
            }
        }


        #endregion

        // Definicja komend, które możemy wysyłać do okna ładowania
        public enum SplashScreenCommand
        {
            SetStatus
        }
    }
}