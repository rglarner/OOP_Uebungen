using static Logger.Logger;

namespace Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.Log("System gestartet", LogLevel.Info);
            Logger.Log("Speicherplatz knapp", LogLevel.Warn);
            Logger.Log("Verbindung verloren!", LogLevel.Error);
        }
    }
}
