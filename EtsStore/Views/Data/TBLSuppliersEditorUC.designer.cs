namespace FixedAssets.Views.Data
{
    partial class TBLSuppliersEditorUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLSuppliersEditorUC));
            this.UOW = new DevExpress.Xpo.UnitOfWork(this.components);
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppliersegl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppliernashat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colSupplierdrebea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppliermobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppliertel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierfax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplieraddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppliermail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUserIn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LSMSUser = new DevExpress.Data.Linq.LinqServerModeSource();
            this.XPSCS = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).BeginInit();
            this.SuspendLayout();
            // 
            // UOW
            // 
            this.UOW.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UOW.TrackPropertiesModifications = false;
            this.UOW.BeforeCommitTransaction += new DevExpress.Xpo.SessionManipulationEventHandler(this.UOW_BeforeCommitTransaction);
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
            this.bbiSave,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExport)});
            this.bar1.Text = "Custom 2";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Glyph = global::FixedAssets.Properties.Resources.saveall_16x16;
            this.bbiSave.Id = 0;
            this.bbiSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.bbiSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSave.LargeGlyph")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(821, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Size = new System.Drawing.Size(821, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(821, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // gridControlMain
            // 
            this.gridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMain.Location = new System.Drawing.Point(0, 31);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.barManagerMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditUserIn,
            this.repositoryItemMemoExEdit1});
            this.gridControlMain.Size = new System.Drawing.Size(821, 377);
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
            this.colSupplierName,
            this.colSuppliersegl,
            this.colSuppliernashat,
            this.colSupplierdrebea,
            this.colSuppliermobile,
            this.colSuppliertel,
            this.colSupplierfax,
            this.colSupplieraddress,
            this.colSuppliermail,
            this.colUserIn,
            this.coldateIn});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewMain.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridViewMain.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewMain.OptionsSelection.InvertSelection = true;
            this.gridViewMain.OptionsSelection.MultiSelect = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowDetailButtons = false;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // colSupplierName
            // 
            this.colSupplierName.AppearanceCell.Options.UseTextOptions = true;
            this.colSupplierName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplierName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSupplierName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplierName.Caption = "الاسم";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 0;
            // 
            // colSuppliersegl
            // 
            this.colSuppliersegl.AppearanceCell.Options.UseTextOptions = true;
            this.colSuppliersegl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliersegl.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuppliersegl.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliersegl.Caption = "سجل تجاري";
            this.colSuppliersegl.FieldName = "Suppliersegl";
            this.colSuppliersegl.Name = "colSuppliersegl";
            this.colSuppliersegl.Visible = true;
            this.colSuppliersegl.VisibleIndex = 1;
            // 
            // colSuppliernashat
            // 
            this.colSuppliernashat.AppearanceCell.Options.UseTextOptions = true;
            this.colSuppliernashat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliernashat.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuppliernashat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliernashat.Caption = "النشاط";
            this.colSuppliernashat.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colSuppliernashat.FieldName = "Suppliernashat";
            this.colSuppliernashat.Name = "colSuppliernashat";
            this.colSuppliernashat.Visible = true;
            this.colSuppliernashat.VisibleIndex = 2;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colSupplierdrebea
            // 
            this.colSupplierdrebea.AppearanceCell.Options.UseTextOptions = true;
            this.colSupplierdrebea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplierdrebea.AppearanceHeader.Options.UseTextOptions = true;
            this.colSupplierdrebea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplierdrebea.Caption = "بطاقة ضريبية";
            this.colSupplierdrebea.FieldName = "Supplierdrebea";
            this.colSupplierdrebea.Name = "colSupplierdrebea";
            this.colSupplierdrebea.Visible = true;
            this.colSupplierdrebea.VisibleIndex = 3;
            // 
            // colSuppliermobile
            // 
            this.colSuppliermobile.AppearanceCell.Options.UseTextOptions = true;
            this.colSuppliermobile.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliermobile.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuppliermobile.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliermobile.Caption = "موبيل";
            this.colSuppliermobile.FieldName = "Suppliermobile";
            this.colSuppliermobile.Name = "colSuppliermobile";
            this.colSuppliermobile.Visible = true;
            this.colSuppliermobile.VisibleIndex = 4;
            // 
            // colSuppliertel
            // 
            this.colSuppliertel.AppearanceCell.Options.UseTextOptions = true;
            this.colSuppliertel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliertel.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuppliertel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliertel.Caption = "تليفون";
            this.colSuppliertel.FieldName = "Suppliertel";
            this.colSuppliertel.Name = "colSuppliertel";
            this.colSuppliertel.Visible = true;
            this.colSuppliertel.VisibleIndex = 5;
            // 
            // colSupplierfax
            // 
            this.colSupplierfax.AppearanceCell.Options.UseTextOptions = true;
            this.colSupplierfax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplierfax.AppearanceHeader.Options.UseTextOptions = true;
            this.colSupplierfax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplierfax.Caption = "فاكس";
            this.colSupplierfax.FieldName = "Supplierfax";
            this.colSupplierfax.Name = "colSupplierfax";
            this.colSupplierfax.Visible = true;
            this.colSupplierfax.VisibleIndex = 6;
            // 
            // colSupplieraddress
            // 
            this.colSupplieraddress.AppearanceCell.Options.UseTextOptions = true;
            this.colSupplieraddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplieraddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colSupplieraddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplieraddress.Caption = "العنوان";
            this.colSupplieraddress.FieldName = "Supplieraddress";
            this.colSupplieraddress.Name = "colSupplieraddress";
            this.colSupplieraddress.Visible = true;
            this.colSupplieraddress.VisibleIndex = 7;
            // 
            // colSuppliermail
            // 
            this.colSuppliermail.AppearanceCell.Options.UseTextOptions = true;
            this.colSuppliermail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliermail.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuppliermail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuppliermail.Caption = "بريد اليكتروني";
            this.colSuppliermail.FieldName = "Suppliermail";
            this.colSuppliermail.Name = "colSuppliermail";
            this.colSuppliermail.Visible = true;
            this.colSuppliermail.VisibleIndex = 8;
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
            this.coldateIn.Caption = "تاريخ البيان";
            this.coldateIn.FieldName = "dateIn";
            this.coldateIn.Name = "coldateIn";
            // 
            // repositoryItemLookUpEditUserIn
            // 
            this.repositoryItemLookUpEditUserIn.AutoHeight = false;
            this.repositoryItemLookUpEditUserIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUserIn.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "الاسم", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEditUserIn.DataSource = this.LSMSUser;
            this.repositoryItemLookUpEditUserIn.DisplayMember = "UserName";
            this.repositoryItemLookUpEditUserIn.Name = "repositoryItemLookUpEditUserIn";
            this.repositoryItemLookUpEditUserIn.NullText = "";
            this.repositoryItemLookUpEditUserIn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEditUserIn.ValueMember = "UserID";
            // 
            // LSMSUser
            // 
            this.LSMSUser.ElementType = typeof(FixedAssets.Datasource.linq.User);
            this.LSMSUser.KeyExpression = "[UserID]";
            // 
            // XPSCS
            // 
            this.XPSCS.AllowEdit = true;
            this.XPSCS.AllowNew = true;
            this.XPSCS.AllowRemove = true;
            this.XPSCS.DeleteObjectOnRemove = true;
            this.XPSCS.ObjectType = typeof(FixedAssets.Datasource.dsData.TBLSuppliersDataTable);
            this.XPSCS.Session = this.UOW;
            // 
            // TBLSuppliersEditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TBLSuppliersEditorUC";
            this.Size = new System.Drawing.Size(821, 408);
            this.Load += new System.EventHandler(this.RouteEditorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUserIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPSCS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.UnitOfWork UOW;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.Xpo.XPServerCollectionSource XPSCS;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppliersegl;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppliernashat;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierdrebea;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppliermobile;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppliertel;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierfax;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplieraddress;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppliermail;
        private DevExpress.XtraGrid.Columns.GridColumn colUserIn;
        private DevExpress.XtraGrid.Columns.GridColumn coldateIn;
    }
}
