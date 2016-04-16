using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FixedAssets.Views.Data
{
    public partial class TBLAssetPlaceDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLAssetPlaceDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.TBLAssetPlaceTableAdapter adp = new Datasource.dsDataTableAdapters.TBLAssetPlaceTableAdapter();
        public TBLAssetPlaceDlg(int ID, bool New)
        {
            InitializeComponent();

            LSMSAssetplaceId.QueryableSource = from q in dsLinq.CdAssetplaces select q;
            LSMSEmp.QueryableSource = from q in dsLinq.TblEmps select q;

            if (New)
            {
                Datasource.dsData.TBLAssetPlaceRow row = dsData.TBLAssetPlace.NewTBLAssetPlaceRow();
                row.AssetsID = ID;
                row.datep = DateTime.Now;
                row.AssetplaceId = 0;
                row.EmpOhda = 0;
                row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
                dsData.TBLAssetPlace.AddTBLAssetPlaceRow(row);
            }
            else
                adp.FillByAssetRePlaceId(dsData.TBLAssetPlace, ID);
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderMain.Validate())
            {
                dsData.TBLAssetPlace[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLAssetPlace[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                dsData.TBLAssetPlace[0].EndEdit();
                adp.Update(dsData.TBLAssetPlace[0]);
                Close();
            }
            
        }
    }
}