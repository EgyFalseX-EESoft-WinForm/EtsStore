using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Data;
using System.Threading.Tasks;

namespace FixedAssets.Views.Qry
{
    public partial class Qry002UC : XtraUserControl
    {
        #region - Var -
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Qry002UC));
        #endregion
        #region - Fun -
        public Qry002UC()
        {
            InitializeComponent();
        }
        Task LoadData()
        {
            return Task.Run(() => 
            {
                try
                {
                    XPSCS.Session.ConnectionString = Properties.Settings.Default.EtsStoreConnectionString;
                    Invoke(new MethodInvoker(() =>
                    {
                        gridControlMain.DataSource = XPSCS;
                        gridViewMain.BestFitColumns();
                    }));
                }
                catch (Exception ex)
                {
                    MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error);
                    Logger.Error(ex.Message, ex);
                }
            });
        }
        #endregion
        #region -  EventWhnd - 
        private async void RouteEditorUC_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Main.WaitWindowFrm));
            await LoadData();
            SplashScreenManager.CloseForm();
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("هل انت متأكد ؟", MsgDlg.MessageType.Question) == DialogResult.No)
                return;
            try
            {
                UOW.DropIdentityMap();
                UOW.DropChanges();
                XPSCS.Reload();
                gridViewMain.RefreshData();
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error);
                Logger.Error(ex.Message, ex);
            }
        }
        #endregion

    }
}
