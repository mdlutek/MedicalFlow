namespace MedicalFlow.WinForms
{
    partial class MainView
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnPatients = new DevExpress.XtraBars.BarButtonItem();
            this.btnPatientEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDashboard = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalendar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bsiServerStatus = new DevExpress.XtraBars.BarStaticItem();
            this.bsiAppInfo = new DevExpress.XtraBars.BarStaticItem();
            this.bsiDate = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.mainNavigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigationFrame)).BeginInit();
            this.mainNavigationFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnPatients,
            this.btnPatientEdit,
            this.barButtonItem3,
            this.btnDashboard,
            this.btnCalendar,
            this.barButtonItem1,
            this.barButtonItem4,
            this.bsiServerStatus,
            this.bsiAppInfo,
            this.bsiDate});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(984, 158);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnPatients
            // 
            this.btnPatients.Caption = "Lista Pacjentów";
            this.btnPatients.Id = 1;
            this.btnPatients.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPatients.ImageOptions.SvgImage")));
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPatientEdit
            // 
            this.btnPatientEdit.Caption = "Dodaj Pacjenta";
            this.btnPatientEdit.Id = 2;
            this.btnPatientEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPatientEdit.ImageOptions.SvgImage")));
            this.btnPatientEdit.Name = "btnPatientEdit";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Odśwież";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Caption = "Pulpit ";
            this.btnDashboard.Id = 4;
            this.btnDashboard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDashboard.ImageOptions.SvgImage")));
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Caption = "Kalendarz Wizyt";
            this.btnCalendar.Id = 5;
            this.btnCalendar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCalendar.ImageOptions.SvgImage")));
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Obsługa wizyty";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Karta Pacjenta";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // bsiServerStatus
            // 
            this.bsiServerStatus.Caption = "🟢 Serwer API: Połączono";
            this.bsiServerStatus.Id = 8;
            this.bsiServerStatus.Name = "bsiServerStatus";
            // 
            // bsiAppInfo
            // 
            this.bsiAppInfo.Caption = "MedicalFlow v1.0";
            this.bsiAppInfo.Id = 9;
            this.bsiAppInfo.Name = "bsiAppInfo";
            // 
            // bsiDate
            // 
            this.bsiDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiDate.Caption = "Data: Ładowanie...";
            this.bsiDate.Id = 10;
            this.bsiDate.Name = "bsiDate";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Recepcja";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDashboard);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCalendar);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Recepcja";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPatients);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPatientEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Pacjenci";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Gabinet ";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiServerStatus);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiAppInfo);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiDate);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 576);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(984, 24);
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(MedicalFlow.WinForms.ViewModels.MainViewModel);
            // 
            // mainNavigationFrame
            // 
            this.mainNavigationFrame.Controls.Add(this.navigationPage1);
            this.mainNavigationFrame.Controls.Add(this.navigationPage2);
            this.mainNavigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainNavigationFrame.Location = new System.Drawing.Point(0, 158);
            this.mainNavigationFrame.Name = "mainNavigationFrame";
            this.mainNavigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.mainNavigationFrame.SelectedPage = this.navigationPage1;
            this.mainNavigationFrame.Size = new System.Drawing.Size(984, 418);
            this.mainNavigationFrame.TabIndex = 1;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(984, 418);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(984, 418);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.mainNavigationFrame);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainView";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "MedicalFlow - System Obsługi Przychodni";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigationFrame)).EndInit();
            this.mainNavigationFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.BarButtonItem btnPatients;
        private DevExpress.XtraBars.BarButtonItem btnPatientEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Navigation.NavigationFrame mainNavigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.BarButtonItem btnDashboard;
        private DevExpress.XtraBars.BarButtonItem btnCalendar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarStaticItem bsiServerStatus;
        private DevExpress.XtraBars.BarStaticItem bsiAppInfo;
        private DevExpress.XtraBars.BarStaticItem bsiDate;
    }
}