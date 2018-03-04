namespace JWT_Web_Api.Core
{
    using System.Data.Entity;

    public class Initializer : MigrateDatabaseToLatestVersion<BooksContext, Configuration>
    {
    }
}