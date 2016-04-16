namespace FixedAssets.Views.Data
{
    partial class TblAsnafEditorDlg
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TblAsnafEditorDlg));
            this.LSMSUnitId = new DevExpress.Data.Linq.LinqServerModeSource();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.tbSanfName = new DevExpress.XtraEditors.TextEdit();
            this.dsData = new FixedAssets.Datasource.dsData();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.lueAsnaftypeId = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.luesanfdes = new DevExpress.XtraEditors.LookUpEdit();
            this.tbSanfbarcode = new DevExpress.XtraEditors.TextEdit();
            this.sumehlakSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.tbsanfdes = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAssetName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForasasemony = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForsumehlak = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFormostandnumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAssetStateId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tblAsnafTableAdapter = new FixedAssets.Datasource.dsDataTableAdapters.TblAsnafTableAdapter();
            this.LSMSAsnaftypeId = new DevExpress.Data.Linq.LinqServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUnitId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSanfName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueAsnaftypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luesanfdes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSanfbarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumehlakSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsanfdes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForasasemony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForsumehlak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormostandnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetStateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAsnaftypeId)).BeginInit();
            this.SuspendLayout();
            // 
            // LSMSUnitId
            // 
            this.LSMSUnitId.ElementType = typeof(FixedAssets.Datasource.linq.CDUnit);
            this.LSMSUnitId.KeyExpression = "[UnitId]";
            // 
            // tbSanfName
            // 
            this.tbSanfName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TblAsnaf.SanfName", true));
            this.tbSanfName.EditValue = "";
            this.tbSanfName.Location = new System.Drawing.Point(12, 12);
            this.tbSanfName.Name = "tbSanfName";
            this.tbSanfName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbSanfName.Properties.Appearance.Options.UseFont = true;
            this.tbSanfName.Size = new System.Drawing.Size(333, 22);
            this.tbSanfName.StyleController = this.dataLayoutControlMain;
            this.tbSanfName.TabIndex = 4;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.tbSanfName, conditionValidationRule2);
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataLayoutControlMain
            // 
            this.dataLayoutControlMain.Controls.Add(this.lueAsnaftypeId);
            this.dataLayoutControlMain.Controls.Add(this.btnSave);
            this.dataLayoutControlMain.Controls.Add(this.btnCancel);
            this.dataLayoutControlMain.Controls.Add(this.tbSanfName);
            this.dataLayoutControlMain.Controls.Add(this.luesanfdes);
            this.dataLayoutControlMain.Controls.Add(this.tbSanfbarcode);
            this.dataLayoutControlMain.Controls.Add(this.sumehlakSpinEdit);
            this.dataLayoutControlMain.Controls.Add(this.tbsanfdes);
            this.dataLayoutControlMain.DataMember = "TblAssets";
            this.dataLayoutControlMain.DataSource = this.dsData;
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(789, 140, 330, 510);
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
            this.dataLayoutControlMain.Size = new System.Drawing.Size(414, 241);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // lueAsnaftypeId
            // 
            this.lueAsnaftypeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TblAsnaf.AsnaftypeId", true));
            this.lueAsnaftypeId.Location = new System.Drawing.Point(12, 116);
            this.lueAsnaftypeId.Name = "lueAsnaftypeId";
            this.lueAsnaftypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAsnaftypeId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Asnaftype", "الاسم", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueAsnaftypeId.Properties.DataSource = this.LSMSAsnaftypeId;
            this.lueAsnaftypeId.Properties.DisplayMember = "Asnaftype";
            this.lueAsnaftypeId.Properties.NullText = "";
            this.lueAsnaftypeId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueAsnaftypeId.Properties.ValueMember = "AsnaftypeId";
            this.lueAsnaftypeId.Size = new System.Drawing.Size(333, 20);
            this.lueAsnaftypeId.StyleController = this.dataLayoutControlMain;
            this.lueAsnaftypeId.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = global::FixedAssets.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(100, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(302, 24);
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
            this.btnCancel.Location = new System.Drawing.Point(12, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 24);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "الغاء";
            // 
            // luesanfdes
            // 
            this.luesanfdes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TblAsnaf.UnitId", true));
            this.luesanfdes.Location = new System.Drawing.Point(12, 90);
            this.luesanfdes.Name = "luesanfdes";
            this.luesanfdes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.luesanfdes.Properties.Appearance.Options.UseFont = true;
            this.luesanfdes.Properties.Appearance.Options.UseTextOptions = true;
            this.luesanfdes.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.luesanfdes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luesanfdes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "الاسم", 69, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luesanfdes.Properties.DataSource = this.LSMSUnitId;
            this.luesanfdes.Properties.DisplayMember = "UnitName";
            this.luesanfdes.Properties.NullText = "";
            this.luesanfdes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luesanfdes.Properties.ValueMember = "UnitId";
            this.luesanfdes.Size = new System.Drawing.Size(333, 22);
            this.luesanfdes.StyleController = this.dataLayoutControlMain;
            this.luesanfdes.TabIndex = 15;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.luesanfdes, conditionValidationRule1);
            // 
            // tbSanfbarcode
            // 
            this.tbSanfbarcode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TblAsnaf.Sanfbarcode", true));
            this.tbSanfbarcode.EditValue = "";
            this.tbSanfbarcode.Location = new System.Drawing.Point(12, 38);
            this.tbSanfbarcode.Name = "tbSanfbarcode";
            this.tbSanfbarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbSanfbarcode.Properties.Appearance.Options.UseFont = true;
            this.tbSanfbarcode.Properties.Appearance.Options.UseTextOptions = true;
            this.tbSanfbarcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tbSanfbarcode.Size = new System.Drawing.Size(333, 22);
            this.tbSanfbarcode.StyleController = this.dataLayoutControlMain;
            this.tbSanfbarcode.TabIndex = 7;
            // 
            // sumehlakSpinEdit
            // 
            this.sumehlakSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TblAsnaf.ReOrder", true));
            this.sumehlakSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sumehlakSpinEdit.Location = new System.Drawing.Point(12, 64);
            this.sumehlakSpinEdit.Name = "sumehlakSpinEdit";
            this.sumehlakSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sumehlakSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.sumehlakSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.sumehlakSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.sumehlakSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.sumehlakSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.sumehlakSpinEdit.Size = new System.Drawing.Size(333, 22);
            this.sumehlakSpinEdit.StyleController = this.dataLayoutControlMain;
            this.sumehlakSpinEdit.TabIndex = 8;
            // 
            // tbsanfdes
            // 
            this.tbsanfdes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TblAsnaf.sanfdes", true));
            this.tbsanfdes.EditValue = "";
            this.tbsanfdes.Location = new System.Drawing.Point(12, 140);
            this.tbsanfdes.Name = "tbsanfdes";
            this.tbsanfdes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbsanfdes.Properties.Appearance.Options.UseFont = true;
            this.tbsanfdes.Properties.Appearance.Options.UseTextOptions = true;
            this.tbsanfdes.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tbsanfdes.Size = new System.Drawing.Size(333, 61);
            this.tbsanfdes.StyleController = this.dataLayoutControlMain;
            this.tbsanfdes.TabIndex = 10;
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "Root";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(414, 241);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAssetName,
            this.ItemForasasemony,
            this.ItemForsumehlak,
            this.ItemFormostandnumber,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.ItemForAssetStateId,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(394, 221);
            // 
            // ItemForAssetName
            // 
            this.ItemForAssetName.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAssetName.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAssetName.Control = this.tbSanfName;
            this.ItemForAssetName.Location = new System.Drawing.Point(0, 0);
            this.ItemForAssetName.Name = "ItemForAssetName";
            this.ItemForAssetName.Size = new System.Drawing.Size(394, 26);
            this.ItemForAssetName.Text = "اسم الصنف";
            this.ItemForAssetName.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetName.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForasasemony
            // 
            this.ItemForasasemony.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForasasemony.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForasasemony.Control = this.tbSanfbarcode;
            this.ItemForasasemony.Location = new System.Drawing.Point(0, 26);
            this.ItemForasasemony.Name = "ItemForasasemony";
            this.ItemForasasemony.Size = new System.Drawing.Size(394, 26);
            this.ItemForasasemony.Text = "الباركود";
            this.ItemForasasemony.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForasasemony.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemForsumehlak
            // 
            this.ItemForsumehlak.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForsumehlak.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForsumehlak.Control = this.sumehlakSpinEdit;
            this.ItemForsumehlak.Location = new System.Drawing.Point(0, 52);
            this.ItemForsumehlak.Name = "ItemForsumehlak";
            this.ItemForsumehlak.Size = new System.Drawing.Size(394, 26);
            this.ItemForsumehlak.Text = "حد الطلب";
            this.ItemForsumehlak.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForsumehlak.TextSize = new System.Drawing.Size(54, 13);
            // 
            // ItemFormostandnumber
            // 
            this.ItemFormostandnumber.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemFormostandnumber.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemFormostandnumber.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ItemFormostandnumber.Control = this.tbsanfdes;
            this.ItemFormostandnumber.Location = new System.Drawing.Point(0, 128);
            this.ItemFormostandnumber.Name = "ItemFormostandnumber";
            this.ItemFormostandnumber.Size = new System.Drawing.Size(394, 65);
            this.ItemFormostandnumber.Text = "الوصف";
            this.ItemFormostandnumber.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemFormostandnumber.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 193);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(88, 28);
            this.layoutControlItem1.Text = "Cancel";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(88, 193);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(306, 28);
            this.layoutControlItem2.Text = "Save";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForAssetStateId
            // 
            this.ItemForAssetStateId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAssetStateId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAssetStateId.Control = this.luesanfdes;
            this.ItemForAssetStateId.Location = new System.Drawing.Point(0, 78);
            this.ItemForAssetStateId.Name = "ItemForAssetStateId";
            this.ItemForAssetStateId.Size = new System.Drawing.Size(394, 26);
            this.ItemForAssetStateId.Text = "الوحدة";
            this.ItemForAssetStateId.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetStateId.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.lueAsnaftypeId;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(394, 24);
            this.layoutControlItem3.Text = "نوع الصنف";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(54, 13);
            // 
            // tblAsnafTableAdapter
            // 
            this.tblAsnafTableAdapter.ClearBeforeFill = true;
            // 
            // LSMSAsnaftypeId
            // 
            this.LSMSAsnaftypeId.ElementType = typeof(FixedAssets.Datasource.linq.CDAsnaftype);
            this.LSMSAsnaftypeId.KeyExpression = "[AsnaftypeId]";
            // 
            // TblAsnafEditorDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 241);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TblAsnafEditorDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            ((System.ComponentModel.ISupportInitialize)(this.LSMSUnitId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSanfName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueAsnaftypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luesanfdes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSanfbarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumehlakSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsanfdes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForasasemony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForsumehlak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormostandnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetStateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAsnaftypeId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Datasource.dsData dsData;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraEditors.TextEdit tbSanfName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssetName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForasasemony;
        private DevExpress.XtraLayout.LayoutControlItem ItemForsumehlak;
        private DevExpress.XtraLayout.LayoutControlItem ItemFormostandnumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssetStateId;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit luesanfdes;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSUnitId;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.XtraEditors.TextEdit tbSanfbarcode;
        private DevExpress.XtraEditors.TextEdit sumehlakSpinEdit;
        private DevExpress.XtraEditors.MemoEdit tbsanfdes;
        private Datasource.dsDataTableAdapters.TblAsnafTableAdapter tblAsnafTableAdapter;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSAsnaftypeId;
        private DevExpress.XtraEditors.LookUpEdit lueAsnaftypeId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}