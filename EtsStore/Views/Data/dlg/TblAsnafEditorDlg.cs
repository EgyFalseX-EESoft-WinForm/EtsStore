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
    public partial class TblAsnafEditorDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TblAsnafEditorDlg));
        Datasource.linq.dsLinqDataDataContext dsLinq = new Datasource.linq.dsLinqDataDataContext();
        public TblAsnafEditorDlg(int Id, bool New)
        {
            InitializeComponent();

            LSMSUnitId.QueryableSource = from q in dsLinq.CDUnits select q;
            LSMSAsnaftypeId.QueryableSource = from q in dsLinq.CDAsnaftypes select q;

            if (New)
            {
                Datasource.dsData.TblAsnafRow row = dsData.TblAsnaf.NewTblAsnafRow();
                row.SanfID = Convert.ToInt32(tblAsnafTableAdapter.NewId());
                row.SanfCategoryID = Id;
                row.SanfName = string.Empty;
                row.Sanfbarcode = string.Empty;
                row.ReOrder = 0;
                row.UnitId = -1;
                row.AsnaftypeId = 0;
                row.sanfdes = string.Empty;
                row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
                dsData.TblAsnaf.AddTblAsnafRow(row);
                
            }
            else
                tblAsnafTableAdapter.FillBySanfID(dsData.TblAsnaf, Id);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderMain.Validate())
            {
                dsData.TblAsnaf[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                dsData.TblAsnaf[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                dsData.TblAsnaf[0].EndEdit();
                tblAsnafTableAdapter.Update(dsData.TblAsnaf[0]);
                Close();
            }
            
        }
    }
}