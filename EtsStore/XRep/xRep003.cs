using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace FixedAssets.XRep
{
    public partial class xRep003 : DevExpress.XtraReports.UI.XtraReport
    {
        int _m_Id = 0;
        Datasource.dsRepTableAdapters.xRep003ATableAdapter adpA = new Datasource.dsRepTableAdapters.xRep003ATableAdapter();
        Datasource.dsRepTableAdapters.xRep003BTableAdapter adpB = new Datasource.dsRepTableAdapters.xRep003BTableAdapter();
        Datasource.dsRepTableAdapters.xRep003CTableAdapter adpC = new Datasource.dsRepTableAdapters.xRep003CTableAdapter();
        Datasource.dsRepTableAdapters.xRep003DTableAdapter adpD = new Datasource.dsRepTableAdapters.xRep003DTableAdapter();

        public xRep003(int id)
        {
            InitializeComponent();

            tblCompanyTableAdapter1.Fill(dsRep1.TBLCompany);
            adpA.Fill(dsRep1.xRep003A, id);
            adpB.Fill(dsRep1.xRep003B, id);
            adpC.Fill(dsRep1.xRep003C, id);
            adpD.Fill(dsRep1.xRep003D, id);

            _m_Id = id;
        }

    }
}
