
namespace Payroll_Management_System
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuAppBar1 = new Bunifu.Utils.BunifuAppBar();
            this.nav = new Kimtoo.NavigtionMenu();
            this.pages = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.page_Payroll1 = new Payroll_Management_System.Pages.Page_Payroll();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.page_Employee1 = new Payroll_Management_System.Pages.Page_Employee();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.page_Department1 = new Payroll_Management_System.Pages.Page_Department();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pages.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuAppBar1
            // 
            this.bunifuAppBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(61)))));
            this.bunifuAppBar1.ControlBoxColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuAppBar1.ControlBoxColorActive = System.Drawing.Color.White;
            this.bunifuAppBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuAppBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuAppBar1.ForeColor = System.Drawing.Color.White;
            this.bunifuAppBar1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuAppBar1.Icon")));
            this.bunifuAppBar1.Location = new System.Drawing.Point(0, 0);
            this.bunifuAppBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuAppBar1.Name = "bunifuAppBar1";
            this.bunifuAppBar1.Size = new System.Drawing.Size(1499, 57);
            this.bunifuAppBar1.TabIndex = 0;
            this.bunifuAppBar1.Title = "Boing-Company ";
            this.bunifuAppBar1.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            // 
            // nav
            // 
            this.nav.AutoScroll = true;
            this.nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(61)))));
            this.nav.BackColor_Click = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.nav.BackColor_Hover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.nav.BackColor_Selected = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(104)))), ((int)(((byte)(240)))));
            this.nav.DisableToggling = new string[] {
        "Company",
        "Database"};
            this.nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nav.ForeColor_Selected = System.Drawing.Color.White;
            this.nav.IsExpandable = false;
            this.nav.IsExpanded = true;
            this.nav.ItemHeight = 50;
            this.nav.ItemImageSize = new System.Drawing.Size(20, 20);
            this.nav.ItemPadding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.nav.ItemRightImageMargin = 20;
            this.nav.ItemRightImageSize = new System.Drawing.Size(15, 15);
            this.nav.Items = new Kimtoo.ButtonItem[] {
        ((Kimtoo.ButtonItem)(resources.GetObject("nav.Items"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("nav.Items1"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("nav.Items2"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("nav.Items3"))),
        ((Kimtoo.ButtonItem)(resources.GetObject("nav.Items4")))};
            this.nav.ItemTextMargin = 8;
            this.nav.Location = new System.Drawing.Point(0, 57);
            this.nav.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(199, 865);
            this.nav.TabIndex = 1;
            this.nav.OnItemSelected += new Kimtoo.NavigtionMenu.OnSelectEventHandler(this.nav_OnItemSelected);
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages.AllowTransitions = false;
            this.pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pages.Controls.Add(this.tabPage3);
            this.pages.Controls.Add(this.tabPage2);
            this.pages.Controls.Add(this.tabPage4);
            this.pages.Controls.Add(this.tabPage8);
            this.pages.Location = new System.Drawing.Point(268, 58);
            this.pages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.Page = this.tabPage3;
            this.pages.PageIndex = 0;
            this.pages.PageName = "tabPage3";
            this.pages.PageTitle = "Payroll";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(1224, 857);
            this.pages.TabIndex = 2;
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.pages.Transition = animation2;
            this.pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.page_Payroll1);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1216, 828);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Payroll";
            // 
            // page_Payroll1
            // 
            this.page_Payroll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Payroll1.Location = new System.Drawing.Point(4, 4);
            this.page_Payroll1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.page_Payroll1.Name = "page_Payroll1";
            this.page_Payroll1.Size = new System.Drawing.Size(1208, 820);
            this.page_Payroll1.TabIndex = 0;
            this.page_Payroll1.Load += new System.EventHandler(this.page_Payroll1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.page_Employee1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1216, 828);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employees";
            // 
            // page_Employee1
            // 
            this.page_Employee1.AllowAdd = true;
            this.page_Employee1.AllowDelete = true;
            this.page_Employee1.AllowEdit = true;
            this.page_Employee1.AllowSearch = true;
            this.page_Employee1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.page_Employee1.BeforeDelete = null;
            this.page_Employee1.DataLimit = 0;
            this.page_Employee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Employee1.Location = new System.Drawing.Point(4, 4);
            this.page_Employee1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.page_Employee1.Name = "page_Employee1";
            this.page_Employee1.Size = new System.Drawing.Size(1208, 820);
            this.page_Employee1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.page_Department1);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(1216, 828);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Departments";
            // 
            // page_Department1
            // 
            this.page_Department1.AllowAdd = true;
            this.page_Department1.AllowDelete = true;
            this.page_Department1.AllowEdit = true;
            this.page_Department1.AllowSearch = true;
            this.page_Department1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.page_Department1.BeforeDelete = null;
            this.page_Department1.DataLimit = 0;
            this.page_Department1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Department1.Location = new System.Drawing.Point(4, 4);
            this.page_Department1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.page_Department1.Name = "page_Department1";
            this.page_Department1.Size = new System.Drawing.Size(1208, 820);
            this.page_Department1.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage8.Location = new System.Drawing.Point(4, 4);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage8.Size = new System.Drawing.Size(1216, 828);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Company";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1499, 922);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.bunifuAppBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.pages.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Kimtoo.NavigtionMenu nav;
        private Bunifu.UI.WinForms.BunifuPages pages;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Timer timer1;
        private Pages.Page_Employee page_Employee1;
        private Pages.Page_Department page_Department1;
        private Pages.Page_Payroll page_Payroll1;
        protected Bunifu.Utils.BunifuAppBar bunifuAppBar1;
    }
}

