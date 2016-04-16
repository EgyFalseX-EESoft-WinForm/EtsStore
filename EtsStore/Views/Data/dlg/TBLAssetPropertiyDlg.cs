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
    public partial class TBLAssetPropertiyDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLAssetPropertiyDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        public TBLAssetPropertiyDlg(int AssetsID)
        {
            InitializeComponent();
            LSMSAssetPropertiyId.QueryableSource = from q in dsLinq.CdAssetPropertiys select q;

            Datasource.dsData.TBLAssetPropertiyRow row = dsData.TBLAssetPropertiy.NewTBLAssetPropertiyRow();
            row.AssetsID = AssetsID;
            row.AssetPropertiyId = 0;
            dsData.TBLAssetPropertiy.AddTBLAssetPropertiyRow(row);
        }
        public TBLAssetPropertiyDlg(int AssetsID, byte AssetPropertiyId)
        {
            InitializeComponent();
            LSMSAssetPropertiyId.QueryableSource = from q in dsLinq.CdAssetPropertiys select q;

            tblAssetPropertiyTableAdapter.FillByAssetId_AssetPropertiyId(dsData.TBLAssetPropertiy, AssetsID, AssetPropertiyId);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dxValidationProviderMain.Validate())
            {
                dsData.TBLAssetPropertiy[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLAssetPropertiy[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                dsData.TBLAssetPropertiy[0].EndEdit();
                tblAssetPropertiyTableAdapter.Update(dsData.TBLAssetPropertiy[0]);
                Close();
            }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
            
        }
    }
}