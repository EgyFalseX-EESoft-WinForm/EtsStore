using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace FixedAssets.XRep
{
    public partial class xRep002 : DevExpress.XtraReports.UI.XtraReport
    {
        int _m_Id = 0;
        Datasource.dsRepTableAdapters.xRep002ATableAdapter adpA = new Datasource.dsRepTableAdapters.xRep002ATableAdapter();
        Datasource.dsRepTableAdapters.xRep002BTableAdapter adpB = new Datasource.dsRepTableAdapters.xRep002BTableAdapter();

        public xRep002(int id)
        {
            InitializeComponent();

            tblCompanyTableAdapter1.Fill(dsRep1.TBLCompany);
            adpA.Fill(dsRep1.xRep002A, id);
            adpB.Fill(dsRep1.xRep002B, id);

            _m_Id = id;
        }

    }
}
