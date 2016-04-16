namespace FixedAssets.Views.Data
{
    partial class TBLEznEdafaEditorDlg
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLEznEdafaEditorDlg));
            this.dsData = new FixedAssets.Datasource.dsData();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.deEznEdafadate = new DevExpress.XtraEditors.DateEdit();
            this.lueStoreId = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSCDStore = new DevExpress.Data.Linq.LinqServerModeSource();
            this.lueChecklagnaID = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSTBLCheck = new DevExpress.Data.Linq.LinqServerModeSource();
            this.cejointocheck = new DevExpress.XtraEditors.CheckEdit();
            this.lueSupplierId = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSTBLSupplier = new DevExpress.Data.Linq.LinqServerModeSource();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAssetName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueDepertmentId = new DevExpress.XtraLayout.LayoutControlItem();
            this.blabla = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueBuyorderresonId = new DevExpress.XtraLayout.LayoutControlItem();
            this.demoznadate = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deEznEdafadate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEznEdafadate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStoreId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueChecklagnaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cejointocheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSupplierId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepertmentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBuyorderresonId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoznadate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.deEznEdafadate);
            this.dataLayoutControlMain.Controls.Add(this.lueStoreId);
            this.dataLayoutControlMain.Controls.Add(this.lueChecklagnaID);
            this.dataLayoutControlMain.Controls.Add(this.cejointocheck);
            this.dataLayoutControlMain.Controls.Add(this.lueSupplierId);
            this.dataLayoutControlMain.DataMember = "TblAssets";
            this.dataLayoutControlMain.DataSource = this.dsData;
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(288, 122, 330, 510);
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dataLayoutControlMain.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dataLayoutControlMain.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.dataLayoutControlMain.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dataLayoutControlMain.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.dataLayoutControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControlMain.Root = this.layoutControlGroupMain;
            this.dataLayoutControlMain.Size = new System.Drawing.Size(616, 166);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = global::FixedAssets.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(167, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(417, 24);
            this.btnSave.StyleController = this.dataLayoutControlMain;
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::FixedAssets.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(32, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 24);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "الغاء";
            // 
            // deEznEdafadate
            // 
            this.deEznEdafadate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLEznEdafa.EznEdafadate", true));
            this.deEznEdafadate.EditValue = "";
            this.deEznEdafadate.Location = new System.Drawing.Point(334, 32);
            this.deEznEdafadate.Name = "deEznEdafadate";
            this.deEznEdafadate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deEznEdafadate.Properties.Appearance.Options.UseFont = true;
            this.deEznEdafadate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEznEdafadate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEznEdafadate.Properties.Mask.EditMask = "";
            this.deEznEdafadate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deEznEdafadate.Size = new System.Drawing.Size(184, 22);
            this.deEznEdafadate.StyleController = this.dataLayoutControlMain;
            this.deEznEdafadate.TabIndex = 4;
            // 
            // lueStoreId
            // 
            this.lueStoreId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLEznEdafa.StoreId", true));
            this.lueStoreId.Location = new System.Drawing.Point(32, 32);
            this.lueStoreId.Name = "lueStoreId";
            this.lueStoreId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueStoreId.Properties.Appearance.Options.UseFont = true;
            this.lueStoreId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStoreId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Storename", "الاسم", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueStoreId.Properties.DataSource = this.LSMSCDStore;
            this.lueStoreId.Properties.DisplayMember = "Storename";
            this.lueStoreId.Properties.NullText = "";
            this.lueStoreId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueStoreId.Properties.ValueMember = "StoreId";
            this.lueStoreId.Size = new System.Drawing.Size(232, 22);
            this.lueStoreId.StyleController = this.dataLayoutControlMain;
            this.lueStoreId.TabIndex = 6;
            // 
            // LSMSCDStore
            // 
            this.LSMSCDStore.ElementType = typeof(FixedAssets.Datasource.linq.CDStore);
            this.LSMSCDStore.KeyExpression = "[StoreId]";
            // 
            // lueChecklagnaID
            // 
            this.lueChecklagnaID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLEznEdafa.ChecklagnaID", true));
            this.lueChecklagnaID.Location = new System.Drawing.Point(32, 58);
            this.lueChecklagnaID.Name = "lueChecklagnaID";
            this.lueChecklagnaID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueChecklagnaID.Properties.Appearance.Options.UseFont = true;
            this.lueChecklagnaID.Properties.Appearance.Options.UseTextOptions = true;
            this.lueChecklagnaID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lueChecklagnaID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueChecklagnaID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChecklagnaID", "رقم", 104, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BuyorderId", "رقم شراء", 76, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Checklagnadate", "تاريخ", 100, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Decisionno", "رقم القرار", 71, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TwreedOrderId", "رقم توريد", 106, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.lueChecklagnaID.Properties.DataSource = this.LSMSTBLCheck;
            this.lueChecklagnaID.Properties.DisplayMember = "ChecklagnaID";
            this.lueChecklagnaID.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.lueChecklagnaID.Properties.NullText = "";
            this.lueChecklagnaID.Properties.ValueMember = "ChecklagnaID";
            this.lueChecklagnaID.Size = new System.Drawing.Size(232, 22);
            this.lueChecklagnaID.StyleController = this.dataLayoutControlMain;
            this.lueChecklagnaID.TabIndex = 7;
            // 
            // LSMSTBLCheck
            // 
            this.LSMSTBLCheck.ElementType = typeof(FixedAssets.Datasource.linq.TBLCheck);
            this.LSMSTBLCheck.KeyExpression = "[ChecklagnaID]";
            // 
            // cejointocheck
            // 
            this.cejointocheck.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLEznEdafa.jointocheck", true));
            this.cejointocheck.Location = new System.Drawing.Point(334, 58);
            this.cejointocheck.Name = "cejointocheck";
            this.cejointocheck.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cejointocheck.Properties.Appearance.Options.UseFont = true;
            this.cejointocheck.Properties.Appearance.Options.UseTextOptions = true;
            this.cejointocheck.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cejointocheck.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.cejointocheck.Properties.Caption = "closeorder";
            this.cejointocheck.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.cejointocheck.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cejointocheck.Size = new System.Drawing.Size(184, 19);
            this.cejointocheck.StyleController = this.dataLayoutControlMain;
            this.cejointocheck.TabIndex = 12;
            this.cejointocheck.CheckedChanged += new System.EventHandler(this.cejointocheck_CheckedChanged);
            // 
            // lueSupplierId
            // 
            this.lueSupplierId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLEznEdafa.SupplierId", true));
            this.lueSupplierId.Location = new System.Drawing.Point(32, 84);
            this.lueSupplierId.Name = "lueSupplierId";
            this.lueSupplierId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueSupplierId.Properties.Appearance.Options.UseFont = true;
            this.lueSupplierId.Properties.Appearance.Options.UseTextOptions = true;
            this.lueSupplierId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lueSupplierId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSupplierId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "الاسم", 94, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Suppliernashat", "نشاط", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueSupplierId.Properties.DataSource = this.LSMSTBLSupplier;
            this.lueSupplierId.Properties.DisplayMember = "SupplierName";
            this.lueSupplierId.Properties.NullText = "";
            this.lueSupplierId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueSupplierId.Properties.ValueMember = "SupplierId";
            this.lueSupplierId.Size = new System.Drawing.Size(486, 22);
            this.lueSupplierId.StyleController = this.dataLayoutControlMain;
            this.lueSupplierId.TabIndex = 8;
            // 
            // LSMSTBLSupplier
            // 
            this.LSMSTBLSupplier.ElementType = typeof(FixedAssets.Datasource.linq.TBLSupplier);
            this.LSMSTBLSupplier.KeyExpression = "[SupplierId]";
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControlGroupMain.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "Root";
            this.layoutControlGroupMain.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 30, 30, 30);
            this.layoutControlGroupMain.Size = new System.Drawing.Size(616, 166);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAssetName,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.lueDepertmentId,
            this.blabla,
            this.lueBuyorderresonId,
            this.demoznadate});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(556, 106);
            // 
            // ItemForAssetName
            // 
            this.ItemForAssetName.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAssetName.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAssetName.Control = this.deEznEdafadate;
            this.ItemForAssetName.Location = new System.Drawing.Point(302, 0);
            this.ItemForAssetName.Name = "ItemForAssetName";
            this.ItemForAssetName.Size = new System.Drawing.Size(254, 26);
            this.ItemForAssetName.Text = "التاريخ";
            this.ItemForAssetName.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetName.TextSize = new System.Drawing.Size(63, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(135, 28);
            this.layoutControlItem1.Text = "Cancel";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(135, 78);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(421, 28);
            this.layoutControlItem2.Text = "Save";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // lueDepertmentId
            // 
            this.lueDepertmentId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lueDepertmentId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lueDepertmentId.Control = this.lueStoreId;
            this.lueDepertmentId.Location = new System.Drawing.Point(0, 0);
            this.lueDepertmentId.Name = "lueDepertmentId";
            this.lueDepertmentId.Size = new System.Drawing.Size(302, 26);
            this.lueDepertmentId.Text = "المخزن";
            this.lueDepertmentId.TextLocation = DevExpress.Utils.Locations.Right;
            this.lueDepertmentId.TextSize = new System.Drawing.Size(63, 17);
            // 
            // blabla
            // 
            this.blabla.AppearanceItemCaption.Options.UseTextOptions = true;
            this.blabla.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.blabla.Control = this.cejointocheck;
            this.blabla.Location = new System.Drawing.Point(302, 26);
            this.blabla.Name = "blabla";
            this.blabla.Size = new System.Drawing.Size(254, 26);
            this.blabla.Text = "لجنة فحص";
            this.blabla.TextLocation = DevExpress.Utils.Locations.Right;
            this.blabla.TextSize = new System.Drawing.Size(63, 17);
            // 
            // lueBuyorderresonId
            // 
            this.lueBuyorderresonId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lueBuyorderresonId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lueBuyorderresonId.Control = this.lueChecklagnaID;
            this.lueBuyorderresonId.Location = new System.Drawing.Point(0, 26);
            this.lueBuyorderresonId.Name = "lueBuyorderresonId";
            this.lueBuyorderresonId.Size = new System.Drawing.Size(302, 26);
            this.lueBuyorderresonId.Text = "رقم اللجنة";
            this.lueBuyorderresonId.TextLocation = DevExpress.Utils.Locations.Right;
            this.lueBuyorderresonId.TextSize = new System.Drawing.Size(63, 17);
            // 
            // demoznadate
            // 
            this.demoznadate.AppearanceItemCaption.Options.UseTextOptions = true;
            this.demoznadate.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.demoznadate.Control = this.lueSupplierId;
            this.demoznadate.Location = new System.Drawing.Point(0, 52);
            this.demoznadate.Name = "demoznadate";
            this.demoznadate.Size = new System.Drawing.Size(556, 26);
            this.demoznadate.Text = "المورد";
            this.demoznadate.TextLocation = DevExpress.Utils.Locations.Right;
            this.demoznadate.TextSize = new System.Drawing.Size(63, 17);
            // 
            // TBLEznEdafaEditorDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(616, 166);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLEznEdafaEditorDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deEznEdafadate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEznEdafadate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStoreId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueChecklagnaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cejointocheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSupplierId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepertmentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBuyorderresonId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoznadate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Datasource.dsData dsData;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssetName;
        private DevExpress.XtraLayout.LayoutControlItem lueDepertmentId;
        private DevExpress.XtraLayout.LayoutControlItem lueBuyorderresonId;
        private DevExpress.XtraLayout.LayoutControlItem demoznadate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.XtraEditors.DateEdit deEznEdafadate;
        private DevExpress.XtraEditors.LookUpEdit lueStoreId;
        private DevExpress.XtraEditors.LookUpEdit lueChecklagnaID;
        private DevExpress.XtraLayout.LayoutControlItem blabla;
        private DevExpress.XtraEditors.CheckEdit cejointocheck;
        private DevExpress.XtraEditors.LookUpEdit lueSupplierId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDStore;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLSupplier;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLCheck;
    }
}