using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace StudentAffairs.Views.Data
{
    public partial class tbldragatEditorFrm_Delete : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(tbldragatEditorFrm_Delete));
        public tbldragatEditorFrm_Delete(int id, int Exam)
        {
            InitializeComponent();
            tbldragatTableAdapter.FillByBeanDragatId(dsData.tbldragat, id);
            if (dsData.tbldragat.Rows.Count == 0)
            {
                Datasource.dsData.tbldragatRow row = dsData.tbldragat.NewtbldragatRow();
                row.BeanDragatId = id;
                row.degmada1 = 0; row.degmada2 = 0;
                row.degmada3 = 0; row.degmada4 = 0;
                row.degmada5 = 0; row.degmada6 = 0;
                row.degmada7 = 0; row.degmada8 = 0;
                row.degmada9 = 0; row.degmada10 = 0;
                row.degmada11 = 0; row.degmada12 = 0;
                row.degmada13 = 0; row.degmada14 = 0;
                row.degmada15 = 0; row.degmada16 = 0;
                row.degmada17 = 0; row.degmada18= 0;
                row.degmada19 = 0; row.degmada20 = 0;
                row.degmada21 = 0; row.degmada22 = 0;
                row.degmada23 = 0; row.degmada24 = 0;
                row.degmada25 = 0;
                dsData.tbldragat.AddtbldragatRow(row);
                row.EndEdit();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            dsData.tbldragat[0].EndEdit();
            tbldragatTableAdapter.Update(dsData.tbldragat);
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbldragatEditorFrm_Load(object sender, EventArgs e)
        {
            

        }
    }
}