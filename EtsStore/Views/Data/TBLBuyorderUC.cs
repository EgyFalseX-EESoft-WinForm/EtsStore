using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using DevExpress.Xpo.Metadata;

namespace FixedAssets.Views.Data
{
    public partial class TBLBuyorderUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLBuyorderUC));
        Datasource.dsData.RoleDetialRow _elementRule = null;
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        #endregion
        #region - Fun -
        public TBLBuyorderUC(Datasource.dsData.RoleDetialRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(FixedAssets.Views.Main.WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                Invoke(new MethodInvoker(() =>
                {
                    LSMSTblAsnaf.QueryableSource = from q in dsLinq.TblAsnafs select q;
                    LSMSCdDepertment.QueryableSource = from q in dsLinq.CdDepertments select q;
                    LSMSUsers.QueryableSource = from q in dsLinq.Users select q;
                    LSMSBuyorderresonId.QueryableSource = from q in dsLinq.CDBuyorderresons select q;
                    XPSCSTBLBuyorder.Session.ConnectionString = Properties.Settings.Default.EtsStoreConnectionString;
                    gridControlTBLBuyorder.DataSource = XPSCSTBLBuyorder;
                    gridViewTBLBuyorder.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        public void ActivateRules()
        {
            XPSCSTBLBuyorder.AllowNew = _elementRule.Inserting;
            XPSCSTBLBuyorder.AllowRemove = _elementRule.Deleting;
            XPSCSTBLBuyorder.AllowEdit = _elementRule.Updateing;
            //XPSCSTBLTBBuyorderdetails.AllowNew = _elementRule.Inserting;
            //XPSCSTBLTBBuyorderdetails.AllowRemove = _elementRule.Deleting;
            //XPSCSTBLTBBuyorderdetails.AllowEdit = _elementRule.Updateing;

            btnAddTBLBuyorder.Visible = _elementRule.Inserting;
            btnSaveTBLTBBuyorderdetails.Visible = _elementRule.Inserting;

            btnEditTBLBuyorder.Visible = _elementRule.Updateing;

            btnDeleteTBLBuyorder.Visible = _elementRule.Deleting;
            btnDeleteTBLTBBuyorderdetails.Visible = _elementRule.Deleting;
            
        }
        #endregion
        #region -  EventWhnd - 
        private void RouteEditorUC_Load(object sender, EventArgs e)
        {
            LoadData();
            ActivateRules();
        }
        private void gridViewTBLBuyorder_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewTBLBuyorder.GetRow(e.RowHandle));
                if (row != null && row.GetMemberValue("BuyorderId") != null)
                {
                    //Load TBBuyorderdetails Grid
                    gridViewTBLTBBuyorderdetails.ShowLoadingPanel();
                    tBLTBBuyorderdetailsTableAdapter.FillByBuyorderId(dsData.TBLTBBuyorderdetails, Convert.ToInt32(row.GetMemberValue("BuyorderId")));
                    gridViewTBLTBBuyorderdetails.RefreshData();
                    gridViewTBLTBBuyorderdetails.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnAddTBLBuyorder_Click(object sender, EventArgs e)
        {
            try
            {
                TBLTBBuyorderdetailsEditorDlg frm = new TBLTBBuyorderdetailsEditorDlg(-1, true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    XPSCSTBLBuyorder.FixedFilterString = "BuyorderId = " + frm._m_BuyorderId;
                    XPSCSTBLBuyorder.Session.DropIdentityMap();
                    XPSCSTBLBuyorder.Reload();
                    gridViewTBLBuyorder.RefreshData();
                    gridViewTBLBuyorder.FocusedRowHandle = 1;
                    tBLTBBuyorderdetailsTableAdapter.FillByBuyorderId(dsData.TBLTBBuyorderdetails, frm._m_BuyorderId);
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditTBLBuyorder_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewTBLBuyorder.GetRow(gridViewTBLBuyorder.FocusedRowHandle);
                if (row == null)
                    return;
                TBLTBBuyorderdetailsEditorDlg frm = new TBLTBBuyorderdetailsEditorDlg(Convert.ToInt32(row.GetMemberValue("BuyorderId")), false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    XPSCSTBLBuyorder.Session.DropIdentityMap();
                    XPSCSTBLBuyorder.Reload();
                    gridViewTBLBuyorder.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteTBLBuyorder_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewTBLBuyorder.GetRow(gridViewTBLBuyorder.FocusedRowHandle);
                if (row == null)
                    return;
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewTBLBuyorder.DeleteSelectedRows();
                    XPSCSTBLBuyorder.Session.DropIdentityMap();
                    XPSCSTBLBuyorder.Reload();
                    gridViewTBLBuyorder.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void gridViewTBLTBBuyorderdetails_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            XPDataTableObject ParentRow = (XPDataTableObject)gridViewTBLBuyorder.GetRow(gridViewTBLBuyorder.FocusedRowHandle);
            if (ParentRow == null)
                return;
            Datasource.dsData.TBLTBBuyorderdetailsRow Row = (Datasource.dsData.TBLTBBuyorderdetailsRow)((DataRowView)gridViewTBLTBBuyorderdetails.GetRow(gridViewTBLTBBuyorderdetails.FocusedRowHandle)).Row;
            if (Row == null)
                return;
            int BuyorderId = Convert.ToInt32(ParentRow.GetMemberValue("BuyorderId"));
            Row.BuyorderId = BuyorderId;
            Row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
            Row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
        }
        private void btnSaveTBLTBBuyorderdetails_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            for (int i = 0; i < dsData.TBLTBBuyorderdetails.Count; i++)
            {
                if (dsData.TBLTBBuyorderdetails[i].RowState == DataRowState.Modified)
                {
                    dsData.TBLTBBuyorderdetails[i].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    dsData.TBLTBBuyorderdetails[i].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                }
            }
            tBLTBBuyorderdetailsBindingSource.EndEdit();
            tBLTBBuyorderdetailsTableAdapter.Update(dsData.TBLTBBuyorderdetails);
        }
        private void btnDeleteTBLTBBuyorderdetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewTBLTBBuyorderdetails.DeleteSelectedRows();
                    tBLTBBuyorderdetailsBindingSource.EndEdit();
                    tBLTBBuyorderdetailsTableAdapter.Update(dsData.TBLTBBuyorderdetails);
                    gridViewTBLTBBuyorderdetails.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }

        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            XPSCSTBLBuyorder.FixedFilterString = string.Empty;
        }
        private void repositoryItemButtonEditPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            XPDataTableObject row = ((XPDataTableObject)gridViewTBLBuyorder.GetRow(gridViewTBLBuyorder.FocusedRowHandle));
            if (row.GetMemberValue("BuyorderId") == null)
            {
                MsgDlg.Show("من فضلك احفظ قبل الطباعة", MsgDlg.MessageType.Error);
                return;
            }

            FixedAssets.XRep.xRep001 rep = new FixedAssets.XRep.xRep001(Convert.ToInt32(row.GetMemberValue("BuyorderId")));
            Classes.Misc.ShowPrintPreview(rep);
        }
        private void btnRefreashTBLTBBuyorderdetails_Click(object sender, EventArgs e)
        {
            LSMSTblAsnaf.Reload();
            LSMSCdDepertment.Reload();
            LSMSUsers.Reload();
            LSMSBuyorderresonId.Reload();
        }
        #endregion

        

        

    }
}
