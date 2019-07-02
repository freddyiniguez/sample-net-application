using log4net;

namespace Biographies.Helpers
{
    public static class Utils
    {
        /// <summary>
        /// Variables
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        /// <summary>
        /// RegisterException()
        /// This method manages the error logging for any kind of exceptions.
        /// </summary>
        /// <param name="Method"></param>
        /// <param name="Message"></param>
        public static void RegisterException(string Method, string Message)
        {
            logger.Error("Got an exception at " + Method + ". Exception message: " + Message);
        }
    }
}