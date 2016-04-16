using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace FixedAssets.XRep
{
    public partial class xRep004 : DevExpress.XtraReports.UI.XtraReport
    {
        int _m_Id = 0;
        Datasource.dsRepTableAdapters.xRep004ATableAdapter adpA = new Datasource.dsRepTableAdapters.xRep004ATableAdapter();
        Datasource.dsRepTableAdapters.xRep004BTableAdapter adpB = new Datasource.dsRepTableAdapters.xRep004BTableAdapter();

        public xRep004(int id)
        {
            InitializeComponent();

            tblCompanyTableAdapter1.Fill(dsRep1.TBLCompany);
            adpA.Fill(dsRep1.xRep004A, id);
            adpB.Fill(dsRep1.xRep004B, id);

            _m_Id = id;
        }

    }
}
