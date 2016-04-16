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
    public partial class AssetEditorDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(AssetEditorDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        public AssetEditorDlg(int AssetIdOrCatId, bool New)
        {
            InitializeComponent();

            LSMSAssetplaceId.QueryableSource = from q in dsLinq.CdAssetplaces select q;
            LSMSAssetStateId.QueryableSource = from q in dsLinq.CdAssetStates select q;
            LSMSEmp.QueryableSource = from q in dsLinq.TblEmps select q;

            if (New)
            {
                Datasource.dsData.TblAssetsRow row = dsData.TblAssets.NewTblAssetsRow();
                object NewId = tblAssetsTableAdapter.NewId(AssetIdOrCatId);
                if (NewId.ToString() == string.Empty || NewId.ToString() == "0")
                    row.AssetsID = Convert.ToInt32(AssetIdOrCatId.ToString() + "0001");
                else
                    row.AssetsID = Convert.ToInt32(NewId);
                row.AssetsCategoryID = AssetIdOrCatId;
                dsData.TblAssets.AddTblAssetsRow(row);
            }
            else
                tblAssetsTableAdapter.FillByAssetsID(dsData.TblAssets, AssetIdOrCatId);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderMain.Validate())
            {
                dsData.TblAssets[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TblAssets[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                dsData.TblAssets[0].EndEdit();
                tblAssetsTableAdapter.Update(dsData.TblAssets[0]);
                Close();
            }
            
        }
    }
}