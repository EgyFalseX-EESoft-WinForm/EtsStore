namespace FixedAssets.Views.Code
{
    partial class CompanyUC
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.tbfoterleft = new DevExpress.XtraEditors.TextEdit();
            this.tbfotermiddel = new DevExpress.XtraEditors.TextEdit();
            this.tbfoterright = new DevExpress.XtraEditors.TextEdit();
            this.pelogo = new DevExpress.XtraEditors.PictureEdit();
            this.tbdep = new DevExpress.XtraEditors.TextEdit();
            this.tbCompanyname = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dsData = new FixedAssets.Datasource.dsData();
            this.tBLCompanyBindingSource = new System.Windows.Forms.BindingSource();
            this.tBLCompanyTableAdapter = new FixedAssets.Datasource.dsDataTableAdapters.TBLCompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbfoterleft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfotermiddel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfoterright.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompanyname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCompanyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.tbfoterleft);
            this.layoutControl1.Controls.Add(this.tbfotermiddel);
            this.layoutControl1.Controls.Add(this.tbfoterright);
            this.layoutControl1.Controls.Add(this.pelogo);
            this.layoutControl1.Controls.Add(this.tbdep);
            this.layoutControl1.Controls.Add(this.tbCompanyname);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(823, 211, 250, 350);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(543, 170);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::FixedAssets.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(519, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbfoterleft
            // 
            this.tbfoterleft.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tBLCompanyBindingSource, "foterleft", true));
            this.tbfoterleft.Location = new System.Drawing.Point(190, 108);
            this.tbfoterleft.Name = "tbfoterleft";
            this.tbfoterleft.Size = new System.Drawing.Size(249, 20);
            this.tbfoterleft.StyleController = this.layoutControl1;
            this.tbfoterleft.TabIndex = 9;
            // 
            // tbfotermiddel
            // 
            this.tbfotermiddel.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tBLCompanyBindingSource, "fotermiddel", true));
            this.tbfotermiddel.Location = new System.Drawing.Point(190, 84);
            this.tbfotermiddel.Name = "tbfotermiddel";
            this.tbfotermiddel.Size = new System.Drawing.Size(249, 20);
            this.tbfotermiddel.StyleController = this.layoutControl1;
            this.tbfotermiddel.TabIndex = 8;
            // 
            // tbfoterright
            // 
            this.tbfoterright.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tBLCompanyBindingSource, "foterright", true));
            this.tbfoterright.Location = new System.Drawing.Point(190, 60);
            this.tbfoterright.Name = "tbfoterright";
            this.tbfoterright.Size = new System.Drawing.Size(249, 20);
            this.tbfoterright.StyleController = this.layoutControl1;
            this.tbfoterright.TabIndex = 7;
            // 
            // pelogo
            // 
            this.pelogo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tBLCompanyBindingSource, "logo", true));
            this.pelogo.EditValue = global::FixedAssets.Properties.Resources.EGYCSLogo;
            this.pelogo.Location = new System.Drawing.Point(12, 12);
            this.pelogo.Name = "pelogo";
            this.pelogo.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.pelogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pelogo.Size = new System.Drawing.Size(174, 116);
            this.pelogo.StyleController = this.layoutControl1;
            this.pelogo.TabIndex = 6;
            // 
            // tbdep
            // 
            this.tbdep.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tBLCompanyBindingSource, "dep", true));
            this.tbdep.Location = new System.Drawing.Point(190, 36);
            this.tbdep.Name = "tbdep";
            this.tbdep.Size = new System.Drawing.Size(249, 20);
            this.tbdep.StyleController = this.layoutControl1;
            this.tbdep.TabIndex = 5;
            // 
            // tbCompanyname
            // 
            this.tbCompanyname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tBLCompanyBindingSource, "Companyname", true));
            this.tbCompanyname.Location = new System.Drawing.Point(190, 12);
            this.tbCompanyname.Name = "tbCompanyname";
            this.tbCompanyname.Size = new System.Drawing.Size(249, 20);
            this.tbCompanyname.StyleController = this.layoutControl1;
            this.tbCompanyname.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(543, 170);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.tbCompanyname;
            this.layoutControlItem1.Location = new System.Drawing.Point(178, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem1.Text = "اسم المؤسسة";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.tbdep;
            this.layoutControlItem2.Location = new System.Drawing.Point(178, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem2.Text = "القسم";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.tbfoterright;
            this.layoutControlItem4.Location = new System.Drawing.Point(178, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem4.Text = "يمين اسفل التقارير";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem5.Control = this.tbfotermiddel;
            this.layoutControlItem5.Location = new System.Drawing.Point(178, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem5.Text = "وسط اسفل التقارير";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.pelogo;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(178, 120);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem6.Control = this.tbfoterleft;
            this.layoutControlItem6.Location = new System.Drawing.Point(178, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem6.Text = "يسار";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnSave;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(523, 30);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLCompanyBindingSource
            // 
            this.tBLCompanyBindingSource.DataMember = "TBLCompany";
            this.tBLCompanyBindingSource.DataSource = this.dsData;
            // 
            // tBLCompanyTableAdapter
            // 
            this.tBLCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // CompanyUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "CompanyUC";
            this.Size = new System.Drawing.Size(543, 170);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbfoterleft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfotermiddel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfoterright.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompanyname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCompanyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit tbCompanyname;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit tbdep;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.PictureEdit pelogo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit tbfoterleft;
        private DevExpress.XtraEditors.TextEdit tbfotermiddel;
        private DevExpress.XtraEditors.TextEdit tbfoterright;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.BindingSource tBLCompanyBindingSource;
        private Datasource.dsData dsData;
        private Datasource.dsDataTableAdapters.TBLCompanyTableAdapter tBLCompanyTableAdapter;
    }
}
