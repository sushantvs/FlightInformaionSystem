using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;

namespace FlightInfoExceptionLibrary
{
    /// <summary>
    /// Exception handling
    /// </summary>
    public class FlightInfoException : ApplicationException
    {
        public FlightInfoException()
        {
            LogError.ErrorLog("Unkown Error occured");
        }

        public FlightInfoException(string errorMessage) : base(errorMessage)
        {
            LogError.ErrorLog(errorMessage);
        }

        public FlightInfoException(string errorMessage, Exception innerException) : base(errorMessage, innerException)
        {
            LogError.ErrorLog(errorMessage + "/" + innerException);
        }
    }

    /// <summary>
    /// Logging Error
    /// </summary>
    internal static class LogError
    {
        public static void ErrorLog(string errorMessage)
        {
            StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["Error"], true);
            writer.Write(errorMessage);
            writer.Flush();
            writer.Close();
        }
    }
}
