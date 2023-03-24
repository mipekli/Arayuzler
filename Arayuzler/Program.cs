namespace Arayuzler;

class Program
{
    static void Main(string[] args)
    {
        FileLogger fileLogger = new FileLogger();
        fileLogger.writeLog();

        DataBaseLogger dataBaseLogger = new DataBaseLogger();
        dataBaseLogger.writeLog();

        SmsLogger smsLogger = new SmsLogger();
        smsLogger.writeLog();

        LogManager logfManager = new LogManager(new FileLogger());
        logfManager.writeLog();
    }
}