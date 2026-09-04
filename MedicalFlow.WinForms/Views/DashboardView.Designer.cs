namespace MedicalFlow.WinForms.Views
{
    partial class DashboardView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.pnlHeader = new DevExpress.XtraEditors.PanelControl();
            this.lblHeaderSubtitle = new DevExpress.XtraEditors.LabelControl();
            this.lblHeaderTitle = new DevExpress.XtraEditors.LabelControl();
            this.tblCardsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cardPatients = new DevExpress.XtraEditors.PanelControl();
            this.lblTotalPatients = new DevExpress.XtraEditors.LabelControl();
            this.lblTitlePatients = new DevExpress.XtraEditors.LabelControl();
            this.cardQueue = new DevExpress.XtraEditors.PanelControl();
            this.lblWaitingQueue = new DevExpress.XtraEditors.LabelControl();
            this.lblTitleQueue = new DevExpress.XtraEditors.LabelControl();
            this.cardVisits = new DevExpress.XtraEditors.PanelControl();
            this.lblTodayVisits = new DevExpress.XtraEditors.LabelControl();
            this.lblTitleVisits = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.tblCardsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardPatients)).BeginInit();
            this.cardPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardQueue)).BeginInit();
            this.cardQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardVisits)).BeginInit();
            this.cardVisits.SuspendLayout();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(960, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeaderSubtitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblHeaderSubtitle.Appearance.Options.UseFont = true;
            this.lblHeaderSubtitle.Appearance.Options.UseForeColor = true;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(3, 35);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(305, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Podsumowanie dzisiejszego dnia i status przychodni";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeaderTitle.Appearance.Options.UseFont = true;
            this.lblHeaderTitle.Location = new System.Drawing.Point(3, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(236, 32);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Witaj w MedicalFlow";
            // 
            // tblCardsLayout
            // 
            this.tblCardsLayout.ColumnCount = 3;
            this.tblCardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblCardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblCardsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblCardsLayout.Controls.Add(this.cardPatients, 0, 0);
            this.tblCardsLayout.Controls.Add(this.cardQueue, 1, 0);
            this.tblCardsLayout.Controls.Add(this.cardVisits, 2, 0);
            this.tblCardsLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCardsLayout.Location = new System.Drawing.Point(20, 90);
            this.tblCardsLayout.Name = "tblCardsLayout";
            this.tblCardsLayout.RowCount = 1;
            this.tblCardsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCardsLayout.Size = new System.Drawing.Size(960, 130);
            this.tblCardsLayout.TabIndex = 1;
            // 
            // cardPatients
            // 
            this.cardPatients.Controls.Add(this.lblTotalPatients);
            this.cardPatients.Controls.Add(this.lblTitlePatients);
            this.cardPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPatients.Location = new System.Drawing.Point(3, 3);
            this.cardPatients.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cardPatients.Name = "cardPatients";
            this.cardPatients.Padding = new System.Windows.Forms.Padding(15);
            this.cardPatients.Size = new System.Drawing.Size(307, 124);
            this.cardPatients.TabIndex = 0;
            // 
            // lblTotalPatients
            // 
            this.lblTotalPatients.Appearance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalPatients.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblTotalPatients.Appearance.Options.UseFont = true;
            this.lblTotalPatients.Appearance.Options.UseForeColor = true;
            this.lblTotalPatients.Location = new System.Drawing.Point(18, 48);
            this.lblTotalPatients.Name = "lblTotalPatients";
            this.lblTotalPatients.Size = new System.Drawing.Size(21, 50);
            this.lblTotalPatients.TabIndex = 1;
            this.lblTotalPatients.Text = "0";
            // 
            // lblTitlePatients
            // 
            this.lblTitlePatients.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitlePatients.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblTitlePatients.Appearance.Options.UseFont = true;
            this.lblTitlePatients.Appearance.Options.UseForeColor = true;
            this.lblTitlePatients.Location = new System.Drawing.Point(18, 18);
            this.lblTitlePatients.Name = "lblTitlePatients";
            this.lblTitlePatients.Size = new System.Drawing.Size(178, 17);
            this.lblTitlePatients.TabIndex = 0;
            this.lblTitlePatients.Text = "ZAREJESTROWANI PACJENCI";
            // 
            // cardQueue
            // 
            this.cardQueue.Controls.Add(this.lblWaitingQueue);
            this.cardQueue.Controls.Add(this.lblTitleQueue);
            this.cardQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardQueue.Location = new System.Drawing.Point(323, 3);
            this.cardQueue.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cardQueue.Name = "cardQueue";
            this.cardQueue.Padding = new System.Windows.Forms.Padding(15);
            this.cardQueue.Size = new System.Drawing.Size(307, 124);
            this.cardQueue.TabIndex = 1;
            // 
            // lblWaitingQueue
            // 
            this.lblWaitingQueue.Appearance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblWaitingQueue.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(120)))), ((int)(((byte)(23)))));
            this.lblWaitingQueue.Appearance.Options.UseFont = true;
            this.lblWaitingQueue.Appearance.Options.UseForeColor = true;
            this.lblWaitingQueue.Location = new System.Drawing.Point(18, 48);
            this.lblWaitingQueue.Name = "lblWaitingQueue";
            this.lblWaitingQueue.Size = new System.Drawing.Size(21, 50);
            this.lblWaitingQueue.TabIndex = 1;
            this.lblWaitingQueue.Text = "0";
            // 
            // lblTitleQueue
            // 
            this.lblTitleQueue.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleQueue.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleQueue.Appearance.Options.UseFont = true;
            this.lblTitleQueue.Appearance.Options.UseForeColor = true;
            this.lblTitleQueue.Location = new System.Drawing.Point(18, 18);
            this.lblTitleQueue.Name = "lblTitleQueue";
            this.lblTitleQueue.Size = new System.Drawing.Size(160, 17);
            this.lblTitleQueue.TabIndex = 0;
            this.lblTitleQueue.Text = "PACJENCI W POCZEKALNI";
            // 
            // cardVisits
            // 
            this.cardVisits.Controls.Add(this.lblTodayVisits);
            this.cardVisits.Controls.Add(this.lblTitleVisits);
            this.cardVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardVisits.Location = new System.Drawing.Point(643, 3);
            this.cardVisits.Name = "cardVisits";
            this.cardVisits.Padding = new System.Windows.Forms.Padding(15);
            this.cardVisits.Size = new System.Drawing.Size(314, 124);
            this.cardVisits.TabIndex = 2;
            // 
            // lblTodayVisits
            // 
            this.lblTodayVisits.Appearance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTodayVisits.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.lblTodayVisits.Appearance.Options.UseFont = true;
            this.lblTodayVisits.Appearance.Options.UseForeColor = true;
            this.lblTodayVisits.Location = new System.Drawing.Point(18, 48);
            this.lblTodayVisits.Name = "lblTodayVisits";
            this.lblTodayVisits.Size = new System.Drawing.Size(21, 50);
            this.lblTodayVisits.TabIndex = 1;
            this.lblTodayVisits.Text = "0";
            // 
            // lblTitleVisits
            // 
            this.lblTitleVisits.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitleVisits.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleVisits.Appearance.Options.UseFont = true;
            this.lblTitleVisits.Appearance.Options.UseForeColor = true;
            this.lblTitleVisits.Location = new System.Drawing.Point(18, 18);
            this.lblTitleVisits.Name = "lblTitleVisits";
            this.lblTitleVisits.Size = new System.Drawing.Size(124, 17);
            this.lblTitleVisits.TabIndex = 0;
            this.lblTitleVisits.Text = "WIZYTY NA DZISIAJ";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblCardsLayout);
            this.Controls.Add(this.pnlHeader);
            this.Name = "DashboardView";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tblCardsLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardPatients)).EndInit();
            this.cardPatients.ResumeLayout(false);
            this.cardPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardQueue)).EndInit();
            this.cardQueue.ResumeLayout(false);
            this.cardQueue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardVisits)).EndInit();
            this.cardVisits.ResumeLayout(false);
            this.cardVisits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraEditors.PanelControl pnlHeader;
        private DevExpress.XtraEditors.LabelControl lblHeaderTitle;
        private DevExpress.XtraEditors.LabelControl lblHeaderSubtitle;
        private System.Windows.Forms.TableLayoutPanel tblCardsLayout;
        private DevExpress.XtraEditors.PanelControl cardPatients;
        private DevExpress.XtraEditors.LabelControl lblTitlePatients;
        private DevExpress.XtraEditors.LabelControl lblTotalPatients;
        private DevExpress.XtraEditors.PanelControl cardQueue;
        private DevExpress.XtraEditors.LabelControl lblTitleQueue;
        private DevExpress.XtraEditors.LabelControl lblWaitingQueue;
        private DevExpress.XtraEditors.PanelControl cardVisits;
        private DevExpress.XtraEditors.LabelControl lblTitleVisits;
        private DevExpress.XtraEditors.LabelControl lblTodayVisits;
    }
}