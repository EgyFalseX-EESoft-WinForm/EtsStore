using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FixedAssets.Log
{
    public static  class L4N
    {
        public static string Log4NetFolder = System.Windows.Forms.Application.StartupPath + @"\L4N";
        public static string Log4NetConfigFile = Log4NetFolder + @"\L4N.config";
        public static string Log4NetLogFile = Log4NetFolder + @"\L4N.txt";
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(Program));
        public static void Init()
        {
            if (!Directory.Exists(Log4NetFolder))
                Directory.CreateDirectory(Log4NetFolder);
            if (!File.Exists(Log4NetConfigFile))
            {
                StreamWriter sw = File.CreateText(Log4NetConfigFile);
                sw.Write(Properties.Settings.Default.L4N);
                sw.Close();
            } 
            if (!File.Exists(Log4NetLogFile))
                File.Create(Log4NetLogFile).Close();

            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(Log4NetConfigFile));
        }
    }
}
