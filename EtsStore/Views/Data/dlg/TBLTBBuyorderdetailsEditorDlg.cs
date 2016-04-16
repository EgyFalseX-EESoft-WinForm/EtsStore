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
    public partial class TBLTBBuyorderdetailsEditorDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLTBBuyorderdetailsEditorDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.TBLBuyorderTableAdapter adp = new Datasource.dsDataTableAdapters.TBLBuyorderTableAdapter();
        DateTime ServerDatetime = Classes.Managers.DataManager.GetServerDatetime;
        public int _m_BuyorderId;
        public TBLTBBuyorderdetailsEditorDlg(int Id, bool New)
        {
            InitializeComponent();

            LSMSDepartment.QueryableSource = from q in dsLinq.CdDepertments select q;
            LSMSBuyorderresonId.QueryableSource = from q in dsLinq.CDBuyorderresons select q;

            if (New)
            {
                Datasource.dsData.TBLBuyorderRow row = dsData.TBLBuyorder.NewTBLBuyorderRow();
                row.BuyorderId = (int)adp.NewId(); _m_BuyorderId = row.BuyorderId;
                row.Buyorderdate = ServerDatetime;
                row.DepertmentId = 0;
                row.BuyorderresonId = 0;
                row.moznadate = ServerDatetime;
                row.closeorder = false;
                row.dateIn = ServerDatetime;
                row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLBuyorder.AddTBLBuyorderRow(row);
            }
            else
                adp.FillByBuyorderId(dsData.TBLBuyorder, Id);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderMain.Validate())
            {
                dsData.TBLBuyorder[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLBuyorder[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                dsData.TBLBuyorder[0].EndEdit();
                adp.Update(dsData.TBLBuyorder[0]);
                Close();
            }
            
        }
    }
}