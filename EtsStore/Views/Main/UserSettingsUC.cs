using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace FixedAssets.Views.Main
{
    public partial class UserSettingsUC : DevExpress.XtraEditors.XtraUserControl
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(UserSettingsUC));
        public UserSettingsUC()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(galleryControlMain, true);
            tbUsername.EditValue = Classes.Managers.UserManager.defaultInstance.User.UserName;
        }
        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = Program.TilesLayoutFile + Classes.Managers.UserManager.defaultInstance.User.UserId;
                MainForm MainForm = (MainForm)ParentForm;
                FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate);
                MainForm.windowsUIView.SaveLayoutToStream(fs);
                fs.Close();
                MsgDlg.Show(Properties.Settings.Default.msg_SaveSuccess, MsgDlg.MessageType.Success);
            }
            catch (Exception ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        private void btnResertLayout_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            try
            {
                string FileName = Program.TilesLayoutFile + Classes.Managers.UserManager.defaultInstance.User.UserId;
                if (File.Exists(FileName))
                    File.Delete(FileName);
                MainForm MainForm = (MainForm)ParentForm;
                MainForm.windowsUIView.OptionsLayout.Reset();
                if (MsgDlg.Show("لكي يتم تفعيل الخيارات جيب اعادة تشغيل البرنامج", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                    
                }
            }
            catch (Exception ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
        }
        private void btnLoginInfo_Click(object sender, EventArgs e)
        {
            if (!dxvpLoginInfoChange.Validate())
                return;
            if (!Classes.Managers.UserManager.defaultInstance.CheckCurrentPassword(tbCurentpassword.EditValue.ToString()))
            {
                MsgDlg.Show("خطاء في كلمة المرور الحالية", MsgDlg.MessageType.Error);
                return;
            }
            if (tbNewpassword1.EditValue.ToString() != tbNewpassword2.EditValue.ToString())
            {
                MsgDlg.Show("خطاء في كلمة المرور الجديدة", MsgDlg.MessageType.Error);
                return;
            }
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            if (Classes.Managers.UserManager.defaultInstance.ChangeLogininfo(tbUsername.EditValue.ToString(), tbNewpassword1.EditValue.ToString()))
                MsgDlg.Show("تم تغير بيانات المستخدم بنجاح", MsgDlg.MessageType.Success);
            else
                MsgDlg.Show(Properties.Settings.Default.msg_SavingFailed, MsgDlg.MessageType.Error);
        }

    }
}
