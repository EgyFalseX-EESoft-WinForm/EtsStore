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
    public partial class TBLAddAssetComponentDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLAddAssetComponentDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.TBLAddAssetComponentTableAdapter adp = new Datasource.dsDataTableAdapters.TBLAddAssetComponentTableAdapter();
        public TBLAddAssetComponentDlg(int ID, bool New)
        {
            InitializeComponent();

            LSMSCDComponents.QueryableSource = from q in dsLinq.CDComponents select q;
            try
            {
                if (New)
                {
                    Datasource.dsData.TBLAddAssetComponentRow row = dsData.TBLAddAssetComponent.NewTBLAddAssetComponentRow();
                    row.AddComponentezn = (int)adp.NewId();
                    row.AssetsID = ID;
                    row.ComponentId = 0;
                    row.AddQuantity = 0;
                    row.PriceOne = 0;
                    row.Adddate = Classes.Managers.DataManager.GetServerDatetime;
                    row.AddReson = string.Empty;
                    row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
                    dsData.TBLAddAssetComponent.AddTBLAddAssetComponentRow(row);
                }
                else
                    adp.FillByAddComponentezn(dsData.TBLAddAssetComponent, ID);
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
                    dsData.TBLAddAssetComponent[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    dsData.TBLAddAssetComponent[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    dsData.TBLAddAssetComponent[0].EndEdit();
                    adp.Update(dsData.TBLAddAssetComponent[0]);
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