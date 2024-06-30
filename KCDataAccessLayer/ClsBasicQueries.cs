using static KCDataAccessLayer.ClsKCContract.Tables;
using static KCDataAccessLayer.ClsKCContract.Person;
static class ClsBasicQueries
{

    /// <summary>
    /// Query that will get all Contant of a passed table name.
    /// </summary>
    /// <param name="tbl"> Table name </param>
    /// <returns>Query Syntax</returns>
    public static string Select(string tbl) => $"SELECT * FROM {tbl}";

    /// <summary>
    /// Basic Query Syntax that Will Insert Into Specific Table
    /// </summary>
    /// <param name="tbl">Table Name</param>
    /// <returns>Query Syntax</returns>
    public static string InsInto(string tbl) => $"INSERT INTO {tbl}";

    /// <summary>
    /// Basic Query Syntax that Will Update PERSONS Table.
    /// </summary>
    /// <param name="tbl"></param>
    /// <returns>Query Syntax</returns>
    public static string PersonUpdate()
    {
        return $@"UPDATE {PERSONS}
                SET {PERSON_COLUMN_FIRST_NAME} = @firstName, 
                    {PERSON_COLUMN_MID_NAME} = @midName, 
                    {PERSON_COLUMN_LAST_NAME} = @lastName
                WHERE {PERSON_COLUMN_PK} = @id";
    }


    public static string Delete(string tbl, string pkColumnName) => $"DELETE {tbl} WHERE {pkColumnName} =";

    public static string GetLastID(string pkColumnName, string tableName) => $"SELECT MAX({pkColumnName}) FROM {tableName}";
}