using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FixedAssets.Views.Data.dlg
{
    public partial class TBLCheckEditorDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLCheckEditorDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.TBLCheckTableAdapter adp = new Datasource.dsDataTableAdapters.TBLCheckTableAdapter();
        DateTime ServerDatetime = Classes.Managers.DataManager.GetServerDatetime;
        public int _m_ChecklagnaID;
        public TBLCheckEditorDlg(int Id, bool New)
        {
            InitializeComponent();

            LSMSTBLBuyorder.QueryableSource = from q in dsLinq.TBLBuyorders select q;
            LSMSTBLTwreedOrder.QueryableSource = from q in dsLinq.TBLTwreedOrders select q;

            if (New)
            {
                Datasource.dsData.TBLCheckRow row = dsData.TBLCheck.NewTBLCheckRow();
                row.BuyorderId = -1;
                row.Checklagnadate = ServerDatetime;
                row.Decisionno = 0;
                row.TwreedOrderId = -1;
                row.dateIn = ServerDatetime;
                row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLCheck.AddTBLCheckRow(row);
            }
            else
                adp.FillByChecklagnaID(dsData.TBLCheck, Id);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderMain.Validate())
            {
                dsData.TBLCheck[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLCheck[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                dsData.TBLCheck[0].EndEdit();
                adp.Update(dsData.TBLCheck[0]);
                _m_ChecklagnaID = dsData.TBLCheck[0].ChecklagnaID;
                Close();
            }
            
        }
    }
}