namespace ExtensionMethods
{
    public interface ILoggerLibrary
    {
        void Log(string message);
        void Log(string message, string messageType);
    }
}