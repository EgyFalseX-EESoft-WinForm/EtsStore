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
    public partial class TBLDeleteAssetComponentDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLDeleteAssetComponentDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.TBLDeleteAssetComponentTableAdapter adp = new Datasource.dsDataTableAdapters.TBLDeleteAssetComponentTableAdapter();
        public TBLDeleteAssetComponentDlg(int ID, bool New)
        {
            InitializeComponent();

            LSMSCDComponents.QueryableSource = from q in dsLinq.CDComponents select q;
            try
            {
                if (New)
                {
                    //Load exist Quantity
                    assetComponentQuantityTableAdapter.Fill(dsQry.AssetComponentQuantity, ID, -99);

                    Datasource.dsData.TBLDeleteAssetComponentRow row = dsData.TBLDeleteAssetComponent.NewTBLDeleteAssetComponentRow();
                    row.DeleteComponentezn = (int)adp.NewId();
                    row.AssetsID = ID;
                    row.ComponentId = 0;
                    row.DelQuantity = 0;
                    row.PriceOne = 0;
                    row.Deldate = Classes.Managers.DataManager.GetServerDatetime;
                    row.DelReson = string.Empty;
                    row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
                    dsData.TBLDeleteAssetComponent.AddTBLDeleteAssetComponentRow(row);
                }
                else
                {
                    adp.FillByDeleteComponentezn(dsData.TBLDeleteAssetComponent, ID);
                    //Load exist Quantity
                    assetComponentQuantityTableAdapter.Fill(dsQry.AssetComponentQuantity, dsData.TBLDeleteAssetComponent[0].AssetsID, ID);
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
                Logger.Error(ex.Message, ex);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderMain.Validate())
            {
                try
                {
                    Datasource.dsQry.AssetComponentQuantityRow qun = dsQry.AssetComponentQuantity.FindByComponentId(dsData.TBLDeleteAssetComponent[0].ComponentId);
                    if (qun != null)
                    {
                        if (qun.Quantity - dsData.TBLDeleteAssetComponent[0].DelQuantity < 0)
                        {
                            MsgDlg.Show("الكمية المدخله اكبر من الكمية المتاحه", MsgDlg.MessageType.Error);
                            return;
                        }
                    }
                    else
                    {
                        MsgDlg.Show("المكون غير مدرج", MsgDlg.MessageType.Error);
                        return;
                    }

                    dsData.TBLDeleteAssetComponent[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    dsData.TBLDeleteAssetComponent[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    dsData.TBLDeleteAssetComponent[0].EndEdit();
                    adp.Update(dsData.TBLDeleteAssetComponent[0]);
                    Close();
                }
                catch (Exception ex)
                {
                    MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
                    Logger.Error(ex.Message, ex);
                }
            }
            
        }
    }
}