using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using FixedAssets.Classes.Managers;
using DevExpress.XtraSplashScreen;


namespace FixedAssets.Views.Main
{

    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Variables -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(LoginFrm));
        private readonly string LoginInfoFileName = Application.StartupPath + "\\loginInfo";
        #endregion
        #region - Functions -
        public LoginFrm()
        {
            InitializeComponent();

            if (File.Exists(LoginInfoFileName))
            {
                FileStream fs = File.Open(LoginInfoFileName, FileMode.Open, FileAccess.Read);
                byte[] buff = new byte[fs.Length];
                fs.Read(buff, 0, Convert.ToInt32(fs.Length));
                fs.Close(); fs.Dispose();
                string username = Encoding.Default.GetString(buff, 0, buff.Length);
                tbUsername.EditValue = username;
                tbPassword.Focus();
            }
        }
        private void SaveLoginInfoToFile()
        {
            FileStream fs = File.Open(LoginInfoFileName, FileMode.Create, FileAccess.Write);
            byte[] buff = Encoding.Default.GetBytes(tbUsername.EditValue.ToString());

            fs.Write(buff, 0, buff.Length);

            fs.Flush(); fs.Close(); fs.Dispose();

        }
        #endregion
        #region - EventWhnd -
        private void LoginFrm_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد", "خطاء", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                return;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (UserManager.defaultInstance.SignIn(tbname.Text, tbpass.Text))
            //    DialogResult = System.Windows.Forms.DialogResult.OK;
            //else
            //    DataCenterX.LogMessage("اسم المستخدم او كلمة المرور خاطئة", typeof(ItemPermissionEditorDLG), nsLib.Utilities.Types.MessageType.Error, null, true);

            if (FXFW.SqlDB.IsNullOrEmpty(tbUsername.EditValue) || FXFW.SqlDB.IsNullOrEmpty(tbPassword.EditValue))
                return;

            if (UserManager.defaultInstance.Login(tbUsername.EditValue.ToString(), tbPassword.EditValue.ToString()))
            {
                SaveLoginInfoToFile();// Save UserName Into File For Auto Load
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MsgDlg.Show("Wrong username/password. Please try again", MsgDlg.MessageType.Error);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        #endregion
        
        
    }
}