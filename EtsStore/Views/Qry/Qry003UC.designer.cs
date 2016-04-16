namespace FixedAssets.Views.Qry
{
    partial class Qry003UC
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
            this.UOW = new DevExpress.Xpo.UnitOfWork();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu();
            this.barManagerMain = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEznEdafaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEznEdafadate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colStorename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSanfID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSanfName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorderquntity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditAssetplaceId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEditAssetsCategoryID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEditEmpOhda = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEditAssetStateId = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEditUserIn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource();
            this.colEmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepertment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colezndes = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetplaceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetsCategoryID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEmpOhda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetStateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
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
            this.gridControlMain.DataSource = this.XPSCS;
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
            this.repositoryItemLookUpEditUserIn,
            this.repositoryItemDateEditDMY});
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
            this.colEznEdafaId,
            this.colEznEdafadate,
            this.colStorename,
            this.colSanfID,
            this.colSanfName,
            this.colorderquntity,
            this.colAssetState,
            this.colEmpName,
            this.colDepertment,
            this.colezndes});
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
            // colEznEdafaId
            // 
            this.colEznEdafaId.AppearanceCell.Options.UseTextOptions = true;
            this.colEznEdafaId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEznEdafaId.AppearanceHeader.Options.UseTextOptions = true;
            this.colEznEdafaId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEznEdafaId.Caption = "رقم الاذن";
            this.colEznEdafaId.FieldName = "EznSarfId";
            this.colEznEdafaId.Name = "colEznEdafaId";
            this.colEznEdafaId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "EznEdafaId", "{0}")});
            this.colEznEdafaId.Visible = true;
            this.colEznEdafaId.VisibleIndex = 0;
            // 
            // colEznEdafadate
            // 
            this.colEznEdafadate.AppearanceCell.Options.UseTextOptions = true;
            this.colEznEdafadate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEznEdafadate.AppearanceHeader.Options.UseTextOptions = true;
            this.colEznEdafadate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEznEdafadate.Caption = "التاريخ";
            this.colEznEdafadate.ColumnEdit = this.repositoryItemDateEditDMY;
            this.colEznEdafadate.FieldName = "EznSarfafdate";
            this.colEznEdafadate.Name = "colEznEdafadate";
            this.colEznEdafadate.Visible = true;
            this.colEznEdafadate.VisibleIndex = 1;
            // 
            // repositoryItemDateEditDMY
            // 
            this.repositoryItemDateEditDMY.AutoHeight = false;
            this.repositoryItemDateEditDMY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY.DisplayFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditDMY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.EditFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditDMY.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY.Mask.EditMask = "d/M/yyyy";
            this.repositoryItemDateEditDMY.Name = "repositoryItemDateEditDMY";
            // 
            // colStorename
            // 
            this.colStorename.AppearanceCell.Options.UseTextOptions = true;
            this.colStorename.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStorename.AppearanceHeader.Options.UseTextOptions = true;
            this.colStorename.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStorename.Caption = "المخزن";
            this.colStorename.FieldName = "Storename";
            this.colStorename.Name = "colStorename";
            this.colStorename.Visible = true;
            this.colStorename.VisibleIndex = 4;
            // 
            // colSanfID
            // 
            this.colSanfID.AppearanceCell.Options.UseTextOptions = true;
            this.colSanfID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSanfID.AppearanceHeader.Options.UseTextOptions = true;
            this.colSanfID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSanfID.Caption = "كود الصنف";
            this.colSanfID.FieldName = "SanfID";
            this.colSanfID.Name = "colSanfID";
            this.colSanfID.Visible = true;
            this.colSanfID.VisibleIndex = 5;
            // 
            // colSanfName
            // 
            this.colSanfName.AppearanceCell.Options.UseTextOptions = true;
            this.colSanfName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSanfName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSanfName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSanfName.Caption = "اسم الصنف";
            this.colSanfName.FieldName = "SanfName";
            this.colSanfName.Name = "colSanfName";
            this.colSanfName.Visible = true;
            this.colSanfName.VisibleIndex = 6;
            // 
            // colorderquntity
            // 
            this.colorderquntity.AppearanceCell.Options.UseTextOptions = true;
            this.colorderquntity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colorderquntity.AppearanceHeader.Options.UseTextOptions = true;
            this.colorderquntity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colorderquntity.Caption = "الكمية";
            this.colorderquntity.FieldName = "sarfquntity";
            this.colorderquntity.Name = "colorderquntity";
            this.colorderquntity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "orderquntity", "{0:0.##}")});
            this.colorderquntity.Visible = true;
            this.colorderquntity.VisibleIndex = 7;
            // 
            // colAssetState
            // 
            this.colAssetState.AppearanceCell.Options.UseTextOptions = true;
            this.colAssetState.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetState.AppearanceHeader.Options.UseTextOptions = true;
            this.colAssetState.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAssetState.Caption = "الحالة";
            this.colAssetState.FieldName = "AssetState";
            this.colAssetState.Name = "colAssetState";
            this.colAssetState.Visible = true;
            this.colAssetState.VisibleIndex = 8;
            // 
            // repositoryItemLookUpEditAssetplaceId
            // 
            this.repositoryItemLookUpEditAssetplaceId.AutoHeight = false;
            this.repositoryItemLookUpEditAssetplaceId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditAssetplaceId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Assetplace", "الاسم", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditAssetplaceId.DisplayMember = "Assetplace";
            this.repositoryItemLookUpEditAssetplaceId.Name = "repositoryItemLookUpEditAssetplaceId";
            this.repositoryItemLookUpEditAssetplaceId.NullText = "";
            this.repositoryItemLookUpEditAssetplaceId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditAssetplaceId.ValueMember = "AssetplaceId";
            // 
            // repositoryItemLookUpEditAssetsCategoryID
            // 
            this.repositoryItemLookUpEditAssetsCategoryID.AutoHeight = false;
            this.repositoryItemLookUpEditAssetsCategoryID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditAssetsCategoryID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssetsCategoryName", "الاسم", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditAssetsCategoryID.DisplayMember = "AssetsCategoryName";
            this.repositoryItemLookUpEditAssetsCategoryID.Name = "repositoryItemLookUpEditAssetsCategoryID";
            this.repositoryItemLookUpEditAssetsCategoryID.NullText = "";
            this.repositoryItemLookUpEditAssetsCategoryID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditAssetsCategoryID.ValueMember = "AssetsCategoryID";
            // 
            // repositoryItemLookUpEditEmpOhda
            // 
            this.repositoryItemLookUpEditEmpOhda.AutoHeight = false;
            this.repositoryItemLookUpEditEmpOhda.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditEmpOhda.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "الاسم", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditEmpOhda.DisplayMember = "EmpName";
            this.repositoryItemLookUpEditEmpOhda.Name = "repositoryItemLookUpEditEmpOhda";
            this.repositoryItemLookUpEditEmpOhda.NullText = "";
            this.repositoryItemLookUpEditEmpOhda.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditEmpOhda.ValueMember = "EmpId";
            // 
            // repositoryItemLookUpEditAssetStateId
            // 
            this.repositoryItemLookUpEditAssetStateId.AutoHeight = false;
            this.repositoryItemLookUpEditAssetStateId.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditAssetStateId.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssetState", "الاسم", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditAssetStateId.DisplayMember = "AssetState";
            this.repositoryItemLookUpEditAssetStateId.Name = "repositoryItemLookUpEditAssetStateId";
            this.repositoryItemLookUpEditAssetStateId.NullText = "";
            this.repositoryItemLookUpEditAssetStateId.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditAssetStateId.ValueMember = "AssetStateId";
            // 
            // repositoryItemLookUpEditUserIn
            // 
            this.repositoryItemLookUpEditUserIn.AutoHeight = false;
            this.repositoryItemLookUpEditUserIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUserIn.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "الاسم", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditUserIn.DisplayMember = "UserName";
            this.repositoryItemLookUpEditUserIn.Name = "repositoryItemLookUpEditUserIn";
            this.repositoryItemLookUpEditUserIn.NullText = "";
            this.repositoryItemLookUpEditUserIn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditUserIn.ValueMember = "UserID";
            // 
            // XPSCS
            // 
            this.XPSCS.ObjectType = typeof(FixedAssets.Datasource.dsQry.vQry003DataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // colEmpName
            // 
            this.colEmpName.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpName.Caption = "الاسم";
            this.colEmpName.FieldName = "EmpName";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.Visible = true;
            this.colEmpName.VisibleIndex = 3;
            // 
            // colDepertment
            // 
            this.colDepertment.AppearanceCell.Options.UseTextOptions = true;
            this.colDepertment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepertment.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepertment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepertment.Caption = "الجهة";
            this.colDepertment.FieldName = "Depertment";
            this.colDepertment.Name = "colDepertment";
            this.colDepertment.Visible = true;
            this.colDepertment.VisibleIndex = 2;
            // 
            // colezndes
            // 
            this.colezndes.AppearanceCell.Options.UseTextOptions = true;
            this.colezndes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colezndes.AppearanceHeader.Options.UseTextOptions = true;
            this.colezndes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colezndes.Caption = "ملاحظات";
            this.colezndes.FieldName = "ezndes";
            this.colezndes.Name = "colezndes";
            this.colezndes.Visible = true;
            this.colezndes.VisibleIndex = 9;
            // 
            // Qry003UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Qry003UC";
            this.Size = new System.Drawing.Size(1024, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetplaceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetsCategoryID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditEmpOhda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditAssetStateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditAssetplaceId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditAssetsCategoryID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditEmpOhda;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditAssetStateId;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn colEznEdafaId;
        private DevExpress.XtraGrid.Columns.GridColumn colEznEdafadate;
        private DevExpress.XtraGrid.Columns.GridColumn colStorename;
        private DevExpress.XtraGrid.Columns.GridColumn colSanfID;
        private DevExpress.XtraGrid.Columns.GridColumn colSanfName;
        private DevExpress.XtraGrid.Columns.GridColumn colorderquntity;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetState;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepertment;
        private DevExpress.XtraGrid.Columns.GridColumn colezndes;
    }
}
