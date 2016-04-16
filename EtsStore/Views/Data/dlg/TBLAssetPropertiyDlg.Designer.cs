namespace FixedAssets.Views.Data
{
    partial class TBLAssetPropertiyDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLAssetPropertiyDlg));
            this.LSMSAssetPropertiyId = new DevExpress.Data.Linq.LinqServerModeSource();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lueAssetPropertiyId = new DevExpress.XtraEditors.LookUpEdit();
            this.dsData = new FixedAssets.Datasource.dsData();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tbPropertiyCountity = new DevExpress.XtraEditors.TextEdit();
            this.tbPropertiyDes = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFormostandnumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAssetplaceId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAssetStateId = new DevExpress.XtraLayout.LayoutControlItem();
            this.tblAssetPropertiyTableAdapter = new FixedAssets.Datasource.dsDataTableAdapters.TBLAssetPropertiyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAssetPropertiyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAssetPropertiyId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPropertiyCountity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPropertiyDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormostandnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetplaceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetStateId)).BeginInit();
            this.SuspendLayout();
            // 
            // LSMSAssetPropertiyId
            // 
            this.LSMSAssetPropertiyId.ElementType = typeof(FixedAssets.Datasource.linq.CdAssetPropertiy);
            this.LSMSAssetPropertiyId.KeyExpression = "[AssetPropertiyId]";
            // 
            // lueAssetPropertiyId
            // 
            this.lueAssetPropertiyId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAssetPropertiy.AssetPropertiyId", true));
            this.lueAssetPropertiyId.Location = new System.Drawing.Point(12, 12);
            this.lueAssetPropertiyId.Name = "lueAssetPropertiyId";
            this.lueAssetPropertiyId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueAssetPropertiyId.Properties.Appearance.Options.UseFont = true;
            this.lueAssetPropertiyId.Properties.Appearance.Options.UseTextOptions = true;
            this.lueAssetPropertiyId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lueAssetPropertiyId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAssetPropertiyId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssetPropertiy", "الاسم", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueAssetPropertiyId.Properties.DataSource = this.LSMSAssetPropertiyId;
            this.lueAssetPropertiyId.Properties.DisplayMember = "AssetPropertiy";
            this.lueAssetPropertiyId.Properties.NullText = "";
            this.lueAssetPropertiyId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueAssetPropertiyId.Properties.ValueMember = "AssetPropertiyId";
            this.lueAssetPropertiyId.Size = new System.Drawing.Size(346, 22);
            this.lueAssetPropertiyId.StyleController = this.dataLayoutControlMain;
            this.lueAssetPropertiyId.TabIndex = 15;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.lueAssetPropertiyId, conditionValidationRule2);
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
            this.dataLayoutControlMain.Controls.Add(this.lueAssetPropertiyId);
            this.dataLayoutControlMain.Controls.Add(this.tbPropertiyCountity);
            this.dataLayoutControlMain.Controls.Add(this.tbPropertiyDes);
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
            this.dataLayoutControlMain.Size = new System.Drawing.Size(414, 337);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = global::FixedAssets.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(100, 301);
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
            this.btnCancel.Location = new System.Drawing.Point(12, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 24);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "الغاء";
            // 
            // tbPropertiyCountity
            // 
            this.tbPropertiyCountity.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAssetPropertiy.PropertiyCountity", true));
            this.tbPropertiyCountity.EditValue = "";
            this.tbPropertiyCountity.Location = new System.Drawing.Point(12, 38);
            this.tbPropertiyCountity.Name = "tbPropertiyCountity";
            this.tbPropertiyCountity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbPropertiyCountity.Properties.Appearance.Options.UseFont = true;
            this.tbPropertiyCountity.Properties.Appearance.Options.UseTextOptions = true;
            this.tbPropertiyCountity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tbPropertiyCountity.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.tbPropertiyCountity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbPropertiyCountity.Size = new System.Drawing.Size(346, 22);
            this.tbPropertiyCountity.StyleController = this.dataLayoutControlMain;
            this.tbPropertiyCountity.TabIndex = 10;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.tbPropertiyCountity, conditionValidationRule1);
            // 
            // tbPropertiyDes
            // 
            this.tbPropertiyDes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAssetPropertiy.PropertiyDes", true));
            this.tbPropertiyDes.EditValue = "";
            this.tbPropertiyDes.Location = new System.Drawing.Point(12, 64);
            this.tbPropertiyDes.Name = "tbPropertiyDes";
            this.tbPropertiyDes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbPropertiyDes.Properties.Appearance.Options.UseFont = true;
            this.tbPropertiyDes.Properties.Appearance.Options.UseTextOptions = true;
            this.tbPropertiyDes.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tbPropertiyDes.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.tbPropertiyDes.Size = new System.Drawing.Size(346, 233);
            this.tbPropertiyDes.StyleController = this.dataLayoutControlMain;
            this.tbPropertiyDes.TabIndex = 11;
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "Root";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(414, 337);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemFormostandnumber,
            this.ItemForAssetplaceId,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.ItemForAssetStateId});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(394, 317);
            // 
            // ItemFormostandnumber
            // 
            this.ItemFormostandnumber.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemFormostandnumber.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemFormostandnumber.Control = this.tbPropertiyCountity;
            this.ItemFormostandnumber.Location = new System.Drawing.Point(0, 26);
            this.ItemFormostandnumber.Name = "ItemFormostandnumber";
            this.ItemFormostandnumber.Size = new System.Drawing.Size(394, 26);
            this.ItemFormostandnumber.Text = "الكمية";
            this.ItemFormostandnumber.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemFormostandnumber.TextSize = new System.Drawing.Size(41, 13);
            // 
            // ItemForAssetplaceId
            // 
            this.ItemForAssetplaceId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAssetplaceId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAssetplaceId.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ItemForAssetplaceId.Control = this.tbPropertiyDes;
            this.ItemForAssetplaceId.Location = new System.Drawing.Point(0, 52);
            this.ItemForAssetplaceId.Name = "ItemForAssetplaceId";
            this.ItemForAssetplaceId.Size = new System.Drawing.Size(394, 237);
            this.ItemForAssetplaceId.Text = "ملاحظات";
            this.ItemForAssetplaceId.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetplaceId.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 289);
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
            this.layoutControlItem2.Location = new System.Drawing.Point(88, 289);
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
            this.ItemForAssetStateId.Control = this.lueAssetPropertiyId;
            this.ItemForAssetStateId.Location = new System.Drawing.Point(0, 0);
            this.ItemForAssetStateId.Name = "ItemForAssetStateId";
            this.ItemForAssetStateId.Size = new System.Drawing.Size(394, 26);
            this.ItemForAssetStateId.Text = "الوصف";
            this.ItemForAssetStateId.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetStateId.TextSize = new System.Drawing.Size(41, 13);
            // 
            // tblAssetPropertiyTableAdapter
            // 
            this.tblAssetPropertiyTableAdapter.ClearBeforeFill = true;
            // 
            // TBLAssetPropertiyDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 337);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLAssetPropertiyDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAssetPropertiyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAssetPropertiyId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbPropertiyCountity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPropertiyDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormostandnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetplaceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetStateId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Datasource.dsData dsData;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemFormostandnumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssetplaceId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssetStateId;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit lueAssetPropertiyId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSAssetPropertiyId;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.XtraEditors.TextEdit tbPropertiyCountity;
        private DevExpress.XtraEditors.MemoEdit tbPropertiyDes;
        private Datasource.dsDataTableAdapters.TBLAssetPropertiyTableAdapter tblAssetPropertiyTableAdapter;
    }
}