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
    public partial class TBLEznEdafaEditorDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLEznEdafaEditorDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.TBLEznEdafaTableAdapter adp = new Datasource.dsDataTableAdapters.TBLEznEdafaTableAdapter();
        DateTime ServerDatetime = Classes.Managers.DataManager.GetServerDatetime;
        public int _m_EznEdafaId;
        public TBLEznEdafaEditorDlg(int Id, bool New)
        {
            InitializeComponent();

            LSMSCDStore.QueryableSource = from q in dsLinq.CDStores select q;
            LSMSTBLSupplier.QueryableSource = from q in dsLinq.TBLSuppliers select q;
            LSMSTBLCheck.QueryableSource = from q in dsLinq.TBLChecks select q;

            if (New)
            {
                Datasource.dsData.TBLEznEdafaRow row = dsData.TBLEznEdafa.NewTBLEznEdafaRow();
                row.EznEdafaId = (int)adp.NewId(); _m_EznEdafaId = row.EznEdafaId;
                row.EznEdafadate = ServerDatetime;
                row.StoreId = 0;
                row.jointocheck = false;
                row.ChecklagnaID = 0;
                row.SupplierId = 0;
                row.dateIn = ServerDatetime;
                row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLEznEdafa.AddTBLEznEdafaRow(row);
            }
            else
                adp.FillByEznEdafaId(dsData.TBLEznEdafa, Id);

            lueChecklagnaID.Enabled = cejointocheck.Checked;
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderMain.Validate())
            {
                dsData.TBLEznEdafa[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLEznEdafa[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                dsData.TBLEznEdafa[0].EndEdit();
                adp.Update(dsData.TBLEznEdafa[0]);
                Close();
            }
        }
        private void cejointocheck_CheckedChanged(object sender, EventArgs e)
        {
            lueChecklagnaID.Enabled = cejointocheck.Checked;
            if (!cejointocheck.Checked)
                lueChecklagnaID.EditValue = 0;
        }

    }
}