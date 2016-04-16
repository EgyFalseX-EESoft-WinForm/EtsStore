using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FixedAssets.Classes.Managers
{
    public class DataManager
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Program));
        public static DataManager defaultInstance;
        public static Datasource.dsData ds = new Datasource.dsData();
        public static Datasource.dsDataTableAdapters.QueriesTableAdapter adpQry;
        //public static Datasource.dsQryTableAdapters.QueriesTableAdapter adpQQry;
        private readonly static string AppMenuName = "mb";
        public static int ConnectionTimeout = 0;

        public static void Init()
        {
            defaultInstance = new DataManager();
            adpQry = new Datasource.dsDataTableAdapters.QueriesTableAdapter(); SetAllCommandTimeouts(adpQry, ConnectionTimeout);
            //adpQQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter(); SetAllCommandTimeouts(adpQQry, ConnectionTimeout);
            
        }
        public static void SetConnectionString(string connectionString)
        {
            Properties.Settings.Default["StudentAffairsConnectionString"] = connectionString;
            DevExpress.Xpo.XpoDefault.ConnectionString = connectionString;
        }
        public static DateTime GetServerDatetime
        {
            get
            {
                return (DateTime)adpQry.GetServerDatetime();
            }
        }
        public static void GetFormPriv(string FormName, ref bool Selecting, ref bool Inserting, ref bool Updateing, ref bool Deleting)
        {
            Selecting = false; Inserting = false; Updateing = false; Deleting = false;

            if (FormName.Substring(FormName.Length - 3).ToLower() == "frm")
                FormName = FormName.Substring(0, FormName.Length - 3);
            if (FormName.Substring(FormName.Length - 2).ToLower() == "uc")
                FormName = FormName.Substring(0, FormName.Length - 2);
            FormName = AppMenuName + FormName;
            //foreach (Datasource.dsData.RoleDetialRow row in UserManager.RoleDetial.Rows)
            //{
            //    if (row.MenuItemName != FormName)
            //        continue;
            //    if (row.Selecting)
            //        Selecting = row.Selecting;
            //    if (row.Inserting)
            //        Inserting = row.Inserting;
            //    if (row.Updateing)
            //        Updateing = row.Updateing;
            //    if (row.Deleting)
            //        Deleting = row.Deleting;
            //}
        }
        public static bool PrepareBaseRole()
        {
            return true;
            //using (Views.Main.MainForm frm = new Views.Main.MainForm())
            //{
            //    using (Datasource.dsDataTableAdapters.RoleDetialTableAdapter adp = new Datasource.dsDataTableAdapters.RoleDetialTableAdapter())
            //    {
            //        try
            //        {
            //            foreach (DevExpress.XtraBars.BarItem item in frm.ribbonControlMain.Items)
            //            {
            //                if (item.Name != string.Empty)
            //                {
            //                    adp.InsertBaseRole(1, item.Name, true, true, true, true);
            //                }
            //            }
            //            return true;
            //        }
            //        catch (Exception ex)
            //        {
            //            System.Windows.Forms.MsgDlg.ShowAlert(ex.Message, System.Windows.Forms.MsgDlg.MessageType.Success, new System.Windows.Forms.Form());
            //            Logger.Info(ex.Message, ex);
            //            throw ex;
            //        }
            //    }
            //}
        }
        public static void SetAllCommandTimeouts(object adapter, int timeout)
        {
            var commands = adapter.GetType().InvokeMember("CommandCollection",
                    System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                    null, adapter, new object[0]);
            var sqlCommand = (System.Data.IDbCommand[])commands;
            foreach (var cmd in sqlCommand)
            {
                cmd.CommandTimeout = timeout;
            }
        }
        public static object GetNewId(string TableName, string PrimaryKey)
        {
            object Output = null;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.EtsStoreConnectionString);
            SqlCommand cmd = new SqlCommand(string.Format("SELECT ISNULL(MAX([{0}]) + 1, 1) FROM [{1}]", PrimaryKey, TableName), con);
            try
            {
                con.Open();
                Output = cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, UserManager.defaultInstance.User.UserId);
            }
            con.Close();
            return Output;
        }

    }
}
