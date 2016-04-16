namespace FixedAssets.Views.Data
{
    partial class TBLReEvaluationDlg
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLReEvaluationDlg));
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.tbAddval = new DevExpress.XtraEditors.TextEdit();
            this.dsData = new FixedAssets.Datasource.dsData();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dedatere = new DevExpress.XtraEditors.DateEdit();
            this.tbMinsval = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFormostandnumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAssetplaceId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAssetStateId = new DevExpress.XtraLayout.LayoutControlItem();
            this.tblReEvaluationTableAdapter = new FixedAssets.Datasource.dsDataTableAdapters.TBLReEvaluationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedatere.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatere.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinsval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormostandnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetplaceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetStateId)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAddval
            // 
            this.tbAddval.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLReEvaluation.addval", true));
            this.tbAddval.EditValue = "";
            this.tbAddval.Location = new System.Drawing.Point(12, 38);
            this.tbAddval.Name = "tbAddval";
            this.tbAddval.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbAddval.Properties.Appearance.Options.UseFont = true;
            this.tbAddval.Properties.Appearance.Options.UseTextOptions = true;
            this.tbAddval.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tbAddval.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.tbAddval.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tbAddval.Size = new System.Drawing.Size(323, 22);
            this.tbAddval.StyleController = this.dataLayoutControlMain;
            this.tbAddval.TabIndex = 10;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.Value1 = 0D;
            this.dxValidationProviderMain.SetValidationRule(this.tbAddval, conditionValidationRule3);
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
            this.dataLayoutControlMain.Controls.Add(this.tbAddval);
            this.dataLayoutControlMain.Controls.Add(this.dedatere);
            this.dataLayoutControlMain.Controls.Add(this.tbMinsval);
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
            this.dataLayoutControlMain.Size = new System.Drawing.Size(414, 135);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = global::FixedAssets.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(100, 90);
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
            this.btnCancel.Location = new System.Drawing.Point(12, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 24);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "الغاء";
            // 
            // dedatere
            // 
            this.dedatere.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLReEvaluation.datere", true));
            this.dedatere.EditValue = null;
            this.dedatere.Location = new System.Drawing.Point(12, 12);
            this.dedatere.Name = "dedatere";
            this.dedatere.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dedatere.Properties.Appearance.Options.UseFont = true;
            this.dedatere.Properties.Appearance.Options.UseTextOptions = true;
            this.dedatere.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dedatere.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedatere.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedatere.Properties.Mask.EditMask = "";
            this.dedatere.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dedatere.Size = new System.Drawing.Size(323, 22);
            this.dedatere.StyleController = this.dataLayoutControlMain;
            this.dedatere.TabIndex = 15;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.dedatere, conditionValidationRule1);
            // 
            // tbMinsval
            // 
            this.tbMinsval.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLReEvaluation.minsval", true));
            this.tbMinsval.EditValue = "";
            this.tbMinsval.Location = new System.Drawing.Point(12, 64);
            this.tbMinsval.Name = "tbMinsval";
            this.tbMinsval.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbMinsval.Properties.Appearance.Options.UseFont = true;
            this.tbMinsval.Properties.Appearance.Options.UseTextOptions = true;
            this.tbMinsval.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tbMinsval.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.tbMinsval.Size = new System.Drawing.Size(323, 22);
            this.tbMinsval.StyleController = this.dataLayoutControlMain;
            this.tbMinsval.TabIndex = 11;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.Value1 = 0D;
            this.dxValidationProviderMain.SetValidationRule(this.tbMinsval, conditionValidationRule2);
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "Root";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(414, 135);
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
            this.layoutControlGroup2.Size = new System.Drawing.Size(394, 115);
            // 
            // ItemFormostandnumber
            // 
            this.ItemFormostandnumber.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemFormostandnumber.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemFormostandnumber.Control = this.tbAddval;
            this.ItemFormostandnumber.Location = new System.Drawing.Point(0, 26);
            this.ItemFormostandnumber.Name = "ItemFormostandnumber";
            this.ItemFormostandnumber.Size = new System.Drawing.Size(394, 26);
            this.ItemFormostandnumber.Text = "قيمة مضافة";
            this.ItemFormostandnumber.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemFormostandnumber.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForAssetplaceId
            // 
            this.ItemForAssetplaceId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAssetplaceId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAssetplaceId.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.ItemForAssetplaceId.Control = this.tbMinsval;
            this.ItemForAssetplaceId.Location = new System.Drawing.Point(0, 52);
            this.ItemForAssetplaceId.Name = "ItemForAssetplaceId";
            this.ItemForAssetplaceId.Size = new System.Drawing.Size(394, 26);
            this.ItemForAssetplaceId.Text = "قيمة مخصومة";
            this.ItemForAssetplaceId.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetplaceId.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(88, 37);
            this.layoutControlItem1.Text = "Cancel";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(88, 78);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(306, 37);
            this.layoutControlItem2.Text = "Save";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForAssetStateId
            // 
            this.ItemForAssetStateId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAssetStateId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAssetStateId.Control = this.dedatere;
            this.ItemForAssetStateId.Location = new System.Drawing.Point(0, 0);
            this.ItemForAssetStateId.Name = "ItemForAssetStateId";
            this.ItemForAssetStateId.Size = new System.Drawing.Size(394, 26);
            this.ItemForAssetStateId.Text = "تاريخ التقييم";
            this.ItemForAssetStateId.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetStateId.TextSize = new System.Drawing.Size(64, 13);
            // 
            // tblReEvaluationTableAdapter
            // 
            this.tblReEvaluationTableAdapter.ClearBeforeFill = true;
            // 
            // TBLReEvaluationDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 135);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLReEvaluationDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dedatere.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatere.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinsval.Properties)).EndInit();
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
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.XtraEditors.TextEdit tbAddval;
        private DevExpress.XtraEditors.DateEdit dedatere;
        private DevExpress.XtraEditors.TextEdit tbMinsval;
        private Datasource.dsDataTableAdapters.TBLReEvaluationTableAdapter tblReEvaluationTableAdapter;
    }
}