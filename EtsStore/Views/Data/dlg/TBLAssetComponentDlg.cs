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
    public partial class TBLAssetComponentDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLAssetComponentDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.TBLAssetComponentTableAdapter adp = new Datasource.dsDataTableAdapters.TBLAssetComponentTableAdapter();
        public TBLAssetComponentDlg(int ID, bool New)
        {
            InitializeComponent();

            LSMSCDComponents.QueryableSource = from q in dsLinq.CDComponents select q;

            if (New)
            {
                Datasource.dsData.TBLAssetComponentRow row = dsData.TBLAssetComponent.NewTBLAssetComponentRow();
                row.AssetsID = ID;
                row.ComponentId = 0;
                row.Quantity = 0;
                row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
                dsData.TBLAssetComponent.AddTBLAssetComponentRow(row);
            }
            else
                adp.FillByTBLAssetComponentId(dsData.TBLAssetComponent, ID);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderMain.Validate())
            {
                dsData.TBLAssetComponent[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLAssetComponent[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                dsData.TBLAssetComponent[0].EndEdit();
                adp.Update(dsData.TBLAssetComponent[0]);
                Close();
            }
            
        }
    }
}