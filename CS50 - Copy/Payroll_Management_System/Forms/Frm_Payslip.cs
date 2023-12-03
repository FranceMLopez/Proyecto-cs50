//Code Generated by Jenga.NET
using Newtonsoft.Json.Linq;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//import;

namespace Payroll_Management_System.Forms
{

    public partial class Frm_Payslip : Form
    {
        private Payroll_Management_System.Models.Payslip _record;
        private Payroll_Management_System.Models.Payslip _oldRecord;
        public Dictionary<string, object> FixedValues = new Dictionary<string, object>();

        public Func<Payroll_Management_System.Models.Payslip, Payroll_Management_System.Models.Payslip, bool> BeforeSave { get; set; } = null;
        public Action<Payroll_Management_System.Models.Payslip> AfterSave { get; set; } = null;

        public Frm_Payslip(Payroll_Management_System.Models.Payslip record = null, bool readOnly = false)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            //apply theme using thme themeProvider
            if (System.IO.File.Exists("theme.json"))
                Kimtoo.ThemeProvider.ThemeFactory.ApplyTheme(this);
            if (record == null)
                _record = new Payroll_Management_System.Models.Payslip(); //create new recoded
            else
                _record = record; //assign existing record

            //bind data to dropdowns
            var db = Kt.Db;
            cmbEmployeeID.DataSource = db.Select<Payroll_Management_System.Models.Employee>();
            //reference

            //disable controls if read-only mode
            if (readOnly)
            {
                foreach (Control ctrl in pnlContent.Controls)
                {
                    if (ctrl.GetType() != typeof(Label))
                        ctrl.Enabled = false;
                    btnCancel.Enabled = true;
                }
            }
            Cursor.Current = Cursors.Default;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                //check validation
                if (validationProvider.Validate().Length > 0)
                {
                    Alert.Show(this, "Vaidation Error", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    return;  //Return when validation fails
                }
                if (BeforeSave != null)
                    if (!BeforeSave.Invoke(_oldRecord, _record))
                        return;
                Kt.Db.Save(_record); //save changes to database
                if (AfterSave != null)
                    AfterSave.Invoke(_record);
                Alert.Show(this, "Successfull", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
            }
            catch (Exception err)
            {
                Alert.Show(this, err.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }
        private void Frm_Load(object sender, EventArgs e)
        {
            //check fixed Values
            if (this.FixedValues.Count() > 0)
            {
                //disable mentioned controls
                foreach (Control ctrl in pnlContent.Controls)
                    if (bindingProvider.GetLink(ctrl) != null && FixedValues.ContainsKey(bindingProvider.GetLink(ctrl).Data))
                        ctrl.Enabled = false;

                //merge the pased values
                var tmp = JObject.FromObject(_record);
                foreach (var prop in this.FixedValues)
                    tmp[prop.Key] = JToken.Parse(prop.Value.ToString());

                _record = tmp.ToObject<Payroll_Management_System.Models.Payslip>();
            }

            //bind record to controls
            bindingProvider.Bind(_record);
            /**load**/
        }
        /**global**/
    }
}