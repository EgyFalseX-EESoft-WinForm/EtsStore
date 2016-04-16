namespace FixedAssets.Views.Data.dlg
{
    partial class TBLCheckEditorDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TBLCheckEditorDlg));
            this.dsData = new FixedAssets.Datasource.dsData();
            this.dataLayoutControlMain = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.deChecklagnadate = new DevExpress.XtraEditors.DateEdit();
            this.tbDecisionno = new DevExpress.XtraEditors.TextEdit();
            this.lueBuyorderId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSTBLBuyorder = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemDateEditDMY = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueTwreedOrderId = new DevExpress.XtraEditors.GridLookUpEdit();
            this.LSMSTBLTwreedOrder = new DevExpress.Data.Linq.LinqServerModeSource();
            this.repositoryItemDateEditDMY2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroupMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAssetName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueBuyorderresonId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.demoznadate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueDepertmentId = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProviderMain = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).BeginInit();
            this.dataLayoutControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deChecklagnadate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChecklagnadate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDecisionno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBuyorderId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLBuyorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTwreedOrderId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLTwreedOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBuyorderresonId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoznadate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepertmentId)).BeginInit();
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
            this.dataLayoutControlMain.Controls.Add(this.deChecklagnadate);
            this.dataLayoutControlMain.Controls.Add(this.tbDecisionno);
            this.dataLayoutControlMain.Controls.Add(this.lueBuyorderId);
            this.dataLayoutControlMain.Controls.Add(this.lueTwreedOrderId);
            this.dataLayoutControlMain.DataMember = "TblAssets";
            this.dataLayoutControlMain.DataSource = this.dsData;
            this.dataLayoutControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControlMain.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControlMain.Name = "dataLayoutControlMain";
            this.dataLayoutControlMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1129, 196, 330, 510);
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
            this.dataLayoutControlMain.Size = new System.Drawing.Size(616, 141);
            this.dataLayoutControlMain.TabIndex = 0;
            this.dataLayoutControlMain.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = global::FixedAssets.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(156, 84);
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
            this.btnCancel.Location = new System.Drawing.Point(32, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 24);
            this.btnCancel.StyleController = this.dataLayoutControlMain;
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "الغاء";
            // 
            // deChecklagnadate
            // 
            this.deChecklagnadate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLCheck.Checklagnadate", true));
            this.deChecklagnadate.EditValue = "";
            this.deChecklagnadate.Location = new System.Drawing.Point(32, 32);
            this.deChecklagnadate.Name = "deChecklagnadate";
            this.deChecklagnadate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deChecklagnadate.Properties.Appearance.Options.UseFont = true;
            this.deChecklagnadate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deChecklagnadate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deChecklagnadate.Properties.Mask.EditMask = "";
            this.deChecklagnadate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.deChecklagnadate.Size = new System.Drawing.Size(207, 22);
            this.deChecklagnadate.StyleController = this.dataLayoutControlMain;
            this.deChecklagnadate.TabIndex = 4;
            // 
            // tbDecisionno
            // 
            this.tbDecisionno.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLCheck.Decisionno", true));
            this.tbDecisionno.Location = new System.Drawing.Point(32, 58);
            this.tbDecisionno.Name = "tbDecisionno";
            this.tbDecisionno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbDecisionno.Properties.Appearance.Options.UseFont = true;
            this.tbDecisionno.Properties.Appearance.Options.UseTextOptions = true;
            this.tbDecisionno.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tbDecisionno.Size = new System.Drawing.Size(207, 22);
            this.tbDecisionno.StyleController = this.dataLayoutControlMain;
            this.tbDecisionno.TabIndex = 8;
            // 
            // lueBuyorderId
            // 
            this.lueBuyorderId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLCheck.BuyorderId", true));
            this.lueBuyorderId.Location = new System.Drawing.Point(310, 32);
            this.lueBuyorderId.Name = "lueBuyorderId";
            this.lueBuyorderId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueBuyorderId.Properties.Appearance.Options.UseFont = true;
            this.lueBuyorderId.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueBuyorderId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBuyorderId.Properties.DataSource = this.LSMSTBLBuyorder;
            this.lueBuyorderId.Properties.DisplayMember = "BuyorderId";
            this.lueBuyorderId.Properties.NullText = "";
            this.lueBuyorderId.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDMY});
            this.lueBuyorderId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueBuyorderId.Properties.ValueMember = "BuyorderId";
            this.lueBuyorderId.Properties.View = this.gridLookUpEdit1View;
            this.lueBuyorderId.Size = new System.Drawing.Size(207, 22);
            this.lueBuyorderId.StyleController = this.dataLayoutControlMain;
            this.lueBuyorderId.TabIndex = 6;
            // 
            // LSMSTBLBuyorder
            // 
            this.LSMSTBLBuyorder.ElementType = typeof(FixedAssets.Datasource.linq.TBLBuyorder);
            this.LSMSTBLBuyorder.KeyExpression = "[BuyorderId]";
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
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "رقم";
            this.gridColumn1.FieldName = "BuyorderId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 123;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "تاريخ";
            this.gridColumn2.ColumnEdit = this.repositoryItemDateEditDMY;
            this.gridColumn2.FieldName = "Buyorderdate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 111;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "القسم";
            this.gridColumn3.FieldName = "CdDepertment.Depertment";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 252;
            // 
            // lueTwreedOrderId
            // 
            this.lueTwreedOrderId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsData, "TBLCheck.TwreedOrderId", true));
            this.lueTwreedOrderId.Location = new System.Drawing.Point(310, 58);
            this.lueTwreedOrderId.Name = "lueTwreedOrderId";
            this.lueTwreedOrderId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lueTwreedOrderId.Properties.Appearance.Options.UseFont = true;
            this.lueTwreedOrderId.Properties.Appearance.Options.UseTextOptions = true;
            this.lueTwreedOrderId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lueTwreedOrderId.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueTwreedOrderId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTwreedOrderId.Properties.DataSource = this.LSMSTBLTwreedOrder;
            this.lueTwreedOrderId.Properties.DisplayMember = "TwreedOrderId";
            this.lueTwreedOrderId.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.lueTwreedOrderId.Properties.NullText = "";
            this.lueTwreedOrderId.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDMY2});
            this.lueTwreedOrderId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueTwreedOrderId.Properties.ValueMember = "TwreedOrderId";
            this.lueTwreedOrderId.Properties.View = this.gridView1;
            this.lueTwreedOrderId.Size = new System.Drawing.Size(207, 22);
            this.lueTwreedOrderId.StyleController = this.dataLayoutControlMain;
            this.lueTwreedOrderId.TabIndex = 7;
            // 
            // LSMSTBLTwreedOrder
            // 
            this.LSMSTBLTwreedOrder.ElementType = typeof(FixedAssets.Datasource.linq.TBLTwreedOrder);
            this.LSMSTBLTwreedOrder.KeyExpression = "[TwreedOrderId]";
            // 
            // repositoryItemDateEditDMY2
            // 
            this.repositoryItemDateEditDMY2.AutoHeight = false;
            this.repositoryItemDateEditDMY2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDMY2.DisplayFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditDMY2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY2.EditFormat.FormatString = "d/M/yyyy";
            this.repositoryItemDateEditDMY2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDMY2.Mask.EditMask = "d/M/yyyy";
            this.repositoryItemDateEditDMY2.Name = "repositoryItemDateEditDMY2";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "رقم";
            this.gridColumn4.FieldName = "TwreedOrderId";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "تاريخ";
            this.gridColumn5.ColumnEdit = this.repositoryItemDateEditDMY2;
            this.gridColumn5.FieldName = "TwreedOrderdate";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "المورد";
            this.gridColumn6.FieldName = "TBLSupplier.SupplierName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "رقم العرض";
            this.gridColumn7.FieldName = "Supplierofferno";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "تاريخ التسليم";
            this.gridColumn8.ColumnEdit = this.repositoryItemDateEditDMY2;
            this.gridColumn8.FieldName = "twreddate";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
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
            this.layoutControlGroupMain.Size = new System.Drawing.Size(616, 141);
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
            this.demoznadate,
            this.lueDepertmentId});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(556, 81);
            // 
            // ItemForAssetName
            // 
            this.ItemForAssetName.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForAssetName.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForAssetName.Control = this.deChecklagnadate;
            this.ItemForAssetName.Location = new System.Drawing.Point(0, 0);
            this.ItemForAssetName.Name = "ItemForAssetName";
            this.ItemForAssetName.Size = new System.Drawing.Size(278, 26);
            this.ItemForAssetName.Text = "التاريخ";
            this.ItemForAssetName.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForAssetName.TextSize = new System.Drawing.Size(64, 17);
            // 
            // lueBuyorderresonId
            // 
            this.lueBuyorderresonId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lueBuyorderresonId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lueBuyorderresonId.Control = this.lueTwreedOrderId;
            this.lueBuyorderresonId.Location = new System.Drawing.Point(278, 26);
            this.lueBuyorderresonId.Name = "lueBuyorderresonId";
            this.lueBuyorderresonId.Size = new System.Drawing.Size(278, 26);
            this.lueBuyorderresonId.Text = "جهة التوريد";
            this.lueBuyorderresonId.TextLocation = DevExpress.Utils.Locations.Right;
            this.lueBuyorderresonId.TextSize = new System.Drawing.Size(64, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(124, 29);
            this.layoutControlItem1.Text = "Cancel";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(124, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(432, 29);
            this.layoutControlItem2.Text = "Save";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // demoznadate
            // 
            this.demoznadate.AppearanceItemCaption.Options.UseTextOptions = true;
            this.demoznadate.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.demoznadate.Control = this.tbDecisionno;
            this.demoznadate.Location = new System.Drawing.Point(0, 26);
            this.demoznadate.Name = "demoznadate";
            this.demoznadate.Size = new System.Drawing.Size(278, 26);
            this.demoznadate.Text = "رقم القرار";
            this.demoznadate.TextLocation = DevExpress.Utils.Locations.Right;
            this.demoznadate.TextSize = new System.Drawing.Size(64, 17);
            // 
            // lueDepertmentId
            // 
            this.lueDepertmentId.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lueDepertmentId.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lueDepertmentId.Control = this.lueBuyorderId;
            this.lueDepertmentId.Location = new System.Drawing.Point(278, 0);
            this.lueDepertmentId.Name = "lueDepertmentId";
            this.lueDepertmentId.Size = new System.Drawing.Size(278, 26);
            this.lueDepertmentId.Text = "رقم الطلب";
            this.lueDepertmentId.TextLocation = DevExpress.Utils.Locations.Right;
            this.lueDepertmentId.TextSize = new System.Drawing.Size(64, 17);
            // 
            // TBLCheckEditorDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(616, 141);
            this.Controls.Add(this.dataLayoutControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TBLCheckEditorDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControlMain)).EndInit();
            this.dataLayoutControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deChecklagnadate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChecklagnadate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDecisionno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBuyorderId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLBuyorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTwreedOrderId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSTBLTwreedOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDMY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssetName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueBuyorderresonId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoznadate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDepertmentId)).EndInit();
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
        private DevExpress.XtraEditors.DateEdit deChecklagnadate;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLBuyorder;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSTBLTwreedOrder;
        private DevExpress.XtraEditors.TextEdit tbDecisionno;
        private DevExpress.XtraEditors.GridLookUpEdit lueBuyorderId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit lueTwreedOrderId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDMY2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}