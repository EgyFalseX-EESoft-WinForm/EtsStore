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
    public partial class TBLTwreedOrderDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLTwreedOrderDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        DateTime ServerDatetime = Classes.Managers.DataManager.GetServerDatetime;
        public int _m_TwreedOrderId;

        public TBLTwreedOrderDlg(int ID, bool New)
        {
            InitializeComponent();

            LSMSSupplierId.QueryableSource = from q in dsLinq.TBLSuppliers select q;
            try
            {
                if (New)
                {
                    //Load exist Quantity
                    tblTwreedOrderTableAdapter.FillByTwreedOrderId(dsData.TBLTwreedOrder, -99);

                    Datasource.dsData.TBLTwreedOrderRow row = dsData.TBLTwreedOrder.NewTBLTwreedOrderRow();
                    row.TwreedOrderId = _m_TwreedOrderId = (int)tblTwreedOrderTableAdapter.NewId();
                    row.TwreedOrderdate = ServerDatetime;
                    row.SupplierId = -1;
                    row.twreedplace = string.Empty;
                    row.twreddate = ServerDatetime;
                    row.Supplierofferno = 0;
                    row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    row.dateIn = ServerDatetime;
                    dsData.TBLTwreedOrder.AddTBLTwreedOrderRow(row);
                }
                else
                {
                    tblTwreedOrderTableAdapter.FillByTwreedOrderId(dsData.TBLTwreedOrder, ID);
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
            try
            {
                if (dxValidationProviderMain.Validate())
                {
                    dsData.TBLTwreedOrder[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    dsData.TBLTwreedOrder[0].dateIn = ServerDatetime;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    dsData.TBLTwreedOrder[0].EndEdit();
                    tblTwreedOrderTableAdapter.Update(dsData.TBLTwreedOrder[0]);
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