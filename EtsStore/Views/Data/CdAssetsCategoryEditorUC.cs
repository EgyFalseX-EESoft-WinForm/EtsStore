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
    public partial class CdAssetsCategoryEditorUC : XtraUserControl
    {

        #region - Variables -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(CdAssetsCategoryEditorUC));
        FixedAssets.Datasource.dsData.RoleDetialRow _elementRule = null;
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        FixedAssets.Datasource.dsDataTableAdapters.CdAssetsCategoryTableAdapter adpCategory = new FixedAssets.Datasource.dsDataTableAdapters.CdAssetsCategoryTableAdapter();
        GridHitInfo downHitInfo = null;

        #endregion
        #region - Functions -
        public CdAssetsCategoryEditorUC(FixedAssets.Datasource.dsData.RoleDetialRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadData()
        {
            XPSCSCat.Session.ConnectionString = Properties.Settings.Default.EtsStoreConnectionString;
            treeListMain.DataSource = XPSCSCat;
            LSMSAssetplaceId.QueryableSource = from q in dsLinq.CdAssetplaces select q;
            LSMSAssetStateId.QueryableSource = from q in dsLinq.CdAssetStates select q;
            LSMSEmp.QueryableSource = from q in dsLinq.TblEmps select q;
            LSMSCdAssetPropertiy.QueryableSource = from q in dsLinq.CdAssetPropertiys select q;
            LSMSCDComponents.QueryableSource = from q in dsLinq.CDComponents select q;
        }
        public void ActivateRules()
        {
            gridControlAsset.Visible = _elementRule.Selecting;
            treeListMain.Visible = _elementRule.Selecting;

            if (!_elementRule.Inserting)
            {
                bbiAddNode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                XPSCSCat.AllowNew = _elementRule.Inserting;
                btnAddAsset.Visible = false;
                btnAddTBLAssetComponent.Visible = false;
                btnAddTBLAssetPropertiy.Visible = false;
                btnAddTBLReEvaluation.Visible = false;
                btnAddTBLAssetPlace.Visible = false;
                btnAddTBLAddAssetComponent.Visible = false;
                btnAddTBLDeleteAssetComponent.Visible = false;
                btnAddTBLAssetOhda.Visible = false;
            }
            if (!_elementRule.Updateing)
            {
                XPSCSCat.AllowEdit = _elementRule.Updateing;
                btnEditAsset.Visible = false;
                btnEditTBLAssetComponent.Visible = false;
                btnEditTBLAssetPropertiy.Visible = false;
                btnEditTBLReEvaluation.Visible = false;
                btnEditTBLAssetPlace.Visible = false;
                btnEditTBLAddAssetComponent.Visible = false;
                btnEditTBLDeleteAssetComponent.Visible = false;
                btnEditTBLAssetOhda.Visible = false;
            }
            if (!_elementRule.Deleting)
            {
                bbiDeleteNode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                XPSCSCat.AllowRemove = _elementRule.Deleting;
                btnDeleteAsset.Visible = false;
                btnDeleteTBLAssetComponent.Visible = false;
                btnDeleteTBLAssetPropertiy.Visible = false;
                btnDeleteTBLReEvaluation.Visible = false;
                btnDeleteTBLAssetPlace.Visible = false;
                btnDeleteTBLAddAssetComponent.Visible = false;
                btnDeleteTBLDeleteAssetComponent.Visible = false;
                btnDeleteTBLAssetOhda.Visible = false;
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
                id = e.Node.GetValue("AssetsCategoryID");

            gridViewAsset.ShowLoadingPanel();
            XPCSAsset.FixedFilterString = "[AssetsCategoryID] = " + id;
            sessionAsset.DropIdentityMap();
            XPCSAsset.Reload();
            gridViewAsset.RefreshData();
            gridViewAsset.HideLoadingPanel();


            //LoadParamGrid();

        }
        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            try
            {
                object id = null;
                if (treeListMain.FocusedNode == null)
                    return;
                id = treeListMain.FocusedNode.GetValue("AssetsCategoryID");
                AssetEditorDlg frm = new AssetEditorDlg((int)id, true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sessionAsset.DropIdentityMap();
                    XPCSAsset.Reload();
                    gridViewAsset.RefreshData();
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
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                AssetEditorDlg frm = new AssetEditorDlg(Convert.ToInt32(row.GetMemberValue("AssetsID")), false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    sessionAsset.DropIdentityMap();
                    XPCSAsset.Reload();
                    gridViewAsset.RefreshData();
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
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
            if (row == null)
                return;
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
            {
                gridViewAsset.DeleteSelectedRows();
                sessionAsset.DropIdentityMap();
                XPCSAsset.Reload();
                gridViewAsset.RefreshData();
            }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void gridViewAsset_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                DevExpress.Xpo.Metadata.XPDataTableObject row = ((DevExpress.Xpo.Metadata.XPDataTableObject)gridViewAsset.GetRow(e.RowHandle));
            if (row != null && row.GetMemberValue("AssetsID") != null)
            {
                //Load TBLAssetPropertiy Grid
                gridViewTBLAssetPropertiy.ShowLoadingPanel();
                tBLAssetPropertiyTableAdapter.FillByAssetsID(dsData.TBLAssetPropertiy, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                gridViewTBLAssetPropertiy.RefreshData();
                gridViewTBLAssetPropertiy.HideLoadingPanel();

                //Load TBLReEvaluation Grid
                gridViewTBLReEvaluation.ShowLoadingPanel();
                tBLReEvaluationTableAdapter.FillByAssetsID(dsData.TBLReEvaluation, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                gridViewTBLReEvaluation.RefreshData();
                gridViewTBLReEvaluation.HideLoadingPanel();

                //Load TBLAssetPlace Grid
                gridViewTBLAssetPlace.ShowLoadingPanel();
                tBLAssetPlaceTableAdapter.FillByAssetsID(dsData.TBLAssetPlace, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                gridViewTBLAssetPlace.RefreshData();
                gridViewTBLAssetPlace.HideLoadingPanel();

                //Load TBLAssetComponent Grid
                gridViewTBLAssetComponent.ShowLoadingPanel();
                tBLAssetComponentTableAdapter.FillByAssetsID(dsData.TBLAssetComponent, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                gridViewTBLAssetComponent.RefreshData();
                gridViewTBLAssetComponent.HideLoadingPanel();

                //Load TBLAddAssetComponent Grid
                gridViewTBLAddAssetComponent.ShowLoadingPanel();
                tBLAddAssetComponentTableAdapter.FillByAssetsID(dsData.TBLAddAssetComponent, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                gridViewTBLAddAssetComponent.RefreshData();
                gridViewTBLAddAssetComponent.HideLoadingPanel();

                //Load TBLDeleteAssetComponent Grid
                gridViewTBLDeleteAssetComponent.ShowLoadingPanel();
                tBLDeleteAssetComponentTableAdapter.FillByAssetsID(dsData.TBLDeleteAssetComponent, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                gridViewTBLDeleteAssetComponent.RefreshData();
                gridViewTBLDeleteAssetComponent.HideLoadingPanel();

                //Load TBLAssetOhda Grid
                gridViewTBLAssetOhda.ShowLoadingPanel();
                tBLAssetOhdaTableAdapter.FillByAssetsID(dsData.TBLAssetOhda, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                gridViewTBLAssetOhda.RefreshData();
                gridViewTBLAssetOhda.HideLoadingPanel();
            }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnAddTBLAssetPropertiy_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                TBLAssetPropertiyDlg frm = new TBLAssetPropertiyDlg(Convert.ToInt32(row.GetMemberValue("AssetsID")));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAssetPropertiy.ShowLoadingPanel();
                    tBLAssetPropertiyTableAdapter.FillByAssetsID(dsData.TBLAssetPropertiy, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                    gridViewTBLAssetPropertiy.RefreshData();
                    gridViewTBLAssetPropertiy.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditTBLAssetPropertiy_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gridViewTBLAssetPropertiy.GetRow(gridViewTBLAssetPropertiy.FocusedRowHandle);
            if (drv == null)
                return;
            Datasource.dsData.TBLAssetPropertiyRow row = (Datasource.dsData.TBLAssetPropertiyRow)(drv).Row;
            if (row == null)
                return;
            TBLAssetPropertiyDlg frm = new TBLAssetPropertiyDlg(row.AssetsID, row.AssetPropertiyId);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                gridViewTBLAssetPropertiy.ShowLoadingPanel();
                tBLAssetPropertiyTableAdapter.FillByAssetsID(dsData.TBLAssetPropertiy, row.AssetsID);
                gridViewTBLAssetPropertiy.RefreshData();
                gridViewTBLAssetPropertiy.HideLoadingPanel();
            }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteTBLAssetPropertiy_Click(object sender, EventArgs e)
        {
            try
            {
                Datasource.dsData.TBLAssetPropertiyRow row = (Datasource.dsData.TBLAssetPropertiyRow)((DataRowView)gridViewTBLAssetPropertiy.GetRow(gridViewTBLAssetPropertiy.FocusedRowHandle)).Row;
            if (row == null)
                return;
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
            {
                gridViewTBLAssetPropertiy.ShowLoadingPanel();
                tBLAssetPropertiyTableAdapter.Delete(row.AssetsID, row.AssetPropertiyId);
                gridViewTBLAssetPropertiy.DeleteRow(gridViewTBLAssetPropertiy.FocusedRowHandle);
                gridViewTBLAssetPropertiy.RefreshData();
                gridViewTBLAssetPropertiy.HideLoadingPanel();
            }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnAddTBLReEvaluation_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                if (row == null)
                    return;
                TBLReEvaluationDlg frm = new TBLReEvaluationDlg(Convert.ToInt32(row.GetMemberValue("AssetsID")), true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLReEvaluation.ShowLoadingPanel();
                    tBLReEvaluationTableAdapter.FillByAssetsID(dsData.TBLReEvaluation, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                    gridViewTBLReEvaluation.RefreshData();
                    gridViewTBLReEvaluation.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditTBLReEvaluation_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gridViewTBLReEvaluation.GetRow(gridViewTBLReEvaluation.FocusedRowHandle);
                if (drv == null)
                    return;
                Datasource.dsData.TBLReEvaluationRow row = (Datasource.dsData.TBLReEvaluationRow)(drv).Row;
                if (row == null)
                    return;
                TBLReEvaluationDlg frm = new TBLReEvaluationDlg(row.ReEvaluationId, false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLReEvaluation.ShowLoadingPanel();
                    tBLReEvaluationTableAdapter.FillByAssetsID(dsData.TBLReEvaluation, row.AssetsID);
                    gridViewTBLReEvaluation.RefreshData();
                    gridViewTBLReEvaluation.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteTBLReEvaluation_Click(object sender, EventArgs e)
        {
            try
            {
                Datasource.dsData.TBLReEvaluationRow row = (Datasource.dsData.TBLReEvaluationRow)((DataRowView)gridViewTBLReEvaluation.GetRow(gridViewTBLReEvaluation.FocusedRowHandle)).Row;
                if (row == null)
                    return;
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewTBLReEvaluation.ShowLoadingPanel();
                    tBLReEvaluationTableAdapter.Delete(row.AssetsID, row.datere);
                    gridViewTBLReEvaluation.DeleteRow(gridViewTBLReEvaluation.FocusedRowHandle);
                    gridViewTBLReEvaluation.RefreshData();
                    gridViewTBLReEvaluation.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnAddTBLAssetPlace_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                if (row == null)
                    return;
                TBLAssetPlaceDlg frm = new TBLAssetPlaceDlg(Convert.ToInt32(row.GetMemberValue("AssetsID")), true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAssetPlace.ShowLoadingPanel();
                    tBLAssetPlaceTableAdapter.FillByAssetsID(dsData.TBLAssetPlace, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                    gridViewTBLAssetPlace.RefreshData();
                    gridViewTBLAssetPlace.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditTBLAssetPlace_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gridViewTBLAssetPlace.GetRow(gridViewTBLAssetPlace.FocusedRowHandle);
                if (drv == null)
                    return;
                Datasource.dsData.TBLAssetPlaceRow row = (Datasource.dsData.TBLAssetPlaceRow)(drv).Row;
                if (row == null)
                    return;
                TBLAssetPlaceDlg frm = new TBLAssetPlaceDlg(row.AssetRePlaceId, false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAssetPlace.ShowLoadingPanel();
                    tBLAssetPlaceTableAdapter.FillByAssetsID(dsData.TBLAssetPlace, row.AssetsID);
                    gridViewTBLAssetPlace.RefreshData();
                    gridViewTBLAssetPlace.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteTBLAssetPlace_Click(object sender, EventArgs e)
        {
            try
            {
                Datasource.dsData.TBLAssetPlaceRow row = (Datasource.dsData.TBLAssetPlaceRow)((DataRowView)gridViewTBLAssetPlace.GetRow(gridViewTBLAssetPlace.FocusedRowHandle)).Row;
                if (row == null)
                    return;
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewTBLAssetPlace.ShowLoadingPanel();
                    tBLAssetPlaceTableAdapter.Delete(row.AssetsID, row.datep, row.AssetplaceId);
                    gridViewTBLAssetPlace.DeleteRow(gridViewTBLAssetPlace.FocusedRowHandle);
                    gridViewTBLAssetPlace.RefreshData();
                    gridViewTBLAssetPlace.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnAddTBLAssetComponent_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                if (row == null)
                    return;
                TBLAssetComponentDlg frm = new TBLAssetComponentDlg(Convert.ToInt32(row.GetMemberValue("AssetsID")), true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAssetComponent.ShowLoadingPanel();
                    tBLAssetComponentTableAdapter.FillByAssetsID(dsData.TBLAssetComponent, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                    gridViewTBLAssetComponent.RefreshData();
                    gridViewTBLAssetComponent.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditTBLAssetComponent_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gridViewTBLAssetComponent.GetRow(gridViewTBLAssetComponent.FocusedRowHandle);
                if (drv == null)
                    return;
                Datasource.dsData.TBLAssetComponentRow row = (Datasource.dsData.TBLAssetComponentRow)(drv).Row;
                if (row == null)
                    return;
                TBLAssetComponentDlg frm = new TBLAssetComponentDlg(row.TBLAssetComponentId, false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAssetComponent.ShowLoadingPanel();
                    tBLAssetComponentTableAdapter.FillByAssetsID(dsData.TBLAssetComponent, row.AssetsID);
                    gridViewTBLAssetComponent.RefreshData();
                    gridViewTBLAssetComponent.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteTBLAssetComponent_Click(object sender, EventArgs e)
        {
            try
            {
                Datasource.dsData.TBLAssetComponentRow row = (Datasource.dsData.TBLAssetComponentRow)((DataRowView)gridViewTBLAssetComponent.GetRow(gridViewTBLAssetComponent.FocusedRowHandle)).Row;
                if (row == null)
                    return;
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewTBLAssetComponent.ShowLoadingPanel();
                    tBLAssetComponentTableAdapter.Delete(row.AssetsID, row.ComponentId);
                    gridViewTBLAssetComponent.DeleteRow(gridViewTBLAssetComponent.FocusedRowHandle);
                    gridViewTBLAssetComponent.RefreshData();
                    gridViewTBLAssetComponent.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnAddTBLAddAssetComponent_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                if (row == null)
                    return;
                TBLAddAssetComponentDlg frm = new TBLAddAssetComponentDlg(Convert.ToInt32(row.GetMemberValue("AssetsID")), true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAddAssetComponent.ShowLoadingPanel();
                    tBLAddAssetComponentTableAdapter.FillByAssetsID(dsData.TBLAddAssetComponent, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                    gridViewTBLAddAssetComponent.RefreshData();
                    gridViewTBLAddAssetComponent.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditTBLAddAssetComponent_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gridViewTBLAddAssetComponent.GetRow(gridViewTBLAddAssetComponent.FocusedRowHandle);
                if (drv == null)
                    return;
                Datasource.dsData.TBLAddAssetComponentRow row = (Datasource.dsData.TBLAddAssetComponentRow)(drv).Row;
                if (row == null)
                    return;
                TBLAddAssetComponentDlg frm = new TBLAddAssetComponentDlg(row.AddComponentezn, false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAddAssetComponent.ShowLoadingPanel();
                    tBLAddAssetComponentTableAdapter.FillByAssetsID(dsData.TBLAddAssetComponent, row.AssetsID);
                    gridViewTBLAddAssetComponent.RefreshData();
                    gridViewTBLAddAssetComponent.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteTBLAddAssetComponent_Click(object sender, EventArgs e)
        {
            try
            {
                Datasource.dsData.TBLAddAssetComponentRow row = (Datasource.dsData.TBLAddAssetComponentRow)((DataRowView)gridViewTBLAddAssetComponent.GetRow(gridViewTBLAddAssetComponent.FocusedRowHandle)).Row;
                if (row == null)
                    return;
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewTBLAddAssetComponent.ShowLoadingPanel();
                    tBLAddAssetComponentTableAdapter.Delete(row.AddComponentezn);
                    gridViewTBLAddAssetComponent.DeleteRow(gridViewTBLAddAssetComponent.FocusedRowHandle);
                    gridViewTBLAddAssetComponent.RefreshData();
                    gridViewTBLAddAssetComponent.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnAddTBLDeleteAssetComponent_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                if (row == null)
                    return;
                TBLDeleteAssetComponentDlg frm = new TBLDeleteAssetComponentDlg(Convert.ToInt32(row.GetMemberValue("AssetsID")), true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLDeleteAssetComponent.ShowLoadingPanel();
                    tBLDeleteAssetComponentTableAdapter.FillByAssetsID(dsData.TBLDeleteAssetComponent, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                    gridViewTBLDeleteAssetComponent.RefreshData();
                    gridViewTBLDeleteAssetComponent.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditTBLDeleteAssetComponent_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gridViewTBLDeleteAssetComponent.GetRow(gridViewTBLDeleteAssetComponent.FocusedRowHandle);
                if (drv == null)
                    return;
                Datasource.dsData.TBLDeleteAssetComponentRow row = (Datasource.dsData.TBLDeleteAssetComponentRow)(drv).Row;
                if (row == null)
                    return;
                TBLDeleteAssetComponentDlg frm = new TBLDeleteAssetComponentDlg(row.DeleteComponentezn, false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLDeleteAssetComponent.ShowLoadingPanel();
                    tBLDeleteAssetComponentTableAdapter.FillByAssetsID(dsData.TBLDeleteAssetComponent, row.AssetsID);
                    gridViewTBLDeleteAssetComponent.RefreshData();
                    gridViewTBLDeleteAssetComponent.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteTBLDeleteAssetComponent_Click(object sender, EventArgs e)
        {
            try
            {
                Datasource.dsData.TBLDeleteAssetComponentRow row = (Datasource.dsData.TBLDeleteAssetComponentRow)((DataRowView)gridViewTBLDeleteAssetComponent.GetRow(gridViewTBLDeleteAssetComponent.FocusedRowHandle)).Row;
                if (row == null)
                    return;
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewTBLDeleteAssetComponent.ShowLoadingPanel();
                    tBLDeleteAssetComponentTableAdapter.Delete(row.DeleteComponentezn);
                    gridViewTBLDeleteAssetComponent.DeleteRow(gridViewTBLDeleteAssetComponent.FocusedRowHandle);
                    gridViewTBLDeleteAssetComponent.RefreshData();
                    gridViewTBLDeleteAssetComponent.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnAddTBLAssetOhda_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewAsset.GetRow(gridViewAsset.FocusedRowHandle);
                if (row == null)
                    return;
                if (row == null)
                    return;
                TBLAssetOhdaDlg frm = new TBLAssetOhdaDlg(Convert.ToInt32(row.GetMemberValue("AssetsID")), true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAssetOhda.ShowLoadingPanel();
                    tBLAssetOhdaTableAdapter.FillByAssetsID(dsData.TBLAssetOhda, Convert.ToInt32(row.GetMemberValue("AssetsID")));
                    gridViewTBLAssetOhda.RefreshData();
                    gridViewTBLAssetOhda.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditTBLAssetOhda_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)gridViewTBLAssetOhda.GetRow(gridViewTBLAssetOhda.FocusedRowHandle);
                if (drv == null)
                    return;
                Datasource.dsData.TBLAssetOhdaRow row = (Datasource.dsData.TBLAssetOhdaRow)(drv).Row;
                if (row == null)
                    return;
                TBLAssetOhdaDlg frm = new TBLAssetOhdaDlg(row.AssetOhdaId, false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    gridViewTBLAssetOhda.ShowLoadingPanel();
                    tBLAssetOhdaTableAdapter.FillByAssetsID(dsData.TBLAssetOhda, row.AssetsID);
                    gridViewTBLAssetOhda.RefreshData();
                    gridViewTBLAssetOhda.HideLoadingPanel();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnDeleteTBLAssetOhda_Click(object sender, EventArgs e)
        {
            try
            {
                Datasource.dsData.TBLAssetOhdaRow row = (Datasource.dsData.TBLAssetOhdaRow)((DataRowView)gridViewTBLAssetOhda.GetRow(gridViewTBLAssetOhda.FocusedRowHandle)).Row;
                if (row == null)
                    return;
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewTBLAssetOhda.ShowLoadingPanel();
                    tBLAssetOhdaTableAdapter.Delete(row.AssetsID, row.EmoOhdaId, row.fromdate);
                    gridViewTBLAssetOhda.DeleteRow(gridViewTBLAssetOhda.FocusedRowHandle);
                    gridViewTBLAssetOhda.RefreshData();
                    gridViewTBLAssetOhda.HideLoadingPanel();
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
