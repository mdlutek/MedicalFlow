namespace MedicalFlow.WinForms.Views
{
    partial class PatientEditView
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.lblHeaderTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblHeaderSubtitle = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtPesel = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupHeader = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciHeaderTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHeaderSubtitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupPersonalData = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItemButtons = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeaderTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeaderSubtitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPersonalData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.lblHeaderTitle);
            this.dataLayoutControl1.Controls.Add(this.lblHeaderSubtitle);
            this.dataLayoutControl1.Controls.Add(this.txtFirstName);
            this.dataLayoutControl1.Controls.Add(this.txtLastName);
            this.dataLayoutControl1.Controls.Add(this.txtPesel);
            this.dataLayoutControl1.Controls.Add(this.txtPhone);
            this.dataLayoutControl1.Controls.Add(this.btnSave);
            this.dataLayoutControl1.Controls.Add(this.btnCancel);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 500);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.Appearance.Options.UseFont = true;
            this.lblHeaderTitle.Location = new System.Drawing.Point(24, 24);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(262, 30);
            this.lblHeaderTitle.StyleController = this.dataLayoutControl1;
            this.lblHeaderTitle.TabIndex = 6;
            this.lblHeaderTitle.Text = "Karta Pacjenta";
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblHeaderSubtitle.Appearance.Options.UseFont = true;
            this.lblHeaderSubtitle.Appearance.Options.UseForeColor = true;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(24, 58);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(324, 17);
            this.lblHeaderSubtitle.StyleController = this.dataLayoutControl1;
            this.lblHeaderSubtitle.TabIndex = 7;
            this.lblHeaderSubtitle.Text = "Wprowadź lub edytuj dane identyfikacyjne i kontaktowe";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 133);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.Properties.Appearance.Options.UseFont = true;
            this.txtFirstName.Size = new System.Drawing.Size(266, 24);
            this.txtFirstName.StyleController = this.dataLayoutControl1;
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(486, 133);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.Properties.Appearance.Options.UseFont = true;
            this.txtLastName.Size = new System.Drawing.Size(290, 24);
            this.txtLastName.StyleController = this.dataLayoutControl1;
            this.txtLastName.TabIndex = 2;
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(120, 161);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPesel.Properties.Appearance.Options.UseFont = true;
            this.txtPesel.Properties.MaxLength = 11;
            this.txtPesel.Size = new System.Drawing.Size(266, 24);
            this.txtPesel.StyleController = this.dataLayoutControl1;
            this.txtPesel.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(486, 161);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Size = new System.Drawing.Size(290, 24);
            this.txtPhone.StyleController = this.dataLayoutControl1;
            this.txtPhone.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(646, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnSave.Size = new System.Drawing.Size(142, 34);
            this.btnSave.StyleController = this.dataLayoutControl1;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "💾 Zapisz dane";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(490, 444);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnCancel.Size = new System.Drawing.Size(152, 34);
            this.btnCancel.StyleController = this.dataLayoutControl1;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "↩️ Wróć do listy";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupHeader,
            this.groupPersonalData,
            this.emptySpaceItem1,
            this.emptySpaceItemButtons,
            this.layoutControlItemSave,
            this.layoutControlItemCancel});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 500);
            this.Root.TextVisible = false;
            // 
            // groupHeader
            // 
            this.groupHeader.GroupBordersVisible = false;
            this.groupHeader.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciHeaderTitle,
            this.lciHeaderSubtitle});
            this.groupHeader.Location = new System.Drawing.Point(0, 0);
            this.groupHeader.Name = "groupHeader";
            this.groupHeader.Size = new System.Drawing.Size(780, 75);
            // 
            // lciHeaderTitle
            // 
            this.lciHeaderTitle.Control = this.lblHeaderTitle;
            this.lciHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lciHeaderTitle.Name = "lciHeaderTitle";
            this.lciHeaderTitle.Size = new System.Drawing.Size(780, 34);
            this.lciHeaderTitle.TextSize = new System.Drawing.Size(0, 0);
            this.lciHeaderTitle.TextVisible = false;
            // 
            // lciHeaderSubtitle
            // 
            this.lciHeaderSubtitle.Control = this.lblHeaderSubtitle;
            this.lciHeaderSubtitle.Location = new System.Drawing.Point(0, 34);
            this.lciHeaderSubtitle.Name = "lciHeaderSubtitle";
            this.lciHeaderSubtitle.Size = new System.Drawing.Size(780, 21);
            this.lciHeaderSubtitle.TextSize = new System.Drawing.Size(0, 0);
            this.lciHeaderSubtitle.TextVisible = false;
            // 
            // groupPersonalData
            // 
            this.groupPersonalData.AppearanceGroup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupPersonalData.AppearanceGroup.Options.UseFont = true;
            this.groupPersonalData.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.groupPersonalData.Location = new System.Drawing.Point(0, 75);
            this.groupPersonalData.Name = "groupPersonalData";
            this.groupPersonalData.Size = new System.Drawing.Size(780, 114);
            this.groupPersonalData.Text = "Dane Identyfikacyjne i Kontaktowe";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtFirstName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(366, 28);
            this.layoutControlItem1.Text = "Imię:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtLastName;
            this.layoutControlItem2.Location = new System.Drawing.Point(366, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(390, 28);
            this.layoutControlItem2.Text = "Nazwisko:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txtPesel;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(366, 28);
            this.layoutControlItem3.Text = "PESEL:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtPhone;
            this.layoutControlItem4.Location = new System.Drawing.Point(366, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(390, 28);
            this.layoutControlItem4.Text = "Telefon:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(84, 17);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 189);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 243);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItemButtons
            // 
            this.emptySpaceItemButtons.Location = new System.Drawing.Point(0, 432);
            this.emptySpaceItemButtons.Name = "emptySpaceItemButtons";
            this.emptySpaceItemButtons.Size = new System.Drawing.Size(478, 48);
            this.emptySpaceItemButtons.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemSave
            // 
            this.layoutControlItemSave.Control = this.btnSave;
            this.layoutControlItemSave.Location = new System.Drawing.Point(634, 432);
            this.layoutControlItemSave.MaxSize = new System.Drawing.Size(146, 48);
            this.layoutControlItemSave.MinSize = new System.Drawing.Size(146, 48);
            this.layoutControlItemSave.Name = "layoutControlItemSave";
            this.layoutControlItemSave.Size = new System.Drawing.Size(146, 48);
            this.layoutControlItemSave.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemSave.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemSave.TextVisible = false;
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.Location = new System.Drawing.Point(478, 432);
            this.layoutControlItemCancel.MaxSize = new System.Drawing.Size(156, 48);
            this.layoutControlItemCancel.MinSize = new System.Drawing.Size(156, 48);
            this.layoutControlItemCancel.Name = "layoutControlItemCancel";
            this.layoutControlItemCancel.Size = new System.Drawing.Size(156, 48);
            this.layoutControlItemCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItemCancel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCancel.TextVisible = false;
            // 
            // PatientEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "PatientEditView";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeaderTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeaderSubtitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPersonalData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.LabelControl lblHeaderTitle;
        private DevExpress.XtraEditors.LabelControl lblHeaderSubtitle;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.TextEdit txtPesel;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup groupHeader;
        private DevExpress.XtraLayout.LayoutControlItem lciHeaderTitle;
        private DevExpress.XtraLayout.LayoutControlItem lciHeaderSubtitle;
        private DevExpress.XtraLayout.LayoutControlGroup groupPersonalData;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemButtons;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCancel;
    }
}