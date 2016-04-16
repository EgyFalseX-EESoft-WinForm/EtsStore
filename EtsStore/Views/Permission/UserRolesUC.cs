using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;

namespace FixedAssets.Views.Permission
{
    public partial class UserRolesUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(UserRolesUC));
        FixedAssets.Datasource.dsData.RoleDetialRow _elementRule = null;
        #endregion
        #region - Fun -
        public UserRolesUC(FixedAssets.Datasource.dsData.RoleDetialRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadData()
        {
            ruleTableAdapter.Fill(dsData.Roles);
            usersTableAdapter.Fill(dsData.Users);
            userRuleTableAdapter.Fill(dsData.UserRoles);
        }
        public void ActivateRules()
        {
            return;
            //XPSCS.AllowNew = _elementRule.Inserting;
            //XPSCS.AllowRemove = _elementRule.Deleting;
            //XPSCS.AllowEdit = _elementRule.Updateing;

            if (!_elementRule.Updateing)
                bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            if (!_elementRule.Inserting)
            {
                gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            }

            if (!_elementRule.Deleting)
                gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;

        }
        #endregion
        #region -  EventWhnd - 
        private void ProductEditorUC_Load(object sender, EventArgs e)
        {
            LoadData();
            ActivateRules();
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;

            userRuleTableAdapter.Update(dsData.UserRoles);
            MsgDlg.ShowAlert("تم الحفظ ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
            Logger.Info("تم الحفظ ...");
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            userRuleTableAdapter.Fill(dsData.UserRoles);
            gridViewMain.RefreshData();
        }
        #endregion

    }
}
