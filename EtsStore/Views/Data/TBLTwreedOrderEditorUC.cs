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
    public partial class TBLTwreedOrderEditorUC : XtraUserControl
    {

        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLTwreedOrderEditorUC));
        Datasource.dsData.RoleDetialRow _elementRule = null;
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        #endregion
        #region - Fun -
        public TBLTwreedOrderEditorUC(Datasource.dsData.RoleDetialRow RuleElement)
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
                    LSMSSupplierId.QueryableSource = from q in dsLinq.TBLSuppliers select q;
                    LSMSUsers.QueryableSource = from q in dsLinq.Users select q;
                    LSMTblAsnaf.QueryableSource = from q in dsLinq.TblAsnafs select q;
                    XPSCSTBLTwreedOrder.Session.ConnectionString = Properties.Settings.Default.EtsStoreConnectionString;
                    gridControlParent.DataSource = XPSCSTBLTwreedOrder;
                    gridViewParent.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        public void ActivateRules()
        {
            XPSCSTBLTwreedOrder.AllowNew = _elementRule.Inserting;
            XPSCSTBLTwreedOrder.AllowRemove = _elementRule.Deleting;
            XPSCSTBLTwreedOrder.AllowEdit = _elementRule.Updateing;
            

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
                DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewParent.GetRow(e.RowHandle));
                if (row != null && row.GetMemberValue("TwreedOrderId") != null)
                {
                    //Load TBLTwreedOrderdetails Grid
                    gridViewDetails.ShowLoadingPanel();
                    tBLTwreedOrderdetailsTableAdapter.FillByTwreedOrderId(dsData.TBLTwreedOrderdetails, Convert.ToInt32(row.GetMemberValue("TwreedOrderId")));
                    gridViewDetails.RefreshData();
                    gridViewDetails.HideLoadingPanel();
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
                TBLTwreedOrderDlg frm = new TBLTwreedOrderDlg(-1, true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    XPSCSTBLTwreedOrder.FixedFilterString = "TwreedOrderId = " + frm._m_TwreedOrderId;
                    XPSCSTBLTwreedOrder.Session.DropIdentityMap();
                    XPSCSTBLTwreedOrder.Reload();
                    gridViewParent.RefreshData();
                    gridViewParent.FocusedRowHandle = 1;
                    tBLTwreedOrderdetailsTableAdapter.FillByTwreedOrderId(dsData.TBLTwreedOrderdetails, frm._m_TwreedOrderId);
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
                XPDataTableObject row = (XPDataTableObject)gridViewParent.GetRow(gridViewParent.FocusedRowHandle);
                if (row == null)
                    return;
                TBLTwreedOrderDlg frm = new TBLTwreedOrderDlg(Convert.ToInt32(row.GetMemberValue("TwreedOrderId")), false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    XPSCSTBLTwreedOrder.Session.DropIdentityMap();
                    XPSCSTBLTwreedOrder.Reload();
                    gridViewParent.RefreshData();
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
                XPDataTableObject row = (XPDataTableObject)gridViewParent.GetRow(gridViewParent.FocusedRowHandle);
                if (row == null)
                    return;
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewParent.DeleteSelectedRows();
                    XPSCSTBLTwreedOrder.Session.DropIdentityMap();
                    XPSCSTBLTwreedOrder.Reload();
                    gridViewParent.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void gridViewTBLTBBuyorderdetails_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            XPDataTableObject ParentRow = (XPDataTableObject)gridViewParent.GetRow(gridViewParent.FocusedRowHandle);
            if (ParentRow == null)
                return;
            Datasource.dsData.TBLTwreedOrderdetailsRow Row = (Datasource.dsData.TBLTwreedOrderdetailsRow)((DataRowView)gridViewDetails.GetRow(gridViewDetails.FocusedRowHandle)).Row;
            if (Row == null)
                return;
            Row.TwreedOrderId = Convert.ToInt32(ParentRow.GetMemberValue("TwreedOrderId"));
            Row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
            Row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
        }
        private void btnSaveTBLTBBuyorderdetails_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            for (int i = 0; i < dsData.TBLTwreedOrderdetails.Count; i++)
            {
                if (dsData.TBLTwreedOrderdetails[i].RowState == DataRowState.Modified)
                {
                    dsData.TBLTwreedOrderdetails[i].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    dsData.TBLTwreedOrderdetails[i].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                }
            }
            tBLTwreedOrderdetailsBindingSource.EndEdit();
            tBLTwreedOrderdetailsTableAdapter.Update(dsData.TBLTwreedOrderdetails);
        }
        private void btnDeleteTBLTBBuyorderdetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewDetails.DeleteSelectedRows();
                    tBLTwreedOrderdetailsBindingSource.EndEdit();
                    tBLTwreedOrderdetailsTableAdapter.Update(dsData.TBLTwreedOrderdetails);
                    gridViewDetails.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }

        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            XPSCSTBLTwreedOrder.FixedFilterString = string.Empty;
        }
        private void btnRefreashTBLTBBuyorderdetails_Click(object sender, EventArgs e)
        {
            LSMSSupplierId.Reload();
            LSMTblAsnaf.Reload();
            LSMSUsers.Reload();
        }
        private void repositoryItemButtonEditPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            XPDataTableObject row = ((XPDataTableObject)gridViewParent.GetRow(gridViewParent.FocusedRowHandle));
            object id = row.GetMemberValue("TwreedOrderId");
            if (id == null)
            {
                MsgDlg.Show("من فضلك احفظ قبل الطباعة", MsgDlg.MessageType.Error);
                return;
            }
            FixedAssets.XRep.xRep002 rep = new FixedAssets.XRep.xRep002(Convert.ToInt32(id));
            Classes.Misc.ShowPrintPreview(rep);
        }
        
        #endregion

    }
}
