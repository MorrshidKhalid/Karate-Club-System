using System.Data.SqlClient;
static class ClsDataAccessSettings
{
    public static string ConnectionString = "Server=.;Database=KCDB;User Id=sa;Password=sa123456;";

    /// <summary>
    /// Create Connection object that contain the ConnectionString of your Database.
    /// </summary>
    /// <returns>Connection</returns>
    public static SqlConnection Connection() => new SqlConnection(ConnectionString);
}
