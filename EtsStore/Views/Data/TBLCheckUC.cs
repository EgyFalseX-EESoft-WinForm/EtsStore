using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using DevExpress.Xpo.Metadata;
using FixedAssets.Views.Data.dlg;

namespace FixedAssets.Views.Data
{
    public partial class TBLCheckUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLCheckUC));
        Datasource.dsData.RoleDetialRow _elementRule = null;
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        #endregion
        #region - Fun -
        public TBLCheckUC(Datasource.dsData.RoleDetialRow RuleElement)
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
                    LSMSUsers.QueryableSource = from q in dsLinq.Users select q;
                    LSMSTBLBuyorder.QueryableSource = from q in dsLinq.TBLBuyorders select q;
                    LSMSTBLTwreedOrder.QueryableSource = from q in dsLinq.TBLTwreedOrders select q;
                    LSMSTblEmp.QueryableSource = from q in dsLinq.TblEmps select q;
                    LSMSCdJoblagna.QueryableSource = from q in dsLinq.CdJoblagnas select q;
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

            btnAddMain.Visible = _elementRule.Inserting;
            btnSaveDetails.Visible = _elementRule.Inserting;
            btnSaveEmp.Visible = _elementRule.Inserting;

            btnEditMain.Visible = _elementRule.Updateing;

            btnDeleteMain.Visible = _elementRule.Deleting;
            btnDeleteDetails.Visible = _elementRule.Deleting;
            btnDeleteEmp.Visible = _elementRule.Deleting;
            
        }
        private void LoadId(int id)
        {
            tblAsnafTableAdapter.FillByTwreedOrderId(dsData.TblAsnaf, id);
            tBLCheckdetailsTableAdapter.FillByChecklagnaID(dsData.TBLCheckdetails, id);
            tBLCheckEmpTableAdapter.FillByChecklagnaID(dsData.TBLCheckEmp, id);
        }
        private void RefreshDefaultDatasource()
        {
            LSMSUsers.Reload();
            LSMSTBLBuyorder.Reload();
            LSMSTBLTwreedOrder.Reload();
            LSMSTblEmp.Reload();
            LSMSCdJoblagna.Reload();
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
                DevExpress.Xpo.Metadata.XPDataTableObject TwreedOrderRow = (DevExpress.Xpo.Metadata.XPDataTableObject)row.GetMemberValue("TwreedOrderId");
                object TwreedOrderId = TwreedOrderRow.GetMemberValue("TwreedOrderId");

                if (row != null && TwreedOrderId != null)
                {
                    //load details
                    LoadId((int)TwreedOrderId);
                    tBLCheckdetailsTableAdapter.FillByChecklagnaID(dsData.TBLCheckdetails, Convert.ToInt32(row.GetMemberValue("ChecklagnaID")));
                    gridViewDetails.RefreshData();
                    tBLCheckEmpTableAdapter.FillByChecklagnaID(dsData.TBLCheckEmp, Convert.ToInt32(row.GetMemberValue("ChecklagnaID")));
                    gridViewEmp.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnAddMain_Click(object sender, EventArgs e)
        {
            try
            {
                TBLCheckEditorDlg frm = new TBLCheckEditorDlg(-1, true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    XPSCSMain.FixedFilterString = "ChecklagnaID = " + frm._m_ChecklagnaID;
                    XPSCSMain.Session.DropIdentityMap();
                    XPSCSMain.Reload();
                    gridViewMain.RefreshData();
                    gridViewMain.FocusedRowHandle = 1;
                    //load details
                    LoadId(frm._m_ChecklagnaID);
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnEditMain_Click(object sender, EventArgs e)
        {
            try
            {
                XPDataTableObject row = (XPDataTableObject)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
                if (row == null)
                    return;
                TBLCheckEditorDlg frm = new TBLCheckEditorDlg(Convert.ToInt32(row.GetMemberValue("ChecklagnaID")), false);
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
        private void btnDeleteMain_Click(object sender, EventArgs e)
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
            Datasource.dsData.TBLCheckdetailsRow Row = (Datasource.dsData.TBLCheckdetailsRow)((DataRowView)gridViewDetails.GetRow(gridViewDetails.FocusedRowHandle)).Row;
            if (Row == null)
                return;
            int ChecklagnaID = Convert.ToInt32(ParentRow.GetMemberValue("ChecklagnaID"));
            Row.ChecklagnaID = ChecklagnaID;
            Row.accepted = false;
            Row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
            Row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
        }
        private void gridViewEmp_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            XPDataTableObject ParentRow = (XPDataTableObject)gridViewMain.GetRow(gridViewMain.FocusedRowHandle);
            if (ParentRow == null)
                return;
            Datasource.dsData.TBLCheckEmpRow Row = (Datasource.dsData.TBLCheckEmpRow)((DataRowView)gridViewEmp.GetRow(gridViewEmp.FocusedRowHandle)).Row;
            if (Row == null)
                return;
            int ChecklagnaID = Convert.ToInt32(ParentRow.GetMemberValue("ChecklagnaID"));
            Row.ChecklagnaID = ChecklagnaID;
            Row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
            Row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
        }
        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            for (int i = 0; i < dsData.TBLCheckdetails.Count; i++)
            {
                if (dsData.TBLCheckdetails[i].RowState == DataRowState.Modified)
                {
                    dsData.TBLCheckdetails[i].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    dsData.TBLCheckdetails[i].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                }
            }
            tBLCheckdetailsBindingSource.EndEdit();
            tBLCheckdetailsTableAdapter.Update(dsData.TBLCheckdetails);
        }
        private void btnDeleteDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewDetails.DeleteSelectedRows();
                    tBLCheckdetailsBindingSource.EndEdit();
                    tBLCheckdetailsTableAdapter.Update(dsData.TBLCheckdetails);
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
            if (row.GetMemberValue("ChecklagnaID") == null)
            {
                MsgDlg.Show("من فضلك احفظ قبل الطباعة", MsgDlg.MessageType.Error);
                return;
            }

            FixedAssets.XRep.xRep003 rep = new FixedAssets.XRep.xRep003(Convert.ToInt32(row.GetMemberValue("ChecklagnaID")));
            Classes.Misc.ShowPrintPreview(rep);
        }
        private void btnRefreashDetails_Click(object sender, EventArgs e)
        {
            RefreshDefaultDatasource();
        }
        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            for (int i = 0; i < dsData.TBLCheckEmp.Count; i++)
            {
                if (dsData.TBLCheckEmp[i].RowState == DataRowState.Modified)
                {
                    dsData.TBLCheckEmp[i].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    dsData.TBLCheckEmp[i].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                }
            }
            tBLCheckEmpBindingSource.EndEdit();
            tBLCheckEmpTableAdapter.Update(dsData.TBLCheckEmp);
        }
        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.Yes)
                {
                    gridViewEmp.DeleteSelectedRows();
                    tBLCheckEmpBindingSource.EndEdit();
                    tBLCheckEmpTableAdapter.Update(dsData.TBLCheckEmp);
                    gridViewEmp.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
        }
        private void btnRefreshEmp_Click(object sender, EventArgs e)
        {
            RefreshDefaultDatasource();
        }

        #endregion
    
    }
}
