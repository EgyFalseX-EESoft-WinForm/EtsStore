namespace FixedAssets.Views.Data
{
    partial class TBLTBBuyorderdetailsEditorDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLTBBuyorderdetailsEditorDlg));
            this.dsData = new FixedAssets.Datasource.dsData();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.deBuyorderdate = new DevExpress.XtraEditors.DateEdit();
            this.AssetsdateDateEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSDepartment = new DevExpress.Data.Linq.LinqServerModeSource();
            this.asasemonySpinEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSBuyorderresonId = new DevExpress.Data.Linq.LinqServerModeSource();
            this.sumehlakSpinEdit = new DevExpress.XtraEditors.DateEdit();
            this.cecloseorder = new DevExpress.XtraEditors.CheckEdit();
            this.dedateclose = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAssetName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueBuyorderresonId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.blabla = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueDepertmentId = new DevExpress.XtraLayout.LayoutControlItem();
            this.demoznadate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForcontentnumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deBuyorderdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBuyorderdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssetsdateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asasemonySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSBuyorderresonId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumehlakSpinEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumehlakSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecloseorder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedateclose.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedateclose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBuyorderresonId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepertmentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoznadate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcontentnumber)).BeginInit();
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
            this.dataLayoutControlMain.Controls.Add(this.deBuyorderdate);
            this.dataLayoutControlMain.Controls.Add(this.AssetsdateDateEdit);
            this.dataLayoutControlMain.Controls.Add(this.asasemonySpinEdit);
            this.dataLayoutControlMain.Controls.Add(this.sumehlakSpinEdit);
            this.dataLayoutControlMain.Controls.Add(this.cecloseorder);
            this.dataLayoutControlMain.Controls.Add(this.dedateclose);
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
            this.btnSave.Location = new System.Drawing.Point(156, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(428, 24);
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
            this.btnCancel.Size = new System.Drawing.Size(120, 24);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "الغاء";
            // 
            // deBuyorderdate
            // 
            this.deBuyorderdate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLBuyorder.Buyorderdate", true));
            this.deBuyorderdate.EditValue = "";
            this.deBuyorderdate.Location = new System.Drawing.Point(310, 32);
            this.deBuyorderdate.Name = "deBuyorderdate";
            this.deBuyorderdate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deBuyorderdate.Properties.Appearance.Options.UseFont = true;
            this.deBuyorderdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBuyorderdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBuyorderdate.Properties.Mask.EditMask = "";
            this.deBuyorderdate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deBuyorderdate.Size = new System.Drawing.Size(190, 22);
            this.deBuyorderdate.StyleController = this.dataLayoutControlMain;
            this.deBuyorderdate.TabIndex = 4;
            // 
            // AssetsdateDateEdit
            // 
            this.AssetsdateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLBuyorder.DepertmentId", true));
            this.AssetsdateDateEdit.Location = new System.Drawing.Point(32, 32);
            this.AssetsdateDateEdit.Name = "AssetsdateDateEdit";
            this.AssetsdateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AssetsdateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.AssetsdateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AssetsdateDateEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Depertment", "الاسم", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.AssetsdateDateEdit.Properties.DataSource = this.LSMSDepartment;
            this.AssetsdateDateEdit.Properties.DisplayMember = "Depertment";
            this.AssetsdateDateEdit.Properties.NullText = "";
            this.AssetsdateDateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.AssetsdateDateEdit.Properties.ValueMember = "DepertmentId";
            this.AssetsdateDateEdit.Size = new System.Drawing.Size(190, 22);
            this.AssetsdateDateEdit.StyleController = this.dataLayoutControlMain;
            this.AssetsdateDateEdit.TabIndex = 6;
            // 
            // LSMSDepartment
            // 
            this.LSMSDepartment.ElementType = typeof(FixedAssets.Datasource.linq.CdDepertment);
            this.LSMSDepartment.KeyExpression = "[DepertmentId]";
            // 
            // asasemonySpinEdit
            // 
            this.asasemonySpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLBuyorder.BuyorderresonId", true));
            this.asasemonySpinEdit.Location = new System.Drawing.Point(310, 58);
            this.asasemonySpinEdit.Name = "asasemonySpinEdit";
            this.asasemonySpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.asasemonySpinEdit.Properties.Appearance.Options.UseFont = true;
            this.asasemonySpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.asasemonySpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.asasemonySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.asasemonySpinEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Buyorderreson", "الاسم", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.asasemonySpinEdit.Properties.DataSource = this.LSMSBuyorderresonId;
            this.asasemonySpinEdit.Properties.DisplayMember = "Buyorderreson";
            this.asasemonySpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.asasemonySpinEdit.Properties.NullText = "";
            this.asasemonySpinEdit.Properties.ValueMember = "BuyorderresonId";
            this.asasemonySpinEdit.Size = new System.Drawing.Size(190, 22);
            this.asasemonySpinEdit.StyleController = this.dataLayoutControlMain;
            this.asasemonySpinEdit.TabIndex = 7;
            // 
            // LSMSBuyorderresonId
            // 
            this.LSMSBuyorderresonId.ElementType = typeof(FixedAssets.Datasource.linq.CDBuyorderreson);
            this.LSMSBuyorderresonId.KeyExpression = "[BuyorderresonId]";
            // 
            // sumehlakSpinEdit
            // 
            this.sumehlakSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLBuyorder.moznadate", true));
            this.sumehlakSpinEdit.EditValue = null;
            this.sumehlakSpinEdit.Location = new System.Drawing.Point(32, 58);
            this.sumehlakSpinEdit.Name = "sumehlakSpinEdit";
            this.sumehlakSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sumehlakSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.sumehlakSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.sumehlakSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.sumehlakSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sumehlakSpinEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sumehlakSpinEdit.Properties.Mask.EditMask = "";
            this.sumehlakSpinEdit.Size = new System.Drawing.Size(190, 22);
            this.sumehlakSpinEdit.StyleController = this.dataLayoutControlMain;
            this.sumehlakSpinEdit.TabIndex = 8;
            // 
            // cecloseorder
            // 
            this.cecloseorder.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLBuyorder.closeorder", true));
            this.cecloseorder.Location = new System.Drawing.Point(310, 84);
            this.cecloseorder.Name = "cecloseorder";
            this.cecloseorder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cecloseorder.Properties.Appearance.Options.UseFont = true;
            this.cecloseorder.Properties.Appearance.Options.UseTextOptions = true;
            this.cecloseorder.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cecloseorder.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.cecloseorder.Properties.Caption = "closeorder";
            this.cecloseorder.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.cecloseorder.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cecloseorder.Size = new System.Drawing.Size(190, 19);
            this.cecloseorder.StyleController = this.dataLayoutControlMain;
            this.cecloseorder.TabIndex = 12;
            // 
            // dedateclose
            // 
            this.dedateclose.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLBuyorder.dateclose", true));
            this.dedateclose.EditValue = "";
            this.dedateclose.Location = new System.Drawing.Point(32, 84);
            this.dedateclose.Name = "dedateclose";
            this.dedateclose.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dedateclose.Properties.Appearance.Options.UseFont = true;
            this.dedateclose.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedateclose.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedateclose.Properties.Mask.EditMask = "";
            this.dedateclose.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dedateclose.Size = new System.Drawing.Size(190, 22);
            this.dedateclose.StyleController = this.dataLayoutControlMain;
            this.dedateclose.TabIndex = 9;
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
            this.lueBuyorderresonId,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.blabla,
            this.lueDepertmentId,
            this.demoznadate,
            this.ItemForcontentnumber});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(556, 106);
            // 
            // ItemForAssetName
            // 
            this.ItemForAssetName.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAssetName.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAssetName.Control = this.deBuyorderdate;
            this.ItemForAssetName.Location = new System.Drawing.Point(278, 0);
            this.ItemForAssetName.Name = "ItemForAssetName";
            this.ItemForAssetName.Size = new System.Drawing.Size(278, 26);
            this.ItemForAssetName.Text = "التاريخ";
            this.ItemForAssetName.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetName.TextSize = new System.Drawing.Size(81, 17);
            // 
            // lueBuyorderresonId
            // 
            this.lueBuyorderresonId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lueBuyorderresonId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lueBuyorderresonId.Control = this.asasemonySpinEdit;
            this.lueBuyorderresonId.Location = new System.Drawing.Point(278, 26);
            this.lueBuyorderresonId.Name = "lueBuyorderresonId";
            this.lueBuyorderresonId.Size = new System.Drawing.Size(278, 26);
            this.lueBuyorderresonId.Text = "سبب الطلب";
            this.lueBuyorderresonId.TextLocation = DevExpress.Utils.Locations.Right;
            this.lueBuyorderresonId.TextSize = new System.Drawing.Size(81, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(124, 28);
            this.layoutControlItem1.Text = "Cancel";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(124, 78);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(432, 28);
            this.layoutControlItem2.Text = "Save";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // blabla
            // 
            this.blabla.AppearanceItemCaption.Options.UseTextOptions = true;
            this.blabla.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.blabla.Control = this.cecloseorder;
            this.blabla.Location = new System.Drawing.Point(278, 52);
            this.blabla.Name = "blabla";
            this.blabla.Size = new System.Drawing.Size(278, 26);
            this.blabla.Text = "اغلاق الطلب";
            this.blabla.TextLocation = DevExpress.Utils.Locations.Right;
            this.blabla.TextSize = new System.Drawing.Size(81, 17);
            // 
            // lueDepertmentId
            // 
            this.lueDepertmentId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lueDepertmentId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lueDepertmentId.Control = this.AssetsdateDateEdit;
            this.lueDepertmentId.Location = new System.Drawing.Point(0, 0);
            this.lueDepertmentId.Name = "lueDepertmentId";
            this.lueDepertmentId.Size = new System.Drawing.Size(278, 26);
            this.lueDepertmentId.Text = "القسم الطالب";
            this.lueDepertmentId.TextLocation = DevExpress.Utils.Locations.Right;
            this.lueDepertmentId.TextSize = new System.Drawing.Size(81, 17);
            // 
            // demoznadate
            // 
            this.demoznadate.AppearanceItemCaption.Options.UseTextOptions = true;
            this.demoznadate.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.demoznadate.Control = this.sumehlakSpinEdit;
            this.demoznadate.Location = new System.Drawing.Point(0, 26);
            this.demoznadate.Name = "demoznadate";
            this.demoznadate.Size = new System.Drawing.Size(278, 26);
            this.demoznadate.Text = "تاريخ الموازنة";
            this.demoznadate.TextLocation = DevExpress.Utils.Locations.Right;
            this.demoznadate.TextSize = new System.Drawing.Size(81, 17);
            // 
            // ItemForcontentnumber
            // 
            this.ItemForcontentnumber.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForcontentnumber.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForcontentnumber.Control = this.dedateclose;
            this.ItemForcontentnumber.Location = new System.Drawing.Point(0, 52);
            this.ItemForcontentnumber.Name = "ItemForcontentnumber";
            this.ItemForcontentnumber.Size = new System.Drawing.Size(278, 26);
            this.ItemForcontentnumber.Text = "تاريخ الاغلاق";
            this.ItemForcontentnumber.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForcontentnumber.TextSize = new System.Drawing.Size(81, 17);
            // 
            // TBLTBBuyorderdetailsEditorDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(616, 166);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLTBBuyorderdetailsEditorDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deBuyorderdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBuyorderdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssetsdateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asasemonySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSBuyorderresonId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumehlakSpinEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumehlakSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cecloseorder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedateclose.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedateclose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBuyorderresonId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepertmentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoznadate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcontentnumber)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlItem ItemForcontentnumber;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSDepartment;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSBuyorderresonId;
        private DevExpress.XtraEditors.DateEdit deBuyorderdate;
        private DevExpress.XtraEditors.LookUpEdit AssetsdateDateEdit;
        private DevExpress.XtraEditors.LookUpEdit asasemonySpinEdit;
        private DevExpress.XtraEditors.DateEdit sumehlakSpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem blabla;
        private DevExpress.XtraEditors.CheckEdit cecloseorder;
        private DevExpress.XtraEditors.DateEdit dedateclose;
    }
}