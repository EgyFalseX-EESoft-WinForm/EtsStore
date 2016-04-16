using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace FixedAssets.XRep
{
    public partial class xRep005 : DevExpress.XtraReports.UI.XtraReport
    {
        int _m_Id = 0;
        Datasource.dsRepTableAdapters.xRep005ATableAdapter adpA = new Datasource.dsRepTableAdapters.xRep005ATableAdapter();
        Datasource.dsRepTableAdapters.xRep005BTableAdapter adpB = new Datasource.dsRepTableAdapters.xRep005BTableAdapter();

        public xRep005(int id)
        {
            InitializeComponent();

            tblCompanyTableAdapter1.Fill(dsRep1.TBLCompany);
            adpA.Fill(dsRep1.xRep005A, id);
            adpB.Fill(dsRep1.xRep005B, id);

            _m_Id = id;
        }

    }
}
