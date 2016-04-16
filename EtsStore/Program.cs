using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace FixedAssets
{
    static class Program
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Program));

        public static string TilesLayoutFile = Application.StartupPath + @"\TilesLayoutFile";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserLookAndFeel.Default.SkinName = "DevExpress Dark Style";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Log.L4N.Init();

            if (FXFW.SqlDB.LoadSqlDBPath("FixedAssets") /*&& Authentication()*/)
            {
                Properties.Settings.Default["EtsStoreConnectionString"] = FXFW.SqlDB.SqlConStr;
                DevExpress.Xpo.XpoDefault.ConnectionString = FXFW.SqlDB.SqlConStr;
                DatabaseScripts.FireScript();
                ApplicationStart();
            }

            
        }
        public static void Init()
        {
            Classes.Managers.DataManager.Init();
            Classes.Managers.UserManager.Init();
            //Classes.Dashboard.Init();
            //Classes.QueryLayout.Init();
        }
        public static void ApplicationStart()
        {
            // Init
            Init();
            // Login
            if (new Views.Main.LoginFrm().ShowDialog() == DialogResult.Cancel)
                return;
            //FixedAssets.Classes.Managers.UserManager.defaultInstance.Login("admin", "admin");

            Application.Run(new Views.Main.MainForm());
            
        }

        private static bool Authentication()
        {
            
            string filePath = Application.StartupPath + "\\lnc.key";

            if (!System.IO.File.Exists(filePath))
            {
                using (FXFW.License.LicenseKeyFrm dlg = new FXFW.License.LicenseKeyFrm(Application.ProductName))
                {
                    dlg.ShowDialog();
                }
            }

            if (!System.IO.File.Exists(filePath))
                return false;
            else
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(filePath);
                string Key = sr.ReadToEnd();
                sr.Close();
                if (FXFW.License.LicenseKeyFrm.CompareBios(Key, Application.ProductName))
                    return true;
                else
                {
                    System.IO.File.Delete(filePath);
                    Application.Restart();
                    Application.Exit();
                    return false;
                }
            }
        }
    }
}
