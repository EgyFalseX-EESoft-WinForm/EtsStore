using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FixedAssets.Views.Code
{
    public partial class CompanyUC : DevExpress.XtraEditors.XtraUserControl
    {
        #region - Variables -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(CompanyUC));
        Datasource.dsData.RoleDetialRow _elementRule = null;
        #endregion
        #region - Functions -
        public CompanyUC(Datasource.dsData.RoleDetialRow RuleElement)
        {
            InitializeComponent();
            _elementRule = RuleElement;
            tBLCompanyTableAdapter.Fill(dsData.TBLCompany);
            if (dsData.TBLCompany.Count == 0)
            {
                Datasource.dsData.TBLCompanyRow row = dsData.TBLCompany.NewTBLCompanyRow();
                row.Companyname = row.dep = row.foterleft = row.fotermiddel = row.foterright = string.Empty;
                dsData.TBLCompany.AddTBLCompanyRow(row);
                row.EndEdit();
            }
        }
        public void ActivateRules()
        {
            layoutControl1.Enabled = _elementRule.Updateing;
        }
        #endregion
        #region - EventWhnd -
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tBLCompanyBindingSource.EndEdit();
                tBLCompanyTableAdapter.Update(dsData.TBLCompany);
                MsgDlg.ShowAlert("تم الحفظ", MsgDlg.MessageType.Success, new Form());
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
                Logger.Error(ex);
            }
        }
        #endregion
        
    }
}
