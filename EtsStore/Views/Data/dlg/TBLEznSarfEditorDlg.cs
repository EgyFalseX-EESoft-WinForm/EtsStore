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
    public partial class TBLEznSarfEditorDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLEznSarfEditorDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.TBLEznSarfTableAdapter adp = new Datasource.dsDataTableAdapters.TBLEznSarfTableAdapter();
        DateTime ServerDatetime = Classes.Managers.DataManager.GetServerDatetime;
        public int _m_EznSarfId;
        public TBLEznSarfEditorDlg(int Id, bool New)
        {
            InitializeComponent();

            LSMSCDStore.QueryableSource = from q in dsLinq.CDStores select q;
            LSMSCdDepertment.QueryableSource = from q in dsLinq.CdDepertments select q;
            LSMSTblEmp.QueryableSource = from q in dsLinq.TblEmps select q;

            if (New)
            {
                Datasource.dsData.TBLEznSarfRow row = dsData.TBLEznSarf.NewTBLEznSarfRow();
                row.EznSarfId = (int)adp.NewId(); _m_EznSarfId = row.EznSarfId;
                row.EznSarfafdate = ServerDatetime;
                row.StoreId = 0;
                row.Depertmentid = 0;
                row.empid = 0;
                row.dateIn = ServerDatetime;
                row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLEznSarf.AddTBLEznSarfRow(row);
            }
            else
                adp.FillByEznSarfId(dsData.TBLEznSarf, Id);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderMain.Validate())
            {
                dsData.TBLEznSarf[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLEznSarf[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                dsData.TBLEznSarf[0].EndEdit();
                adp.Update(dsData.TBLEznSarf[0]);
                Close();
            }
        }

    }
}