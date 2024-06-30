using System.Data;
using System.Data.SqlClient;

namespace KCDataAccessLayer
{
    public class DBLib
    {
        public static void LoadDataToDataTable(ref DataTable dt, SqlCommand command)
        {

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
                dt.Load(reader);

            reader.Close();
        }

        public static void ExecAndGetInsertedID(ref int insID, SqlCommand command)
        {
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    insID = insertedID;
            
        }

        public static void ExecAndGetIntClmValue(ref int clmValue, string clm, SqlCommand command)
        {
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                clmValue = (int)reader[clm];
            else clmValue = 0;

            reader.Close();
        }

        public static void ExecAndGetDecimalClmValue(ref decimal clmValue, string clm, SqlCommand command)
        {
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                clmValue = (decimal)reader[clm];
            else clmValue = 0;

            reader.Close();
        }

    }
}
