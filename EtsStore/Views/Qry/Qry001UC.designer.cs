namespace FixedAssets.Views.Qry
{
    partial class Qry001UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAssetsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetsCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditAssetsCategoryID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSCat = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colAssetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetsdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colasasemony = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsumehlak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontentnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmostandnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetplaceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditAssetplaceId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSAssetplace = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colnesbaehlak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmprecive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditEmpOhda = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSEmp = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colEmpOhda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetStateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditAssetStateId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSAssetState = new DevExpress.Data.Linq.LinqServerModeSource();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.LSMSUsers = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemLookUpEditUserIn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetsCategoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetplaceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAssetplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEmpOhda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetStateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAssetState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).BeginInit();
            this.SuspendLayout();
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiExport,
            this.bbiRefresh});
            this.barManagerMain.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Glyph = global::FixedAssets.Properties.Resources.refresh2_16x16;
            this.bbiRefresh.Id = 2;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Glyph = global::FixedAssets.Properties.Resources.Export;
            this.bbiExport.Id = 1;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1024, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Size = new System.Drawing.Size(1024, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 377);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1024, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditAssetplaceId,
            this.repositoryItemLookUpEditAssetsCategoryID,
            this.repositoryItemLookUpEditEmpOhda,
            this.repositoryItemLookUpEditAssetStateId,
            this.repositoryItemLookUpEditUserIn});
            this.gridControlMain.Size = new System.Drawing.Size(1024, 377);
            this.gridControlMain.TabIndex = 5;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMain.Appearance.Row.Options.UseFont = true;
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAssetsID,
            this.colAssetsCategoryID,
            this.colAssetName,
            this.colAssetsdate,
            this.colasasemony,
            this.colsumehlak,
            this.colcontentnumber,
            this.colmostandnumber,
            this.colAssetplaceId,
            this.colnesbaehlak,
            this.colEmprecive,
            this.colEmpOhda,
            this.colAssetStateId,
            this.colUserIn,
            this.coldateIn});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsBehavior.ReadOnly = true;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // colAssetsID
            // 
            this.colAssetsID.AppearanceCell.Options.UseTextOptions = true;
            this.colAssetsID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetsID.AppearanceHeader.Options.UseTextOptions = true;
            this.colAssetsID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetsID.Caption = "كود";
            this.colAssetsID.FieldName = "AssetsID";
            this.colAssetsID.Name = "colAssetsID";
            this.colAssetsID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "AssetsID", "{0}")});
            this.colAssetsID.Visible = true;
            this.colAssetsID.VisibleIndex = 12;
            // 
            // colAssetsCategoryID
            // 
            this.colAssetsCategoryID.AppearanceCell.Options.UseTextOptions = true;
            this.colAssetsCategoryID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetsCategoryID.AppearanceHeader.Options.UseTextOptions = true;
            this.colAssetsCategoryID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetsCategoryID.Caption = "التصنيف";
            this.colAssetsCategoryID.ColumnEdit = this.repositoryItemLookUpEditAssetsCategoryID;
            this.colAssetsCategoryID.FieldName = "AssetsCategoryID";
            this.colAssetsCategoryID.Name = "colAssetsCategoryID";
            this.colAssetsCategoryID.Visible = true;
            this.colAssetsCategoryID.VisibleIndex = 11;
            // 
            // repositoryItemLookUpEditAssetsCategoryID
            // 
            this.repositoryItemLookUpEditAssetsCategoryID.AutoHeight = false;
            this.repositoryItemLookUpEditAssetsCategoryID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditAssetsCategoryID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssetsCategoryName", "الاسم", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditAssetsCategoryID.DataSource = this.LSMSCat;
            this.repositoryItemLookUpEditAssetsCategoryID.DisplayMember = "AssetsCategoryName";
            this.repositoryItemLookUpEditAssetsCategoryID.Name = "repositoryItemLookUpEditAssetsCategoryID";
            this.repositoryItemLookUpEditAssetsCategoryID.NullText = "";
            this.repositoryItemLookUpEditAssetsCategoryID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditAssetsCategoryID.ValueMember = "AssetsCategoryID";
            // 
            // LSMSCat
            // 
            this.LSMSCat.ElementType = typeof(FixedAssets.Datasource.linq.CdAssetsCategory);
            this.LSMSCat.KeyExpression = "[AssetsCategoryID]";
            // 
            // colAssetName
            // 
            this.colAssetName.AppearanceCell.Options.UseTextOptions = true;
            this.colAssetName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetName.AppearanceHeader.Options.UseTextOptions = true;
            this.colAssetName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetName.Caption = "الاصل";
            this.colAssetName.FieldName = "AssetName";
            this.colAssetName.Name = "colAssetName";
            this.colAssetName.Visible = true;
            this.colAssetName.VisibleIndex = 10;
            // 
            // colAssetsdate
            // 
            this.colAssetsdate.AppearanceCell.Options.UseTextOptions = true;
            this.colAssetsdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetsdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colAssetsdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetsdate.Caption = "تاريخ الاقتناء";
            this.colAssetsdate.FieldName = "Assetsdate";
            this.colAssetsdate.Name = "colAssetsdate";
            this.colAssetsdate.Visible = true;
            this.colAssetsdate.VisibleIndex = 9;
            // 
            // colasasemony
            // 
            this.colasasemony.AppearanceCell.Options.UseTextOptions = true;
            this.colasasemony.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colasasemony.AppearanceHeader.Options.UseTextOptions = true;
            this.colasasemony.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colasasemony.Caption = "القيمة الراسمالية";
            this.colasasemony.FieldName = "asasemony";
            this.colasasemony.Name = "colasasemony";
            this.colasasemony.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "asasemony", "{0:0.##}")});
            this.colasasemony.Visible = true;
            this.colasasemony.VisibleIndex = 8;
            this.colasasemony.Width = 100;
            // 
            // colsumehlak
            // 
            this.colsumehlak.AppearanceCell.Options.UseTextOptions = true;
            this.colsumehlak.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsumehlak.AppearanceHeader.Options.UseTextOptions = true;
            this.colsumehlak.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsumehlak.Caption = "مجمع اهلاك";
            this.colsumehlak.FieldName = "sumehlak";
            this.colsumehlak.Name = "colsumehlak";
            this.colsumehlak.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sumehlak", "{0:0.##}")});
            this.colsumehlak.Visible = true;
            this.colsumehlak.VisibleIndex = 7;
            this.colsumehlak.Width = 76;
            // 
            // colcontentnumber
            // 
            this.colcontentnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colcontentnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcontentnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colcontentnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcontentnumber.Caption = "عدد الاجزاء";
            this.colcontentnumber.FieldName = "contentnumber";
            this.colcontentnumber.Name = "colcontentnumber";
            this.colcontentnumber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "contentnumber", "{0:0.##}")});
            this.colcontentnumber.Visible = true;
            this.colcontentnumber.VisibleIndex = 5;
            // 
            // colmostandnumber
            // 
            this.colmostandnumber.AppearanceCell.Options.UseTextOptions = true;
            this.colmostandnumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostandnumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colmostandnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmostandnumber.Caption = "رقم المستند";
            this.colmostandnumber.FieldName = "mostandnumber";
            this.colmostandnumber.Name = "colmostandnumber";
            this.colmostandnumber.Visible = true;
            this.colmostandnumber.VisibleIndex = 3;
            this.colmostandnumber.Width = 79;
            // 
            // colAssetplaceId
            // 
            this.colAssetplaceId.AppearanceCell.Options.UseTextOptions = true;
            this.colAssetplaceId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetplaceId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAssetplaceId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetplaceId.Caption = "مكان الاصل";
            this.colAssetplaceId.ColumnEdit = this.repositoryItemLookUpEditAssetplaceId;
            this.colAssetplaceId.FieldName = "AssetplaceId";
            this.colAssetplaceId.Name = "colAssetplaceId";
            this.colAssetplaceId.Visible = true;
            this.colAssetplaceId.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEditAssetplaceId
            // 
            this.repositoryItemLookUpEditAssetplaceId.AutoHeight = false;
            this.repositoryItemLookUpEditAssetplaceId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditAssetplaceId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Assetplace", "الاسم", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditAssetplaceId.DataSource = this.LSMSAssetplace;
            this.repositoryItemLookUpEditAssetplaceId.DisplayMember = "Assetplace";
            this.repositoryItemLookUpEditAssetplaceId.Name = "repositoryItemLookUpEditAssetplaceId";
            this.repositoryItemLookUpEditAssetplaceId.NullText = "";
            this.repositoryItemLookUpEditAssetplaceId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditAssetplaceId.ValueMember = "AssetplaceId";
            // 
            // LSMSAssetplace
            // 
            this.LSMSAssetplace.ElementType = typeof(FixedAssets.Datasource.linq.CdAssetplace);
            this.LSMSAssetplace.KeyExpression = "[AssetplaceId]";
            // 
            // colnesbaehlak
            // 
            this.colnesbaehlak.AppearanceCell.Options.UseTextOptions = true;
            this.colnesbaehlak.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnesbaehlak.AppearanceHeader.Options.UseTextOptions = true;
            this.colnesbaehlak.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnesbaehlak.Caption = "نسبة الاهلاك";
            this.colnesbaehlak.FieldName = "nesbaehlak";
            this.colnesbaehlak.Name = "colnesbaehlak";
            this.colnesbaehlak.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "nesbaehlak", "{0:0.##}")});
            this.colnesbaehlak.Visible = true;
            this.colnesbaehlak.VisibleIndex = 6;
            this.colnesbaehlak.Width = 82;
            // 
            // colEmprecive
            // 
            this.colEmprecive.AppearanceCell.Options.UseTextOptions = true;
            this.colEmprecive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmprecive.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmprecive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmprecive.Caption = "المستلم";
            this.colEmprecive.ColumnEdit = this.repositoryItemLookUpEditEmpOhda;
            this.colEmprecive.FieldName = "Emprecive";
            this.colEmprecive.Name = "colEmprecive";
            this.colEmprecive.Visible = true;
            this.colEmprecive.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEditEmpOhda
            // 
            this.repositoryItemLookUpEditEmpOhda.AutoHeight = false;
            this.repositoryItemLookUpEditEmpOhda.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditEmpOhda.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "الاسم", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditEmpOhda.DataSource = this.LSMSEmp;
            this.repositoryItemLookUpEditEmpOhda.DisplayMember = "EmpName";
            this.repositoryItemLookUpEditEmpOhda.Name = "repositoryItemLookUpEditEmpOhda";
            this.repositoryItemLookUpEditEmpOhda.NullText = "";
            this.repositoryItemLookUpEditEmpOhda.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditEmpOhda.ValueMember = "EmpId";
            // 
            // LSMSEmp
            // 
            this.LSMSEmp.ElementType = typeof(FixedAssets.Datasource.linq.TblEmp);
            this.LSMSEmp.KeyExpression = "[EmpId]";
            // 
            // colEmpOhda
            // 
            this.colEmpOhda.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpOhda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpOhda.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpOhda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpOhda.Caption = "موظف العهدة";
            this.colEmpOhda.ColumnEdit = this.repositoryItemLookUpEditEmpOhda;
            this.colEmpOhda.FieldName = "EmpOhda";
            this.colEmpOhda.Name = "colEmpOhda";
            this.colEmpOhda.Visible = true;
            this.colEmpOhda.VisibleIndex = 0;
            this.colEmpOhda.Width = 80;
            // 
            // colAssetStateId
            // 
            this.colAssetStateId.AppearanceCell.Options.UseTextOptions = true;
            this.colAssetStateId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetStateId.AppearanceHeader.Options.UseTextOptions = true;
            this.colAssetStateId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetStateId.Caption = "الحالة";
            this.colAssetStateId.ColumnEdit = this.repositoryItemLookUpEditAssetStateId;
            this.colAssetStateId.FieldName = "AssetStateId";
            this.colAssetStateId.Name = "colAssetStateId";
            this.colAssetStateId.Visible = true;
            this.colAssetStateId.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEditAssetStateId
            // 
            this.repositoryItemLookUpEditAssetStateId.AutoHeight = false;
            this.repositoryItemLookUpEditAssetStateId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditAssetStateId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssetState", "الاسم", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditAssetStateId.DataSource = this.LSMSAssetState;
            this.repositoryItemLookUpEditAssetStateId.DisplayMember = "AssetState";
            this.repositoryItemLookUpEditAssetStateId.Name = "repositoryItemLookUpEditAssetStateId";
            this.repositoryItemLookUpEditAssetStateId.NullText = "";
            this.repositoryItemLookUpEditAssetStateId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditAssetStateId.ValueMember = "AssetStateId";
            // 
            // LSMSAssetState
            // 
            this.LSMSAssetState.ElementType = typeof(FixedAssets.Datasource.linq.CdAssetState);
            this.LSMSAssetState.KeyExpression = "[AssetStateId]";
            // 
            // colUserIn
            // 
            this.colUserIn.AppearanceCell.Options.UseTextOptions = true;
            this.colUserIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserIn.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserIn.Caption = "مدخل البيان";
            this.colUserIn.ColumnEdit = this.repositoryItemLookUpEditUserIn;
            this.colUserIn.FieldName = "UserIn";
            this.colUserIn.Name = "colUserIn";
            // 
            // coldateIn
            // 
            this.coldateIn.AppearanceCell.Options.UseTextOptions = true;
            this.coldateIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateIn.AppearanceHeader.Options.UseTextOptions = true;
            this.coldateIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateIn.Caption = "تاريخ الادخال";
            this.coldateIn.FieldName = "dateIn";
            this.coldateIn.Name = "coldateIn";
            // 
            // XPSCS
            // 
            this.XPSCS.ObjectType = typeof(FixedAssets.Datasource.dsQry.TblAssetsDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // LSMSUsers
            // 
            this.LSMSUsers.ElementType = typeof(FixedAssets.Datasource.linq.User);
            this.LSMSUsers.KeyExpression = "[UserID]";
            // 
            // repositoryItemLookUpEditUserIn
            // 
            this.repositoryItemLookUpEditUserIn.AutoHeight = false;
            this.repositoryItemLookUpEditUserIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUserIn.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "الاسم", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditUserIn.DataSource = this.LSMSUsers;
            this.repositoryItemLookUpEditUserIn.DisplayMember = "UserName";
            this.repositoryItemLookUpEditUserIn.Name = "repositoryItemLookUpEditUserIn";
            this.repositoryItemLookUpEditUserIn.NullText = "";
            this.repositoryItemLookUpEditUserIn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditUserIn.ValueMember = "UserID";
            // 
            // Qry001UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Qry001UC";
            this.Size = new System.Drawing.Size(1024, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetsCategoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetplaceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAssetplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEmpOhda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetStateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAssetState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork UOW;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSEmp;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSAssetState;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditAssetplaceId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditAssetsCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetsID;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetsCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetName;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetsdate;
        private DevExpress.XtraGrid.Columns.GridColumn colasasemony;
        private DevExpress.XtraGrid.Columns.GridColumn colsumehlak;
        private DevExpress.XtraGrid.Columns.GridColumn colcontentnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colmostandnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetplaceId;
        private DevExpress.XtraGrid.Columns.GridColumn colnesbaehlak;
        private DevExpress.XtraGrid.Columns.GridColumn colEmprecive;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpOhda;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetStateId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn coldateIn;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSAssetplace;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCat;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditEmpOhda;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditAssetStateId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUsers;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUserIn;
    }
}
