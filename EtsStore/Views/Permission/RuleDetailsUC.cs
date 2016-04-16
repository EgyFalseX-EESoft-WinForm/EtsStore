using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using DevExpress.XtraTreeList.Nodes;

namespace FixedAssets.Views.Permission
{
    public partial class RuleDetailsUC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(RuleDetailsUC));
        FixedAssets.Datasource.dsData.RoleDetialRow _elementRule = null;
        #endregion
        #region - Fun -
        public RuleDetailsUC(FixedAssets.Datasource.dsData.RoleDetialRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
        }
        void LoadRulesList()
        {
            rolesTableAdapter.Fill(dsData.Roles);
        }
        public static void LoadDefaultNodes(DevExpress.XtraTreeList.TreeList Tree, FixedAssets.Views.Main.MainForm MainFrm)
        {
            Tree.Nodes.Clear();
            Tree.BeginUnboundLoad();
            // Create a root node .
            TreeListNode RootNode = Tree.AppendNode(new object[] { "Main", false, false, false, false, "Main" }, 0); ;
            ExtractTilesFromTileContainer(MainFrm.tileContainerMain, RootNode);
            Tree.EndUnboundLoad();
        }
        private static void ExtractTilesFromTileContainer(DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer TCont, DevExpress.XtraTreeList.Nodes.TreeListNode RootNode)
        {
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile in TCont.Items)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode NewNode = RootNode.TreeList.AppendNode(new object[] { tile.Document.Caption, false, false, false, false, tile.Document.ControlName }, RootNode);

                if (tile.ActivationTarget != null)
                {
                    if (tile.ActivationTarget.GetType() == typeof(DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer))
                        ExtractTilesFromTileContainer((DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer)tile.ActivationTarget, NewNode);
                    else if (tile.ActivationTarget.GetType() == typeof(DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup))
                        ExtractTilesFromGroupContainer((DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup)tile.ActivationTarget, NewNode);
                }
            }
        }
        private static void ExtractTilesFromGroupContainer(DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup GCont, DevExpress.XtraTreeList.Nodes.TreeListNode RootNode)
        {
            foreach (DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document doc in GCont.Items)
                RootNode.TreeList.AppendNode(new object[] { doc.Caption, false, false, false, false, doc.ControlName }, RootNode);
        }
        void LoadUserData(int RuleID)
        {
            ruleDetailTableAdapter.FillByRoleID(dsData.RoleDetial, RuleID);

            foreach (FixedAssets.Datasource.dsData.RoleDetialRow row in dsData.RoleDetial)
            {
                TreeListNode node = (TreeListNode)TLItems.FindNodeByFieldValue("ID", row.MenuItemName);
                if (node != null)
                {
                    node.SetValue(tlcSelect, row.Selecting);
                    node.SetValue(tlcInsert, row.Inserting);
                    node.SetValue(tlcUpdate, row.Updateing);
                    node.SetValue(tlcDelete, row.Deleting);
                }
            }
        }
        void SaveUserData(int RuleID)
        {

            ruleDetailTableAdapter.DeleteByRoleID(RuleID);//Delete All Rule Contains To Add New
            ruleDetailTableAdapter.FillByRoleID(dsData.RoleDetial, RuleID);//Empty RuleDetail Table
            List<TreeListNode> Nodes = GetAllItems(TLItems);

            foreach (TreeListNode node in Nodes)
            {
                FixedAssets.Datasource.dsData.RoleDetialRow row = dsData.RoleDetial.NewRoleDetialRow();
                row.RoleID = RuleID; row.MenuItemName = node.GetValue(tlcID).ToString();
                row.Selecting = Convert.ToBoolean(node.GetValue(tlcSelect)); row.Inserting = Convert.ToBoolean(node.GetValue(tlcInsert));
                row.Updateing = Convert.ToBoolean(node.GetValue(tlcUpdate)); row.Deleting = Convert.ToBoolean(node.GetValue(tlcDelete));
                dsData.RoleDetial.AddRoleDetialRow(row);
            }
            ruleDetailTableAdapter.Update(dsData.RoleDetial);
        }
        public static List<TreeListNode> GetAllItems(DevExpress.XtraTreeList.TreeList Tree)
        {
            List<TreeListNode> Nodes = new List<TreeListNode>();
            foreach (TreeListNode node in Tree.Nodes)
                GetSubNodes(node, ref Nodes);
            return Nodes;
        }
        static void GetSubNodes(TreeListNode NodesParent, ref List<TreeListNode> Nodes)
        {
            foreach (TreeListNode node in NodesParent.Nodes)
            {
                if (node.HasChildren)
                    GetSubNodes(node, ref Nodes);
                else
                    Nodes.Add(node);
            }
        }
        public void ActivateRules()
        {
            if (!_elementRule.Updateing)
                bbiSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            
        }
        #endregion
        #region -  EventWhnd - 
        private void ProductEditorUC_Load(object sender, EventArgs e)
        {
            LoadRulesList();
            ActivateRules();
        }
        private void bbiRule_EditValueChanged(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(FixedAssets.Views.Main.WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    LoadDefaultNodes(TLItems, (FixedAssets.Views.Main.MainForm)Parent.Parent.Parent);
                    LoadUserData(Convert.ToInt32(bbiRule.EditValue));
                }));
                SplashScreenManager.CloseForm();
            });
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(bbiRule.EditValue))
                return;
            int RuleID = Convert.ToInt32(bbiRule.EditValue);

            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;

            SplashScreenManager.ShowForm(typeof(FixedAssets.Views.Main.WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    SaveUserData(RuleID);
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, (Form)Parent.Parent.Parent);
                    Logger.Info("Data Saved ...");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MsgDlg.ShowAlert(String.Format("Saving Failed ...{0}{1}", Environment.NewLine, ex.Message), MsgDlg.MessageType.Error, (Form)Parent.Parent.Parent);
                    Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
                   
                }
                SplashScreenManager.CloseForm();
            });
            
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!TLItems.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            TLItems.ShowRibbonPrintPreview();
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            LoadRulesList();
            bbiRule_EditValueChanged(bbiRule, EventArgs.Empty);
        }
        #endregion

    }
}
