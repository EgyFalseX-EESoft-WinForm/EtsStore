using System.Data.SqlClient;

namespace FixedAssets
{
    public static class DatabaseScripts
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(DatabaseScripts));
        public static void FireScript()
        {
            var con = new SqlConnection(Properties.Settings.Default.EtsStoreConnectionString);
            var cmd = new SqlCommand(string.Empty, con);
            try
            {
                con.Open();

                if (CheckViewExists("vQry002"))
                {
                    cmd.CommandText = DropObject("vQry002");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry002;
                cmd.ExecuteNonQuery();
				
				if (CheckViewExists("vQry003"))
                {
                    cmd.CommandText = DropObject("vQry003");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry003;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex.Message, ex);
            }
            con.Close();
        }
        public static bool CheckViewExists(string viewName)
        {
            var exist = false;
            var con = new SqlConnection(Properties.Settings.Default.EtsStoreConnectionString);
            var cmd = new SqlCommand(string.Empty, con) { CommandText = string.Format(@"IF EXISTS(select * FROM sys.views where name = '{0}')
                                                        SELECT 1
                                                        ELSE
                                                        SELECT 0", viewName) };
            try
            {
                con.Open();
                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    exist = true;
                }
                else
                {
                    exist = false;
                }
            }
            catch (SqlException ex)
            {
                Logger.Error(ex.Message, ex);
            }
            con.Close();
            return exist;
        }
        private static string DropObject(string objName)
        {
            return string.Format(@"DROP VIEW [dbo].[{0}]", objName);
        }
        public static string vQry002
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry002]
                AS
                SELECT        dbo.TBLEznEdafa.EznEdafaId + dbo.TBLEznEdafaDetails.SanfID AS autoid, dbo.TBLEznEdafa.EznEdafaId, dbo.TBLEznEdafa.EznEdafadate, dbo.CDStore.Storename, dbo.TBLEznEdafaDetails.SanfID, dbo.TblAsnaf.SanfName, dbo.TBLEznEdafaDetails.uniteprice, 
                         dbo.TBLEznEdafaDetails.orderquntity, dbo.CdAssetState.AssetState
                FROM            dbo.TBLEznEdafa INNER JOIN
                         dbo.TBLEznEdafaDetails ON dbo.TBLEznEdafa.EznEdafaId = dbo.TBLEznEdafaDetails.EznEdafaId INNER JOIN
                         dbo.TblAsnaf ON dbo.TBLEznEdafaDetails.SanfID = dbo.TblAsnaf.SanfID INNER JOIN
                         dbo.CDStore ON dbo.TBLEznEdafa.StoreId = dbo.CDStore.StoreId INNER JOIN
                         dbo.CdAssetState ON dbo.TBLEznEdafaDetails.SanfStateId = dbo.CdAssetState.AssetStateId";
            }
        }
		public static string vQry003
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry003]
                AS
                SELECT        TBLEznSarf.EznSarfId + TBLEznSarfDetails.SanfID AS autoid, TBLEznSarf.EznSarfId, TBLEznSarf.EznSarfafdate, CDStore.Storename, CdDepertment.Depertment, TblEmp.EmpName, TBLEznSarfDetails.SanfID, 
				TblAsnaf.SanfName, TBLEznSarfDetails.sarfquntity, TBLEznSarfDetails.ezndes, CdAssetState.AssetState
				FROM            TBLEznSarf INNER JOIN
				TBLEznSarfDetails ON TBLEznSarf.EznSarfId = TBLEznSarfDetails.EznSarfId INNER JOIN
				TblAsnaf ON TBLEznSarfDetails.SanfID = TblAsnaf.SanfID INNER JOIN
				CDStore ON TBLEznSarf.StoreId = CDStore.StoreId INNER JOIN
				CdDepertment ON TBLEznSarf.Depertmentid = CdDepertment.DepertmentId INNER JOIN
				TblEmp ON TBLEznSarf.empid = TblEmp.EmpId INNER JOIN
				CdAssetState ON TBLEznSarfDetails.SanfStateId = CdAssetState.AssetStateId";
            }
        }
    }
}
