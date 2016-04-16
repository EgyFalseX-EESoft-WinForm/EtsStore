namespace FixedAssets.Views.Data
{
    partial class TBLEznSarfEditorDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLEznSarfEditorDlg));
            this.dsData = new FixedAssets.Datasource.dsData();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.deEznSarfafdate = new DevExpress.XtraEditors.DateEdit();
            this.lueStoreId = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSCDStore = new DevExpress.Data.Linq.LinqServerModeSource();
            this.lueDepertmentid = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSCdDepertment = new DevExpress.Data.Linq.LinqServerModeSource();
            this.lueempid = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSTblEmp = new DevExpress.Data.Linq.LinqServerModeSource();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Item0 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Item1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Item2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Item3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deEznSarfafdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEznSarfafdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStoreId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepertmentid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCdDepertment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueempid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTblEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item3)).BeginInit();
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
            this.dataLayoutControlMain.Controls.Add(this.deEznSarfafdate);
            this.dataLayoutControlMain.Controls.Add(this.lueStoreId);
            this.dataLayoutControlMain.Controls.Add(this.lueDepertmentid);
            this.dataLayoutControlMain.Controls.Add(this.lueempid);
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
            this.dataLayoutControlMain.Size = new System.Drawing.Size(616, 140);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = global::FixedAssets.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(167, 84);
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
            this.btnCancel.Location = new System.Drawing.Point(32, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 24);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "الغاء";
            // 
            // deEznSarfafdate
            // 
            this.deEznSarfafdate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLEznSarf.EznSarfafdate", true));
            this.deEznSarfafdate.EditValue = "";
            this.deEznSarfafdate.Location = new System.Drawing.Point(310, 32);
            this.deEznSarfafdate.Name = "deEznSarfafdate";
            this.deEznSarfafdate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deEznSarfafdate.Properties.Appearance.Options.UseFont = true;
            this.deEznSarfafdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEznSarfafdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deEznSarfafdate.Properties.Mask.EditMask = "";
            this.deEznSarfafdate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deEznSarfafdate.Size = new System.Drawing.Size(182, 22);
            this.deEznSarfafdate.StyleController = this.dataLayoutControlMain;
            this.deEznSarfafdate.TabIndex = 4;
            // 
            // lueStoreId
            // 
            this.lueStoreId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLEznSarf.StoreId", true));
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
            this.lueStoreId.Size = new System.Drawing.Size(182, 22);
            this.lueStoreId.StyleController = this.dataLayoutControlMain;
            this.lueStoreId.TabIndex = 6;
            // 
            // LSMSCDStore
            // 
            this.LSMSCDStore.ElementType = typeof(FixedAssets.Datasource.linq.CDStore);
            this.LSMSCDStore.KeyExpression = "[StoreId]";
            // 
            // lueDepertmentid
            // 
            this.lueDepertmentid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLEznSarf.Depertmentid", true));
            this.lueDepertmentid.Location = new System.Drawing.Point(310, 58);
            this.lueDepertmentid.Name = "lueDepertmentid";
            this.lueDepertmentid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueDepertmentid.Properties.Appearance.Options.UseFont = true;
            this.lueDepertmentid.Properties.Appearance.Options.UseTextOptions = true;
            this.lueDepertmentid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lueDepertmentid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDepertmentid.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Depertment", "الاسم", 77, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueDepertmentid.Properties.DataSource = this.LSMSCdDepertment;
            this.lueDepertmentid.Properties.DisplayMember = "Depertment";
            this.lueDepertmentid.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.lueDepertmentid.Properties.NullText = "";
            this.lueDepertmentid.Properties.ValueMember = "DepertmentId";
            this.lueDepertmentid.Size = new System.Drawing.Size(182, 22);
            this.lueDepertmentid.StyleController = this.dataLayoutControlMain;
            this.lueDepertmentid.TabIndex = 7;
            // 
            // LSMSCdDepertment
            // 
            this.LSMSCdDepertment.ElementType = typeof(FixedAssets.Datasource.linq.CdDepertment);
            this.LSMSCdDepertment.KeyExpression = "[DepertmentId]";
            // 
            // lueempid
            // 
            this.lueempid.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLEznSarf.empid", true));
            this.lueempid.Location = new System.Drawing.Point(32, 58);
            this.lueempid.Name = "lueempid";
            this.lueempid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueempid.Properties.Appearance.Options.UseFont = true;
            this.lueempid.Properties.Appearance.Options.UseTextOptions = true;
            this.lueempid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lueempid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueempid.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "الاسم", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueempid.Properties.DataSource = this.LSMSTblEmp;
            this.lueempid.Properties.DisplayMember = "EmpName";
            this.lueempid.Properties.NullText = "";
            this.lueempid.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueempid.Properties.ValueMember = "EmpId";
            this.lueempid.Size = new System.Drawing.Size(182, 22);
            this.lueempid.StyleController = this.dataLayoutControlMain;
            this.lueempid.TabIndex = 8;
            // 
            // LSMSTblEmp
            // 
            this.LSMSTblEmp.ElementType = typeof(FixedAssets.Datasource.linq.TblEmp);
            this.LSMSTblEmp.KeyExpression = "[EmpId]";
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
            this.layoutControlGroupMain.Size = new System.Drawing.Size(616, 140);
            this.layoutControlGroupMain.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Item0,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.Item1,
            this.Item2,
            this.Item3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(556, 80);
            // 
            // Item0
            // 
            this.Item0.AppearanceItemCaption.Options.UseTextOptions = true;
            this.Item0.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Item0.Control = this.deEznSarfafdate;
            this.Item0.Location = new System.Drawing.Point(278, 0);
            this.Item0.Name = "Item0";
            this.Item0.Size = new System.Drawing.Size(278, 26);
            this.Item0.Text = "التاريخ";
            this.Item0.TextLocation = DevExpress.Utils.Locations.Right;
            this.Item0.TextSize = new System.Drawing.Size(89, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 52);
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
            this.layoutControlItem2.Location = new System.Drawing.Point(135, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(421, 28);
            this.layoutControlItem2.Text = "Save";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Item1
            // 
            this.Item1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.Item1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Item1.Control = this.lueStoreId;
            this.Item1.Location = new System.Drawing.Point(0, 0);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(278, 26);
            this.Item1.Text = "المخزن";
            this.Item1.TextLocation = DevExpress.Utils.Locations.Right;
            this.Item1.TextSize = new System.Drawing.Size(89, 17);
            // 
            // Item2
            // 
            this.Item2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.Item2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Item2.Control = this.lueDepertmentid;
            this.Item2.Location = new System.Drawing.Point(278, 26);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(278, 26);
            this.Item2.Text = "القسم او الجهة";
            this.Item2.TextLocation = DevExpress.Utils.Locations.Right;
            this.Item2.TextSize = new System.Drawing.Size(89, 17);
            // 
            // Item3
            // 
            this.Item3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.Item3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Item3.Control = this.lueempid;
            this.Item3.Location = new System.Drawing.Point(0, 26);
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(278, 26);
            this.Item3.Text = "الموظف";
            this.Item3.TextLocation = DevExpress.Utils.Locations.Right;
            this.Item3.TextSize = new System.Drawing.Size(89, 17);
            // 
            // TBLEznSarfEditorDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(616, 140);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLEznSarfEditorDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deEznSarfafdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deEznSarfafdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStoreId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCDStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepertmentid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSCdDepertment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueempid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTblEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProviderMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Datasource.dsData dsData;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControlMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem Item0;
        private DevExpress.XtraLayout.LayoutControlItem Item1;
        private DevExpress.XtraLayout.LayoutControlItem Item2;
        private DevExpress.XtraLayout.LayoutControlItem Item3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProviderMain;
        private DevExpress.XtraEditors.DateEdit deEznSarfafdate;
        private DevExpress.XtraEditors.LookUpEdit lueStoreId;
        private DevExpress.XtraEditors.LookUpEdit lueDepertmentid;
        private DevExpress.XtraEditors.LookUpEdit lueempid;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCDStore;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSCdDepertment;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTblEmp;
    }
}