using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAssets.Classes
{
    public static class Core
    {
        //private static NICSQLTools.Data.dsDataTableAdapters.AppExceptionLogTableAdapter aspException = new Data.dsDataTableAdapters.AppExceptionLogTableAdapter();
        public enum ExceptionLevelEnum
        {
            General
        }
        /// <summary>
        /// Log Exception Into Database Table And Local Log File
        /// </summary>
        /// <param name="Logger"></param>
        /// <param name="Ex"></param>
        /// <param name="ExceptionLevel"></param>
        /// <param name="UserIn"></param>
        public static void LogException(log4net.ILog Logger, Exception Ex, ExceptionLevelEnum ExceptionLevel, int UserIn)
        {
            //aspException.Insert(DataManager.defaultInstance.ServerDateTime, Environment.UserName, Ex.Message, Ex.StackTrace, Logger.Logger.Name, ExceptionLevel.ToString(), UserIn);
            Logger.Error(Ex.Message, Ex);

        }
    }
}
