namespace _38LogData;

class Program
{
    public interface ILogger
    {
        public void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            /*File class:
            This class allows us to create, copy, delete, move and open files
            */
            string directoryPath = @"/Users/gamma/C#nutshell/38LogData/Log";
            //If directory path doesn't exsist
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string filePath = System.IO.Path.Combine(directoryPath, "log.txt");
            //File.AppendAllText("log.txt", "Hello Kira" + "\n");
            //This will create a file named log.txt and append Hello World
            File.AppendAllText(filePath, message + "\n");
            System.Console.WriteLine($"Logging Data to File. {message}");

        }
    }
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine($"Logging data to Database. {message}");
        }
    }

    public class Application
    {
        public readonly ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }
        public void DoWork()
        {
            _logger.Log("Do some Work");
            _logger.Log("Work Done");
        }
    }
    static void Main(string[] args)
    {
        ILogger fileLogger = new FileLogger();
        Application app = new Application(fileLogger);
        app.DoWork();
        ILogger dbLogger = new DatabaseLogger();
        app = new Application(dbLogger);
        app.DoWork();

    }
}
