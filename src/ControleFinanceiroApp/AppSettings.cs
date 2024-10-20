namespace ControleFinanceiroApp
{
    public class AppSettings
    {
        public static string DatabaseName = "database.db";
        public static string DatabaseDirectory = FileSystem.AppDataDirectory;
        public static string DatabasePath = Path.Combine(DatabaseDirectory, DatabaseName);
    }
}
