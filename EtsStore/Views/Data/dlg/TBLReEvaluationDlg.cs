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
    public partial class TBLReEvaluationDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(TBLReEvaluationDlg));
        public TBLReEvaluationDlg(int ID, bool New)
        {
            InitializeComponent();
            if (New)
            {
                //ID = AssetsID
                Datasource.dsData.TBLReEvaluationRow row = dsData.TBLReEvaluation.NewTBLReEvaluationRow();
                row.AssetsID = ID;
                row.datere = DateTime.Now;
                row.addval = 0; row.minsval = 0;
                row.UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                row.dateIn = Classes.Managers.DataManager.GetServerDatetime;
                dsData.TBLReEvaluation.AddTBLReEvaluationRow(row);
            }
            else
            {
                //ID = ReEvaluationId
                tblReEvaluationTableAdapter.FillByReEvaluationId(dsData.TBLReEvaluation, ID);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dxValidationProviderMain.Validate())
                {
                    if (dsData.TBLReEvaluation[0].addval != 0 && dsData.TBLReEvaluation[0].minsval != 0)
                    {
                        MsgDlg.Show("لا يمكن ادخال قيمه مضافة وقيمة مخصومة في ذات الوقت ", MsgDlg.MessageType.Error);
                        return;
                    }
                    dsData.TBLReEvaluation[0].UserIn = Classes.Managers.UserManager.defaultInstance.User.UserId;
                    dsData.TBLReEvaluation[0].dateIn = Classes.Managers.DataManager.GetServerDatetime;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    dsData.TBLReEvaluation[0].EndEdit();
                    tblReEvaluationTableAdapter.Update(dsData.TBLReEvaluation[0]);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
            }
            
        }
    }
}