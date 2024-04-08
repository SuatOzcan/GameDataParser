namespace GameDataParser
{
    internal class Logger
    {
        private readonly string _logFileName;

        public Logger(string v)
        {
            this._logFileName = v;
        }
        public void Log(Exception ex)
        {
            string logMessage;
            DateTime currentDateTime = DateTime.Now;
            logMessage = $"[{currentDateTime} ]Exception message: {ex.Message}, Stack Trace: {ex.StackTrace}\n";
            File.AppendAllText(_logFileName, logMessage);
        }
    }
}