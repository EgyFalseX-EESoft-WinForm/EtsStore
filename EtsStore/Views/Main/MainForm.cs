using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Views;
using System.Drawing;
using FixedAssets.Views.Code;
using FixedAssets.Views.Permission;
using FixedAssets.Views.Data;
using FixedAssets.Views.Qry;

namespace FixedAssets.Views.Main
{
    public partial class MainForm : XtraForm
    {
        #region - Variables -
        #endregion
        #region - Functions -
        public MainForm()
        {
            InitializeComponent();
            windowsUIView.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False;
            AddGeneralButtions();
            AddPrivateButtions();
        }
        private void AddGeneralButtions()
        {

            //Minimize Button
            DelegateAction btnMinimize = new DelegateAction(() => { return true; }, () =>
            {
                WindowState = System.Windows.Forms.FormWindowState.Minimized;
            });
            btnMinimize.Type = ActionType.Navigation;
            btnMinimize.Caption = "Minimize";
            btnMinimize.Behavior = ActionBehavior.Default;
            btnMinimize.Edge = ActionEdge.Default;
            btnMinimize.Image = FixedAssets.Properties.Resources.next_32x32;
            windowsUIView.ContentContainerActions.Add(btnMinimize);
        }
        public void AddPrivateButtions()
        {
            //User Setting Button
            DelegateAction btnUserSettings = new DelegateAction(() => { return true; }, () =>
            {
                windowsUIView.Controller.Activate(pageUserSettings);
            });
            btnUserSettings.Type = ActionType.Context;
            btnUserSettings.Caption = "User Settings";
            btnUserSettings.Behavior = ActionBehavior.HideBarOnClick;
            btnUserSettings.Edge = ActionEdge.Left;
            btnUserSettings.Image = Properties.Resources.ide_32x32;
            windowsUIView.ContentContainerActions.Add(btnUserSettings);

        }
        public void LoadLayout()
        {
            // Load Layout Saved Settings
            string FileName = Program.TilesLayoutFile + Classes.Managers.UserManager.defaultInstance.User.UserId.ToString();
            if (System.IO.File.Exists(FileName))
            {
                System.IO.FileStream Fs = new System.IO.FileStream(FileName, System.IO.FileMode.Open);
                windowsUIView.RestoreLayoutFromStream(Fs);
            }
        }
        public void ActivateRules()
        {
            if (Classes.Managers.UserManager.defaultInstance.User.IsAdmin == true)
                return;

            foreach (var item in windowsUIView.ContentContainers.ToArray())
            {
                if (item.GetType() != typeof(TileContainer))//Apply Only For Tiles Containers 
                    continue;

                if (((TileContainer)item).Items == null)
                    continue;
                for (int InxContainers = 0; InxContainers < ((TileContainer)item).Items.Count; InxContainers++)
                {
                    TileContainer cntr = (TileContainer)item;
                    for (int i = (cntr).Items.Count - 1; i >= 0; i--)
                    {
                        Tile tile = (Tile)(cntr).Items[i];
                        FixedAssets.Datasource.dsData.RoleDetialRow elementRule = Classes.Managers.UserManager.defaultInstance.RuleElementInformation(tile.Document.ControlName);
                        if (tile.Tag != null && (bool)tile.Tag)// Show Exception Tiles
                            tile.Visible = true;
                        else
                            tile.Visible = elementRule.Selecting;
                    }
                }
            }
        }
        #endregion
        #region - EventWhnd -
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            ActivateRules();
            LoadLayout();
            windowsUIView.ActivateContainer(tileContainerMain);
            
        }
        private void windowsUIView_QueryControl(object sender, QueryControlEventArgs e)
        {

            Datasource.dsData.RoleDetialRow RuleElemet = Classes.Managers.UserManager.defaultInstance.RuleElementInformation(e.Document.ControlName);
            if (e.Control != null)
                return;
            if (e.Document == docUserSetting)
            {
                e.Control = new UserSettingsUC();
            }
            //---------Code
            else if (e.Document == docCodeCdAssetplace)
            {
                e.Control = new CdAssetplaceEditorUC(RuleElemet);
            }
            else if (e.Document == docCodecdJob)
            {
                e.Control = new CdJobEditorUC(RuleElemet);
            }
            else if (e.Document == docCodeCdDepertment)
            {
                e.Control = new CdDepertmentEditorUC(RuleElemet);
            }
            else if (e.Document == docCodeCdAssetPropertiy)
            {
                e.Control = new CdAssetPropertiyEditorUC(RuleElemet);
            }
            else if (e.Document == docCodeCdAssetState)
            {
                e.Control = new CdAssetStateEditorUC(RuleElemet);
            }
            else if (e.Document == docCodeCDComponents)
            {
                e.Control = new CDComponentsEditorUC(RuleElemet);
            }
            else if (e.Document == docCodeCDInsuranceCo)
            {
                e.Control = new CDInsuranceCoEditorUC(RuleElemet);
            }
            else if (e.Document == docCodeCDUnit)
            {
                e.Control = new CDUnitEditorUC(RuleElemet);
            }
            else if (e.Document == docCodeCDBuyorderreson)
            {
                e.Control = new CDBuyorderresonEditorUC(RuleElemet);
            }
            else if (e.Document == docCodeTBLCompany)
            {
                e.Control = new CompanyUC(RuleElemet);
            }
            else if (e.Document == docCodeCDStore)
            {
                e.Control = new CDStoreEditorUC(RuleElemet);
            }

            //---------Data
            else if (e.Document == docDataCdAssetsCategory)
            {
                e.Control = new CdAssetsCategoryEditorUC(RuleElemet);
            }
            else if (e.Document == docDataTblEmp)
            {
                e.Control = new TblEmpEditorUC(RuleElemet);
            }
            else if (e.Document == docDataCdAsnafCategory)
            {
                e.Control = new CdAsnafCategoryEditorUC(RuleElemet);
            }
            else if (e.Document == docDataTBLBuyorder)
            {
                e.Control = new TBLBuyorderUC(RuleElemet);
            }
            else if (e.Document == docDataTBLSuppliers)
            {
                e.Control = new TBLSuppliersEditorUC(RuleElemet);
            }
            else if (e.Document == docDataTBLTwreedOrder)
            {
                e.Control = new TBLTwreedOrderEditorUC(RuleElemet);
            }
            else if (e.Document == docDataTBLCheck)
            {
                e.Control = new TBLCheckUC(RuleElemet);
            }
            else if (e.Document == docDataTBLEznEdafa)
            {
                e.Control = new TBLEznEdafaUC(RuleElemet);
            }
            else if (e.Document == docDataTBLEznSarf)
            {
                e.Control = new TBLEznSarfUC(RuleElemet);
            }

            //---------Rules
            else if (e.Document == docRuleUsers)
            {
                e.Control = new UsersUC(RuleElemet);
            }
            else if (e.Document == docRuleRule)
            {
                e.Control = new RolesUC(RuleElemet);
            }
            else if (e.Document == docRuleUserRoles)
            {
                e.Control = new UserRolesUC(RuleElemet);
            }
            else if (e.Document == docRuleRuleDetails)
            {
                e.Control = new RuleDetailsUC(RuleElemet);
            }
            else if (e.Document == docQryQry001)//Qry
            {
                e.Control = new Qry001UC();
            }
            else if (e.Document == docQryQry002)
            {
                e.Control = new Qry002UC();
            }
            else if (e.Document == docQryQry003)
            {
                e.Control = new Qry003UC();
            }

        }
        #endregion
        
    }
}
