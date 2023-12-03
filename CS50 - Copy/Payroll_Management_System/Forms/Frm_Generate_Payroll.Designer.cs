
namespace Payroll_Management_System.Forms
{
    partial class Frm_Generate_Payroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Generate_Payroll));
            Kimtoo.ValidationProvider.ValidationObject validationObject9 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject8 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject2 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject3 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject4 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject5 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject6 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject7 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject1 = new Kimtoo.ValidationProvider.ValidationObject();
            this.bunifuFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.AppBar = new Bunifu.Utils.BunifuAppBar();
            this.validationProvider1 = new Kimtoo.ValidationProvider.ValidationProvider();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.cmbYear = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new Bunifu.UI.WinForms.BunifuDropdown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Alert = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.pnlContent.SuspendLayout();
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
            validationObject9.CustomErrorMessage = "";
            validationObject9.Optional = false;
            validationObject9.PropertyName = "Text";
            validationObject9.Regex = null;
            validationObject9.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.AppBar, validationObject9);
            this.AppBar.Location = new System.Drawing.Point(0, 0);
            this.AppBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AppBar.Name = "AppBar";
            this.AppBar.Size = new System.Drawing.Size(863, 57);
            this.AppBar.TabIndex = 7;
            this.AppBar.Title = "Titl";
            this.AppBar.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            this.AppBar.IconClick += new System.EventHandler(this.AppBar_IconClick);
            // 
            // validationProvider1
            // 
            this.validationProvider1.ErrorColor = System.Drawing.Color.Crimson;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.cmbYear);
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.btnAdd);
            this.pnlContent.Controls.Add(this.lblYear);
            this.pnlContent.Controls.Add(this.lblMonth);
            this.pnlContent.Controls.Add(this.cmbMonth);
            validationObject8.CustomErrorMessage = "";
            validationObject8.Optional = false;
            validationObject8.PropertyName = "Text";
            validationObject8.Regex = null;
            validationObject8.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.pnlContent, validationObject8);
            this.pnlContent.Location = new System.Drawing.Point(16, 92);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(831, 254);
            this.pnlContent.TabIndex = 18;
            // 
            // cmbYear
            // 
            this.cmbYear.BackColor = System.Drawing.Color.Transparent;
            this.cmbYear.BackgroundColor = System.Drawing.Color.White;
            this.cmbYear.BorderColor = System.Drawing.Color.Silver;
            this.cmbYear.BorderRadius = 1;
            this.cmbYear.Color = System.Drawing.Color.Silver;
            this.cmbYear.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbYear.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbYear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbYear.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbYear.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbYear.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYear.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbYear.FillDropDown = true;
            this.cmbYear.FillIndicator = false;
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbYear.ForeColor = System.Drawing.Color.Black;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Icon = null;
            this.cmbYear.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbYear.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbYear.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbYear.IndicatorThickness = 2;
            this.cmbYear.IsDropdownOpened = false;
            this.cmbYear.ItemBackColor = System.Drawing.Color.White;
            this.cmbYear.ItemBorderColor = System.Drawing.Color.White;
            this.cmbYear.ItemForeColor = System.Drawing.Color.Black;
            this.cmbYear.ItemHeight = 26;
            this.cmbYear.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbYear.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbYear.ItemTopMargin = 3;
            validationObject2.CustomErrorMessage = "";
            validationObject2.Optional = false;
            validationObject2.PropertyName = "Text";
            validationObject2.Regex = "(.|\\s)*\\S(.|\\s)*";
            validationObject2.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.NotEmpty;
            this.validationProvider1.SetLink(this.cmbYear, validationObject2);
            this.cmbYear.Location = new System.Drawing.Point(203, 31);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(544, 32);
            this.cmbYear.TabIndex = 24;
            this.cmbYear.Text = null;
            this.cmbYear.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbYear.TextLeftMargin = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DodgerBlue;
            validationObject3.CustomErrorMessage = "";
            validationObject3.Optional = false;
            validationObject3.PropertyName = "Text";
            validationObject3.Regex = null;
            validationObject3.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.btnCancel, validationObject3);
            this.btnCancel.Location = new System.Drawing.Point(461, 191);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 49);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            validationObject4.CustomErrorMessage = "";
            validationObject4.Optional = false;
            validationObject4.PropertyName = "Text";
            validationObject4.Regex = null;
            validationObject4.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.btnAdd, validationObject4);
            this.btnAdd.Location = new System.Drawing.Point(595, 191);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 49);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Generar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            validationObject5.CustomErrorMessage = "";
            validationObject5.Optional = false;
            validationObject5.PropertyName = "Text";
            validationObject5.Regex = null;
            validationObject5.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.lblYear, validationObject5);
            this.lblYear.Location = new System.Drawing.Point(36, 31);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(28, 16);
            this.lblYear.TabIndex = 18;
            this.lblYear.Text = "An*";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            validationObject6.CustomErrorMessage = "";
            validationObject6.Optional = false;
            validationObject6.PropertyName = "Text";
            validationObject6.Regex = null;
            validationObject6.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.lblMonth, validationObject6);
            this.lblMonth.Location = new System.Drawing.Point(36, 117);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(38, 16);
            this.lblMonth.TabIndex = 20;
            this.lblMonth.Text = "Mes*";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMonth.BackColor = System.Drawing.Color.White;
            this.cmbMonth.BackgroundColor = System.Drawing.Color.White;
            this.cmbMonth.BorderColor = System.Drawing.Color.Silver;
            this.cmbMonth.BorderRadius = 1;
            this.cmbMonth.Color = System.Drawing.Color.Silver;
            this.cmbMonth.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbMonth.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbMonth.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbMonth.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbMonth.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbMonth.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonth.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbMonth.FillDropDown = true;
            this.cmbMonth.FillIndicator = false;
            this.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMonth.ForeColor = System.Drawing.Color.Black;
            this.cmbMonth.Icon = null;
            this.cmbMonth.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbMonth.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbMonth.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbMonth.IndicatorThickness = 2;
            this.cmbMonth.IsDropdownOpened = false;
            this.cmbMonth.ItemBackColor = System.Drawing.Color.White;
            this.cmbMonth.ItemBorderColor = System.Drawing.Color.White;
            this.cmbMonth.ItemForeColor = System.Drawing.Color.Black;
            this.cmbMonth.ItemHeight = 26;
            this.cmbMonth.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbMonth.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cmbMonth.ItemTopMargin = 3;
            validationObject7.CustomErrorMessage = "";
            validationObject7.Optional = false;
            validationObject7.PropertyName = "Text";
            validationObject7.Regex = "(.|\\s)*\\S(.|\\s)*";
            validationObject7.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.NotEmpty;
            this.validationProvider1.SetLink(this.cmbMonth, validationObject7);
            this.cmbMonth.Location = new System.Drawing.Point(203, 105);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(544, 32);
            this.cmbMonth.TabIndex = 21;
            this.cmbMonth.Text = null;
            this.cmbMonth.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbMonth.TextLeftMargin = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            validationObject1.CustomErrorMessage = "";
            validationObject1.Optional = false;
            validationObject1.PropertyName = "Text";
            validationObject1.Regex = null;
            validationObject1.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider1.SetLink(this.progressBar1, validationObject1);
            this.progressBar1.Location = new System.Drawing.Point(0, 57);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(863, 28);
            this.progressBar1.TabIndex = 19;
            // 
            // Alert
            // 
            this.Alert.AllowDragging = false;
            this.Alert.AllowMultipleViews = true;
            this.Alert.ClickToClose = true;
            this.Alert.DoubleClickToClose = true;
            this.Alert.DurationAfterIdle = 3000;
            this.Alert.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.ErrorOptions.ActionBorderRadius = 1;
            this.Alert.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.Alert.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.Alert.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.Alert.ErrorOptions.IconLeftMargin = 12;
            this.Alert.FadeCloseIcon = false;
            this.Alert.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.Alert.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.ActionBorderRadius = 1;
            this.Alert.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.InformationOptions.BackColor = System.Drawing.Color.White;
            this.Alert.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Alert.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.Alert.InformationOptions.IconLeftMargin = 12;
            this.Alert.Margin = 10;
            this.Alert.MaximumSize = new System.Drawing.Size(0, 0);
            this.Alert.MaximumViews = 7;
            this.Alert.MessageRightMargin = 15;
            this.Alert.MinimumSize = new System.Drawing.Size(0, 0);
            this.Alert.ShowBorders = false;
            this.Alert.ShowCloseIcon = false;
            this.Alert.ShowIcon = true;
            this.Alert.ShowShadows = true;
            this.Alert.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.SuccessOptions.ActionBorderRadius = 1;
            this.Alert.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.Alert.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.Alert.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.Alert.SuccessOptions.IconLeftMargin = 12;
            this.Alert.ViewsMargin = 7;
            this.Alert.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Alert.WarningOptions.ActionBorderRadius = 1;
            this.Alert.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alert.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Alert.WarningOptions.BackColor = System.Drawing.Color.White;
            this.Alert.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.Alert.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.Alert.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Alert.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.Alert.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.Alert.WarningOptions.IconLeftMargin = 12;
            this.Alert.ZoomCloseIcon = true;
            // 
            // Frm_Generate_Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 358);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.AppBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Generate_Payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Generate_Payslip";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock;
        public Bunifu.Utils.BunifuAppBar AppBar;
        private Kimtoo.ValidationProvider.ValidationProvider validationProvider1;
        public Bunifu.UI.WinForms.BunifuSnackbar Alert;
        private System.Windows.Forms.Panel pnlContent;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblMonth;
        public Bunifu.UI.WinForms.BunifuDropdown cmbMonth;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Bunifu.UI.WinForms.BunifuDropdown cmbYear;
    }
}