using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FixedAssets.Views.Data
{
    public partial class TBLAssetOhdaDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLAssetOhdaDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        Datasource.dsDataTableAdapters.TBLAssetOhdaTableAdapter adp = new Datasource.dsDataTableAdapters.TBLAssetOhdaTableAdapter();
        public TBLAssetOhdaDlg(int ID, bool New)
        {
            InitializeComponent();

            LSMSEmp.QueryableSource = from q in dsLinq.TblEmps select q;

            if (New)
            {
                Datasource.dsData.TBLAssetOhdaRow row = dsData.TBLAssetOhda.NewTBLAssetOhdaRow();
                row.AssetsID = ID;
                row.EmoOhdaId = -1;
                row.fromdate = DateTime.Now;
                row.Des = string.Empty;
                row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
                dsData.TBLAssetOhda.AddTBLAssetOhdaRow(row);
            }
            else
                adp.FillByAssetOhdaId(dsData.TBLAssetOhda, ID);
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderMain.Validate())
            {
                dsData.TBLAssetOhda[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TBLAssetOhda[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                dsData.TBLAssetOhda[0].EndEdit();
                adp.Update(dsData.TBLAssetOhda[0]);
                Close();
            }
            
        }
    }
}