namespace Arayuzler;

public class LogManager:Ilogger
{
    private readonly Ilogger _logger;

    public LogManager(Ilogger logger)
    {
        _logger = logger;
    }

    public void writeLog()
    {
        _logger.writeLog(); 
    }
}