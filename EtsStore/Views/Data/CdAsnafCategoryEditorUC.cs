using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing;
using DevExpress.XtraGrid;
using DevExpress.Xpo.Metadata;

namespace FixedAssets.Views.Data
{
    public partial class CdAsnafCategoryEditorUC : XtraUserControl
    {

        #region - Variables -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(CdAsnafCategoryEditorUC));
        FixedAssets.Datasource.dsData.RoleDetialRow _elementRule = null;
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        FixedAssets.Datasource.dsDataTableAdapters.CdAsnafCategoryTableAdapter adpCategory = new FixedAssets.Datasource.dsDataTableAdapters.CdAsnafCategoryTableAdapter();
        GridHitInfo downHitInfo = null;

        #endregion
        #region - Functions -
        public CdAsnafCategoryEditorUC(FixedAssets.Datasource.dsData.RoleDetialRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadData()
        {
            XPSCSCat.Session.ConnectionString = Properties.Settings.Default.EtsStoreConnectionString;
            treeListMain.DataSource = XPSCSCat;
            LSMSUnitId.QueryableSource = from q in dsLinq.CDUnits select q;
            LSMSAsnaftypeId.QueryableSource = from q in dsLinq.CDAsnaftypes select q;
        }
        public void ActivateRules()
        {
            gridControlItem.Visible = _elementRule.Selecting;
            treeListMain.Visible = _elementRule.Selecting;

            if (!_elementRule.Inserting)
            {
                bbiAddNode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                XPSCSCat.AllowNew = _elementRule.Inserting;
                btnAddAsset.Visible = false;
                
            }
            if (!_elementRule.Updateing)
            {
                XPSCSCat.AllowEdit = _elementRule.Updateing;
                btnEditAsset.Visible = false;
                
            }
            if (!_elementRule.Deleting)
            {
                bbiDeleteNode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                XPSCSCat.AllowRemove = _elementRule.Deleting;
                btnDeleteAsset.Visible = false;
                
            }
        }
        #endregion
        #region - EventWhnd -
        private void ProductEditorUC_Load(object sender, EventArgs e)
        {
            ActivateRules();
            LoadData();
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             //Check whether the GridControl can be previewed.
            if (!treeListMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            treeListMain.ShowRibbonPrintPreview();
            
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            sessionCat.DropIdentityMap();
            XPSCSCat.Reload();
            treeListMain.RefreshDataSource();
        }
        private void bbiAddNode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lock (this)
            {
                int ParentNode;
                if (treeListMain.FocusedNode != null)
                    ParentNode = treeListMain.FocusedNode.Id;
                else
                    ParentNode = 0;
                try
                {
                    int NewNodeId = (int)adpCategory.NewId();
                    treeListMain.AppendNode(new object[] { null, NewNodeId, "جديد" }, ParentNode, 0, 0, 0);
                }
                catch{ }
            }
        }
        private void sessionCat_BeforeCommitTransaction(object sender, DevExpress.Xpo.SessionManipulationEventArgs e)
        {
            DevExpress.Xpo.Helpers.ObjectSet Rows = (DevExpress.Xpo.Helpers.ObjectSet)e.Session.GetObjectsToSave();
            foreach (DevExpress.Xpo.Metadata.XPDataTableObject item in Rows)
            {
                item.SetMemberValue("UserIn", Classes.Managers.UserManager.defaultInstance.User.UserId);
                item.SetMemberValue("dateIn", Classes.Managers.DataManager.GetServerDatetime);
            }
        }
        private void bbiDeleteNode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            treeListMain.DeleteSelectedNodes();
        }
        private void treeListMain_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            treeListMain.BestFitColumns();
        }
        private void treeListMain_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            object id = null;
            if (treeListMain.FocusedNode == null)
                id = -1;
            else
                id = e.Node.GetValue("SanfCategoryID");

            gridViewItem.ShowLoadingPanel();
            XPCSItem.FixedFilterString = "[SanfCategoryID] = " + id;
            sessionItem.DropIdentityMap();
            XPCSItem.Reload();
            gridViewItem.RefreshData();
            gridViewItem.HideLoadingPanel();


            //LoadParamGrid();

        }
        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            try
            {
                object id = null;
                if (treeListMain.FocusedNode == null)
                    return;
                id = treeListMain.FocusedNode.GetValue("SanfCategoryID");
                TblAsnafEditorDlg frm = new TblAsnafEditorDlg((int)id, true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sessionItem.DropIdentityMap();
                    XPCSItem.Reload();
                    gridViewItem.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditAsset_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewItem.GetRow(gridViewItem.FocusedRowHandle);
                if (row == null)
                    return;
                TblAsnafEditorDlg frm = new TblAsnafEditorDlg(Convert.ToInt32(row.GetMemberValue("SanfID")), false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sessionItem.DropIdentityMap();
                    XPCSItem.Reload();
                    gridViewItem.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteAsset_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewItem.GetRow(gridViewItem.FocusedRowHandle);
            if (row == null)
                return;
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
            {
                gridViewItem.DeleteSelectedRows();
                sessionItem.DropIdentityMap();
                XPCSItem.Reload();
                gridViewItem.RefreshData();
            }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }

        #endregion

    }
}
