namespace MedicalFlow.WinForms.Views
{
    partial class DashboardView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.lblTotalPatients = new DevExpress.XtraEditors.LabelControl();
            this.lblWaitingQueue = new DevExpress.XtraEditors.LabelControl();
            this.lblTodayVisits = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // lblTotalPatients
            // 
            this.lblTotalPatients.Location = new System.Drawing.Point(22, 34);
            this.lblTotalPatients.Name = "lblTotalPatients";
            this.lblTotalPatients.Size = new System.Drawing.Size(63, 13);
            this.lblTotalPatients.TabIndex = 0;
            this.lblTotalPatients.Text = "labelControl1";
            // 
            // lblWaitingQueue
            // 
            this.lblWaitingQueue.Location = new System.Drawing.Point(22, 106);
            this.lblWaitingQueue.Name = "lblWaitingQueue";
            this.lblWaitingQueue.Size = new System.Drawing.Size(63, 13);
            this.lblWaitingQueue.TabIndex = 1;
            this.lblWaitingQueue.Text = "labelControl2";
            // 
            // lblTodayVisits
            // 
            this.lblTodayVisits.Location = new System.Drawing.Point(22, 176);
            this.lblTodayVisits.Name = "lblTodayVisits";
            this.lblTodayVisits.Size = new System.Drawing.Size(63, 13);
            this.lblTodayVisits.TabIndex = 2;
            this.lblTodayVisits.Text = "labelControl3";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(171, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Liczba zarejestrowanych pacjentów";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Pacjenci w poczekalni";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 157);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Wizyty na dzisiaj";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblTodayVisits);
            this.Controls.Add(this.lblWaitingQueue);
            this.Controls.Add(this.lblTotalPatients);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(687, 461);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTodayVisits;
        private DevExpress.XtraEditors.LabelControl lblWaitingQueue;
        private DevExpress.XtraEditors.LabelControl lblTotalPatients;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
