namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var databaseConnection = DatabaseConnection.Instance;

            Console.WriteLine("Hello, World!");
        }
    }

    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _lock = new();

        private DatabaseConnection() { }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnection();
                    }

                    return _instance;
                }
            }
        }
    }
}
