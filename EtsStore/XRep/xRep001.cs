using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace FixedAssets.XRep
{
    public partial class xRep001 : DevExpress.XtraReports.UI.XtraReport
    {
        int _m_Id = 0;
        public xRep001(int id)
        {
            InitializeComponent();

            tblCompanyTableAdapter1.Fill(dsRep1.TBLCompany);
            xRep001ATableAdapter.Fill(dsRep1.xRep001A, id);
            xRep001BTableAdapter1.Fill(dsRep1.xRep001B, id);
            _m_Id = id;
        }

    }
}
