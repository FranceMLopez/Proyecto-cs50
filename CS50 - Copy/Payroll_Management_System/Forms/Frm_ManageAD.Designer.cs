
namespace Payroll_Management_System.Forms
{
    partial class Frm_ManageAD
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ManageAD));
            this.bunifuFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.AppBar = new Bunifu.Utils.BunifuAppBar();
            this.nav = new Kimtoo.ButtonGroup();
            this.pages = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.page_Allowance1 = new Payroll_Management_System.Pages.Page_Allowance();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.page_Deduction1 = new Payroll_Management_System.Pages.Page_Deduction();
            this.pages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFormDock
            // 
            this.bunifuFormDock.AllowFormDragging = true;
            this.bunifuFormDock.AllowFormDropShadow = true;
            this.bunifuFormDock.AllowFormResizing = true;
            this.bunifuFormDock.AllowHidingBottomRegion = true;
            this.bunifuFormDock.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock.ContainerControl = this;
            this.bunifuFormDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock.DockingOptions.DockAll = true;
            this.bunifuFormDock.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock.DockingOptions.DockLeft = true;
            this.bunifuFormDock.DockingOptions.DockRight = true;
            this.bunifuFormDock.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock.DockingOptions.DockTopRight = true;
            this.bunifuFormDock.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock.ParentForm = this;
            this.bunifuFormDock.ShowCursorChanges = true;
            this.bunifuFormDock.ShowDockingIndicators = false;
            this.bunifuFormDock.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock.TitleBarOptions.BunifuFormDock = this.bunifuFormDock;
            this.bunifuFormDock.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // AppBar
            // 
            this.AppBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.AppBar.ControlBoxColor = System.Drawing.Color.WhiteSmoke;
            this.AppBar.ControlBoxColorActive = System.Drawing.Color.White;
            this.AppBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AppBar.ForeColor = System.Drawing.Color.White;
            this.AppBar.Icon = ((System.Drawing.Image)(resources.GetObject("AppBar.Icon")));
            this.AppBar.Location = new System.Drawing.Point(0, 0);
            this.AppBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AppBar.Name = "AppBar";
            this.AppBar.Size = new System.Drawing.Size(1143, 57);
            this.AppBar.TabIndex = 7;
            this.AppBar.Title = "Prestamos y deducciones";
            this.AppBar.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            this.AppBar.IconClick += new System.EventHandler(this.AppBar_IconClick);
            // 
            // nav
            // 
            this.nav.BackColor = System.Drawing.Color.RoyalBlue;
            this.nav.BackColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.nav.ButtonSpacing = 60;
            this.nav.CurrentSelection = "Prestamos";
            this.nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav.FontActive = null;
            this.nav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nav.ForeColorActive = System.Drawing.Color.White;
            this.nav.Items = new string[] {
        "Allowances",
        "Deductions"};
            this.nav.Location = new System.Drawing.Point(0, 57);
            this.nav.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nav.Name = "nav";
            this.nav.Orientation = Kimtoo.ButtonGroup.ButtongrupOrientation.Horizontal;
            this.nav.Size = new System.Drawing.Size(1143, 63);
            this.nav.TabIndex = 8;
            this.nav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nav.OnSelectionChange += new System.EventHandler(this.nav_OnSelectionChange);
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages.AllowTransitions = false;
            this.pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pages.Controls.Add(this.tabPage1);
            this.pages.Controls.Add(this.tabPage2);
            this.pages.Location = new System.Drawing.Point(11, 129);
            this.pages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.Page = this.tabPage2;
            this.pages.PageIndex = 1;
            this.pages.PageName = "tabPage2";
            this.pages.PageTitle = "Deductions";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(1120, 590);
            this.pages.TabIndex = 9;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pages.Transition = animation1;
            this.pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.page_Allowance1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1112, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Allowances";
            // 
            // page_Allowance1
            // 
            this.page_Allowance1.AllowAdd = true;
            this.page_Allowance1.AllowDelete = true;
            this.page_Allowance1.AllowEdit = true;
            this.page_Allowance1.AllowSearch = true;
            this.page_Allowance1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.page_Allowance1.BeforeDelete = null;
            this.page_Allowance1.DataLimit = 0;
            this.page_Allowance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Allowance1.Location = new System.Drawing.Point(4, 4);
            this.page_Allowance1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.page_Allowance1.Name = "page_Allowance1";
            this.page_Allowance1.Size = new System.Drawing.Size(1104, 554);
            this.page_Allowance1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.page_Deduction1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1112, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deductions";
            // 
            // page_Deduction1
            // 
            this.page_Deduction1.AllowAdd = true;
            this.page_Deduction1.AllowDelete = true;
            this.page_Deduction1.AllowEdit = true;
            this.page_Deduction1.AllowSearch = true;
            this.page_Deduction1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.page_Deduction1.BeforeDelete = null;
            this.page_Deduction1.DataLimit = 0;
            this.page_Deduction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Deduction1.Location = new System.Drawing.Point(4, 4);
            this.page_Deduction1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.page_Deduction1.Name = "page_Deduction1";
            this.page_Deduction1.Size = new System.Drawing.Size(1104, 553);
            this.page_Deduction1.TabIndex = 1;
            // 
            // Frm_ManageAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1143, 729);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.AppBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_ManageAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prestamos y deducciones";
            this.pages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock;
        public Bunifu.Utils.BunifuAppBar AppBar;
        private Kimtoo.ButtonGroup nav;
        private Bunifu.UI.WinForms.BunifuPages pages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Pages.Page_Allowance page_Allowance1;
        private Pages.Page_Deduction page_Deduction1;
    }
}