using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FixedAssets.Classes.Managers
{
    public class UserManager
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(UserManager));
        public static UserManager defaultInstance;
        private static Datasource.dsDataTableAdapters.UsersTableAdapter adpUser;
        private static Datasource.dsDataTableAdapters.RoleDetialTableAdapter adpRuleDetail;
        private static Datasource.dsDataTableAdapters.QueriesTableAdapter adpQry;
        public static Datasource.dsData.UsersRow UserInfo { get; set; }
        public static Datasource.dsData.RoleDetialDataTable RoleDetial = new Datasource.dsData.RoleDetialDataTable();
        public static readonly int SuperAdminId = 1;
        public Types.UserInfo User = new Types.UserInfo();
        private Datasource.dsData.RoleDetialDataTable UserRuleDetialsTable = new Datasource.dsData.RoleDetialDataTable();

        public static bool LoadUserInfo(string username, string password)
        {
            Datasource.dsData.UsersDataTable tbl = adpUser.GetDataByNamePass(username, password);
            if (tbl.Count > 0)
            {
                //UserInfo = (Datasource.dsData.UsersRow)tbl.Rows[0];
                //adpRuleDetail.FillByUserID(RoleDetial, UserInfo.UserID);
                return true;
            }
            else
                return false;
        }
        #region -   Functions   -
        public static void Init()
        {
            adpUser = new Datasource.dsDataTableAdapters.UsersTableAdapter();
            adpRuleDetail = new Datasource.dsDataTableAdapters.RoleDetialTableAdapter();
            adpQry = new Datasource.dsDataTableAdapters.QueriesTableAdapter();

            DataManager.SetAllCommandTimeouts(adpUser, DataManager.ConnectionTimeout);

            defaultInstance = new UserManager();

        }
        public bool Login(string username, string password)
        {
            bool ReturnMe = false;
            try
            {
                Datasource.dsData.UsersDataTable UserTbl = adpUser.GetDataByNamePass(username, password);
                if (UserTbl.Rows.Count > 0)
                {
                    Datasource.dsData.UsersRow row = (Datasource.dsData.UsersRow)UserTbl.Rows[0];
                    User.UserId = row.UserID;
                    User.UserName = row.UserName;
                    if (row.UserID == 1)
                        User.IsAdmin = true;
                    else
                        User.IsAdmin = false;
                    if (GetUserRules(User.UserId))
                        ReturnMe = true;
                    Logger.InfoFormat("User Name {0} UserId {1} Logon Time {2}", User.UserName, User.UserId, DataManager.adpQry.GetServerDatetime());
                }
            }
            catch (SqlException ex)
            {
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }

            return ReturnMe;
        }
        private bool GetUserRules(int UserId)
        {
            adpRuleDetail.FillByUserID(UserRuleDetialsTable, UserId);
            return true;
        }
        public Datasource.dsData.RoleDetialRow RuleElementInformation(string ElementName)
        {
            Datasource.dsData.RoleDetialRow output = UserRuleDetialsTable.NewRoleDetialRow();
            if (User.IsAdmin)
            {
                output.Selecting = output.Inserting = output.Updateing = output.Deleting = true;
                return output;
            }
            output.Selecting = output.Inserting = output.Updateing = output.Deleting = false;

            foreach (Datasource.dsData.RoleDetialRow element in UserRuleDetialsTable)
            {
                if (element.MenuItemName == ElementName)
                {
                    if (element.Selecting)
                        output.Selecting = true;
                    if (element.Inserting)
                        output.Inserting = true;
                    if (element.Updateing)
                        output.Updateing = true;
                    if (element.Deleting)
                        output.Deleting = true;
                }
            }
            return output;
        }

        public bool CheckCurrentPassword(string CurrentPassword)
        {
            try
            {
                if (DataManager.adpQry.CheckCurrentPassword(User.UserId, CurrentPassword) == null)
                    return false;
                else
                    return true;
            }
            catch (SqlException ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, User.UserId);
            }
            return false;
        }
        public bool ChangeLogininfo(string Username, string Password)
        {
            try
            {
                if (DataManager.adpQry.ChangeLoginInfo(Username, Password, User.UserId) > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                Core.LogException(Logger, ex, Core.ExceptionLevelEnum.General, User.UserId);
            }
            return false;
        }
        #endregion
    }
}
