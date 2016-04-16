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
    public partial class TBLEznSarfUC : XtraUserControl
    {

        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLEznSarfUC));
        Datasource.dsData.RoleDetialRow _elementRule = null;
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsDataTableAdapters.QueriesTableAdapter();
        #endregion
        #region - Fun -
        public TBLEznSarfUC(Datasource.dsData.RoleDetialRow RuleElement)
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
                    LSMSCDStore.QueryableSource = from q in dsLinq.CDStores select q;
                    LSMSUsers.QueryableSource = from q in dsLinq.Users select q;
                    LSMSCdDepertment.QueryableSource = from q in dsLinq.CdDepertments select q;
                    LSMSTblEmp.QueryableSource = from q in dsLinq.TblEmps select q;
                    LSMSCdAssetState.QueryableSource = from q in dsLinq.CdAssetStates select q;
                    XPSCSMain.Session.ConnectionString = Properties.Settings.Default.EtsStoreConnectionString;
                    gridControlMain.DataSource = XPSCSMain;
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        public void ActivateRules()
        {
            XPSCSMain.AllowNew = _elementRule.Inserting;
            XPSCSMain.AllowRemove = _elementRule.Deleting;
            XPSCSMain.AllowEdit = _elementRule.Updateing;

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
        private void gridViewMain_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewMain.GetRow(e.RowHandle));
                if (row != null && row.GetMemberValue("EznSarfId") != null)
                {
                    //Load TBBuyorderdetails Grid
                    gridViewDetails.ShowLoadingPanel();
                    tBLEznSarfDetailsTableAdapter.FillByEznSarfId(dsData.TBLEznSarfDetails, Convert.ToInt32(row.GetMemberValue("EznSarfId")));
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
                TBLEznSarfEditorDlg frm = new TBLEznSarfEditorDlg(-1, true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    XPSCSMain.FixedFilterString = "EznSarfId = " + frm._m_EznSarfId;
                    XPSCSMain.Session.DropIdentityMap();
                    XPSCSMain.Reload();
                    gridViewMain.RefreshData();
                    gridViewMain.FocusedRowHandle = 1;
                    tBLEznSarfDetailsTableAdapter.FillByEznSarfId(dsData.TBLEznSarfDetails, frm._m_EznSarfId);
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
                XPDataTableObject row = (XPDataTableObject)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
                if (row == null)
                    return;
                TBLEznSarfEditorDlg frm = new TBLEznSarfEditorDlg(Convert.ToInt32(row.GetMemberValue("EznSarfId")), false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    XPSCSMain.Session.DropIdentityMap();
                    XPSCSMain.Reload();
                    gridViewMain.RefreshData();
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
                XPDataTableObject row = (XPDataTableObject)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
                if (row == null)
                    return;
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewMain.DeleteSelectedRows();
                    XPSCSMain.Session.DropIdentityMap();
                    XPSCSMain.Reload();
                    gridViewMain.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void gridViewDetails_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            XPDataTableObject ParentRow = (XPDataTableObject)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            if (ParentRow == null)
                return;
            Datasource.dsData.TBLEznSarfDetailsRow Row = (Datasource.dsData.TBLEznSarfDetailsRow)((DataRowView)gridViewDetails.GetRow(gridViewDetails.FocusedRowHandle)).Row;
            if (Row == null)
                return;
            int EznSarfId = Convert.ToInt32(ParentRow.GetMemberValue("EznSarfId"));
            Row.EznSarfId = EznSarfId;
            Row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
            Row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
        }
        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            for (int i = 0; i < dsData.TBLEznSarfDetails.Count; i++)
            {
                if (dsData.TBLEznSarfDetails[i].RowState == DataRowState.Modified)
                {
                    dsData.TBLEznSarfDetails[i].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    dsData.TBLEznSarfDetails[i].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                }
                if (dsData.TBLEznSarfDetails[i].RowState == DataRowState.Modified || dsData.TBLEznSarfDetails[i].RowState == DataRowState.Unchanged)
                {
                    double? remaining = adpQry.SanfRemainingQuentity(dsData.TBLEznSarfDetails[i].SanfID, dsData.TBLEznSarfDetails[i].EznSarfId);
                    string SanfName = adpQry.GetSanfName(dsData.TBLEznSarfDetails[i].SanfID);
                    //check if Sanf quentity not exists
                    if (remaining == null || remaining < dsData.TBLEznSarfDetails[i].sarfquntity)
                    {
                        MsgDlg.Show("الكمية الموجودة بالمخزن غير كافية" + Environment.NewLine + "اسم الصنف: " + SanfName, MsgDlg.MessageType.Error);
                        return;
                    }
                    double? ReOrder = adpQry.GetSanfReOrder(dsData.TBLEznSarfDetails[i].SanfID);
                    //check if Sanf Reorder reached
                    if (ReOrder == null || remaining >= dsData.TBLEznSarfDetails[i].sarfquntity)
                        MsgDlg.Show("تم الوطول لحد الطلب" + Environment.NewLine + "اسم الصنف: " + SanfName, MsgDlg.MessageType.Warn);
                }
            }
            tBLEznSarfDetailsBindingSource.EndEdit();
            tBLEznSarfDetailsTableAdapter.Update(dsData.TBLEznSarfDetails);
            MsgDlg.Show("تم الحفـــظ", MsgDlg.MessageType.Success);
        }
        private void btnDeleteDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewDetails.DeleteSelectedRows();
                    tBLEznSarfDetailsBindingSource.EndEdit();
                    tBLEznSarfDetailsTableAdapter.Update(dsData.TBLEznSarfDetails);
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
            XPSCSMain.FixedFilterString = string.Empty;
        }
        private void repositoryItemButtonEditPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            XPDataTableObject row = ((XPDataTableObject)gridViewMain.GetRow(gridViewMain.FocusedRowHandle));
            if (row.GetMemberValue("EznSarfId") == null)
            {
                MsgDlg.Show("من فضلك احفظ قبل الطباعة", MsgDlg.MessageType.Error);
                return;
            }

            FixedAssets.XRep.xRep005 rep = new FixedAssets.XRep.xRep005(Convert.ToInt32(row.GetMemberValue("EznSarfId")));
            Classes.Misc.ShowPrintPreview(rep);
        }
        private void btnRefreashDetails_Click(object sender, EventArgs e)
        {
            LSMSTblAsnaf.Reload();
            LSMSCDStore.Reload();
            LSMSUsers.Reload();
            LSMSCdDepertment.Reload();
            LSMSTblEmp.Reload();
            LSMSCdAssetState.Reload();
        }
        #endregion

    }
}
