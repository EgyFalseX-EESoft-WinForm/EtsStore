namespace FixedAssets.Views.Data
{
    partial class TBLAssetPlaceDlg
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLAssetPlaceDlg));
            this.dsData = new FixedAssets.Datasource.dsData();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dedatep = new DevExpress.XtraEditors.DateEdit();
            this.lueAssetplaceId = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSAssetplaceId = new DevExpress.Data.Linq.LinqServerModeSource();
            this.LSMSEmp = new DevExpress.Data.Linq.LinqServerModeSource();
            this.lueEmpOhda = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAssetsdate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAssetplaceId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpOhda = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dedatep.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAssetplaceId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAssetplaceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpOhda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetsdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetplaceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpOhda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            this.dataLayoutControlMain.Controls.Add(this.dedatep);
            this.dataLayoutControlMain.Controls.Add(this.lueAssetplaceId);
            this.dataLayoutControlMain.Controls.Add(this.lueEmpOhda);
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
            this.dataLayoutControlMain.Size = new System.Drawing.Size(414, 130);
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
            // dedatep
            // 
            this.dedatep.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAssetPlace.datep", true));
            this.dedatep.EditValue = null;
            this.dedatep.Location = new System.Drawing.Point(12, 12);
            this.dedatep.Name = "dedatep";
            this.dedatep.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dedatep.Properties.Appearance.Options.UseFont = true;
            this.dedatep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedatep.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedatep.Size = new System.Drawing.Size(327, 22);
            this.dedatep.StyleController = this.dataLayoutControlMain;
            this.dedatep.TabIndex = 6;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.dedatep, conditionValidationRule1);
            // 
            // lueAssetplaceId
            // 
            this.lueAssetplaceId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAssetPlace.AssetplaceId", true));
            this.lueAssetplaceId.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lueAssetplaceId.Location = new System.Drawing.Point(12, 38);
            this.lueAssetplaceId.Name = "lueAssetplaceId";
            this.lueAssetplaceId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueAssetplaceId.Properties.Appearance.Options.UseFont = true;
            this.lueAssetplaceId.Properties.Appearance.Options.UseTextOptions = true;
            this.lueAssetplaceId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lueAssetplaceId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAssetplaceId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Assetplace", "الاسم", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueAssetplaceId.Properties.DataSource = this.LSMSAssetplaceId;
            this.lueAssetplaceId.Properties.DisplayMember = "Assetplace";
            this.lueAssetplaceId.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.lueAssetplaceId.Properties.NullText = "";
            this.lueAssetplaceId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueAssetplaceId.Properties.ValueMember = "AssetplaceId";
            this.lueAssetplaceId.Size = new System.Drawing.Size(327, 22);
            this.lueAssetplaceId.StyleController = this.dataLayoutControlMain;
            this.lueAssetplaceId.TabIndex = 11;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProviderMain.SetValidationRule(this.lueAssetplaceId, conditionValidationRule2);
            // 
            // LSMSAssetplaceId
            // 
            this.LSMSAssetplaceId.ElementType = typeof(FixedAssets.Datasource.linq.CdAssetplace);
            this.LSMSAssetplaceId.KeyExpression = "[AssetplaceId]";
            // 
            // LSMSEmp
            // 
            this.LSMSEmp.ElementType = typeof(FixedAssets.Datasource.linq.TblEmp);
            this.LSMSEmp.KeyExpression = "[EmpId]";
            // 
            // lueEmpOhda
            // 
            this.lueEmpOhda.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLAssetPlace.EmpOhda", true));
            this.lueEmpOhda.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lueEmpOhda.Location = new System.Drawing.Point(12, 64);
            this.lueEmpOhda.Name = "lueEmpOhda";
            this.lueEmpOhda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueEmpOhda.Properties.Appearance.Options.UseFont = true;
            this.lueEmpOhda.Properties.Appearance.Options.UseTextOptions = true;
            this.lueEmpOhda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lueEmpOhda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpOhda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "الاسم", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueEmpOhda.Properties.DataSource = this.LSMSEmp;
            this.lueEmpOhda.Properties.DisplayMember = "EmpName";
            this.lueEmpOhda.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.lueEmpOhda.Properties.NullText = "";
            this.lueEmpOhda.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueEmpOhda.Properties.ValueMember = "EmpId";
            this.lueEmpOhda.Size = new System.Drawing.Size(327, 22);
            this.lueEmpOhda.StyleController = this.dataLayoutControlMain;
            this.lueEmpOhda.TabIndex = 14;
            // 
            // layoutControlGroupMain
            // 
            this.layoutControlGroupMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupMain.GroupBordersVisible = false;
            this.layoutControlGroupMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroupMain.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupMain.Name = "Root";
            this.layoutControlGroupMain.Size = new System.Drawing.Size(414, 130);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAssetsdate,
            this.ItemForAssetplaceId,
            this.ItemForEmpOhda,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(394, 110);
            // 
            // ItemForAssetsdate
            // 
            this.ItemForAssetsdate.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAssetsdate.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAssetsdate.Control = this.dedatep;
            this.ItemForAssetsdate.Location = new System.Drawing.Point(0, 0);
            this.ItemForAssetsdate.Name = "ItemForAssetsdate";
            this.ItemForAssetsdate.Size = new System.Drawing.Size(394, 26);
            this.ItemForAssetsdate.Text = "التاريخ";
            this.ItemForAssetsdate.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetsdate.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForAssetplaceId
            // 
            this.ItemForAssetplaceId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAssetplaceId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAssetplaceId.Control = this.lueAssetplaceId;
            this.ItemForAssetplaceId.Location = new System.Drawing.Point(0, 26);
            this.ItemForAssetplaceId.Name = "ItemForAssetplaceId";
            this.ItemForAssetplaceId.Size = new System.Drawing.Size(394, 26);
            this.ItemForAssetplaceId.Text = "مكان الاصل";
            this.ItemForAssetplaceId.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetplaceId.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForEmpOhda
            // 
            this.ItemForEmpOhda.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmpOhda.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForEmpOhda.Control = this.lueEmpOhda;
            this.ItemForEmpOhda.Location = new System.Drawing.Point(0, 52);
            this.ItemForEmpOhda.Name = "ItemForEmpOhda";
            this.ItemForEmpOhda.Size = new System.Drawing.Size(394, 26);
            this.ItemForEmpOhda.Text = "موظف العهدة";
            this.ItemForEmpOhda.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForEmpOhda.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(88, 32);
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
            this.layoutControlItem2.Size = new System.Drawing.Size(306, 32);
            this.layoutControlItem2.Text = "Save";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // TBLAssetPlaceDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 130);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLAssetPlaceDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dedatep.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAssetplaceId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSAssetplaceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpOhda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetsdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetplaceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpOhda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Datasource.dsData dsData;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraEditors.DateEdit dedatep;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssetsdate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssetplaceId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpOhda;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit lueAssetplaceId;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSAssetplaceId;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.XtraEditors.LookUpEdit lueEmpOhda;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSEmp;
    }
}