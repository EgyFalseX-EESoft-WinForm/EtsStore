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
    public partial class TBLEznEdafaUC : XtraUserControl
    {

        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLEznEdafaUC));
        Datasource.dsData.RoleDetialRow _elementRule = null;
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        #endregion
        #region - Fun -
        public TBLEznEdafaUC(Datasource.dsData.RoleDetialRow RuleElement)
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
                    LSMSTBLSupplier.QueryableSource = from q in dsLinq.TBLSuppliers select q;
                    LSMSTBLCheck.QueryableSource = from q in dsLinq.TBLChecks select q;
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
                if (row != null && row.GetMemberValue("EznEdafaId") != null)
                {
                    //Load TBBuyorderdetails Grid
                    gridViewDetails.ShowLoadingPanel();
                    tBLEznEdafaDetailsTableAdapter.FillByEznEdafaId(dsData.TBLEznEdafaDetails, Convert.ToInt32(row.GetMemberValue("EznEdafaId")));
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
                TBLEznEdafaEditorDlg frm = new TBLEznEdafaEditorDlg(-1, true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    XPSCSMain.FixedFilterString = "EznEdafaId = " + frm._m_EznEdafaId;
                    XPSCSMain.Session.DropIdentityMap();
                    XPSCSMain.Reload();
                    gridViewMain.RefreshData();
                    gridViewMain.FocusedRowHandle = 1;
                    tBLEznEdafaDetailsTableAdapter.FillByEznEdafaId(dsData.TBLEznEdafaDetails, frm._m_EznEdafaId);
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
                TBLEznEdafaEditorDlg frm = new TBLEznEdafaEditorDlg(Convert.ToInt32(row.GetMemberValue("EznEdafaId")), false);
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
        private void gridViewMain_ShownEditor(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.ColumnView view = (DevExpress.XtraGrid.Views.Base.ColumnView)sender;
            XPDataTableObject row = (XPDataTableObject)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            if (row == null)
                return;
            if (row.GetMemberValue("jointocheck") == null || Convert.ToBoolean(row.GetMemberValue("jointocheck")) == false)
                view.ActiveEditor.Properties.ReadOnly = true;
            else
                view.ActiveEditor.Properties.ReadOnly = false;
        }
        private void gridViewDetails_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            XPDataTableObject ParentRow = (XPDataTableObject)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            if (ParentRow == null)
                return;
            Datasource.dsData.TBLEznEdafaDetailsRow Row = (Datasource.dsData.TBLEznEdafaDetailsRow)((DataRowView)gridViewDetails.GetRow(gridViewDetails.FocusedRowHandle)).Row;
            if (Row == null)
                return;
            int EznEdafaId = Convert.ToInt32(ParentRow.GetMemberValue("EznEdafaId"));
            Row.EznEdafaId = EznEdafaId;
            Row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
            Row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
        }
        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            for (int i = 0; i < dsData.TBLEznEdafaDetails.Count; i++)
            {
                if (dsData.TBLEznEdafaDetails[i].RowState == DataRowState.Modified)
                {
                    dsData.TBLEznEdafaDetails[i].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    dsData.TBLEznEdafaDetails[i].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                }
            }
            tBLEznEdafaDetailsBindingSource.EndEdit();
            tBLEznEdafaDetailsTableAdapter.Update(dsData.TBLEznEdafaDetails);
        }
        private void btnDeleteDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewDetails.DeleteSelectedRows();
                    tBLEznEdafaDetailsBindingSource.EndEdit();
                    tBLEznEdafaDetailsTableAdapter.Update(dsData.TBLEznEdafaDetails);
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
            if (row.GetMemberValue("EznEdafaId") == null)
            {
                MsgDlg.Show("من فضلك احفظ قبل الطباعة", MsgDlg.MessageType.Error);
                return;
            }

            FixedAssets.XRep.xRep004 rep = new FixedAssets.XRep.xRep004(Convert.ToInt32(row.GetMemberValue("EznEdafaId")));
            Classes.Misc.ShowPrintPreview(rep);
        }
        private void btnRefreashDetails_Click(object sender, EventArgs e)
        {
            LSMSTblAsnaf.Reload();
            LSMSCDStore.Reload();
            LSMSUsers.Reload();
            LSMSTBLSupplier.Reload();
            LSMSTBLCheck.Reload();
            LSMSCdAssetState.Reload();
        }
        #endregion

        

    }
}
