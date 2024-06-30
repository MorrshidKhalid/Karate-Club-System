using System.Data.SqlClient;
using static KCDataAccessLayer.ClsKCContract.Tables;
using static KCDataAccessLayer.ClsKCContract.Person;
using static KCDataAccessLayer.ClsKCContract.Members;
using static KCDataAccessLayer.ClsKCContract.Phone;
using static KCDataAccessLayer.ClsKCContract.Instractor;
using static KCDataAccessLayer.ClsKCContract.BektRank;
using static KCDataAccessLayer.ClsKCContract.Payment;
using static KCDataAccessLayer.ClsKCContract.Method;
using static KCDataAccessLayer.ClsKCContract.Subscription;
using static KCDataAccessLayer.ClsKCContract.Fee;
using static KCDataAccessLayer.ClsKCContract.Test;
using static ClsBasicQueries;
using System.Data;
using System;

namespace KCDataAccessLayer
{
    public class ClsKCDatabase
    {

        private static readonly SqlConnection connection = ClsDataAccessSettings.Connection();



        /************ PersonS ************/
        public static bool AddNewPersonToDB(string fName, string mName, string lName, string address, ref int insertedPK)
        {

            string query = $@"{InsInto(PERSONS)}
                            (
                            {PERSON_COLUMN_FIRST_NAME},
                            {PERSON_COLUMN_MID_NAME},
                            {PERSON_COLUMN_LAST_NAME},
                            {PERSON_COLUMN_ADDRESS}
                            )
                            VALUES (@fName, @mName, @lName, @address);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@fName", fName);
            command.Parameters.AddWithValue("@mName", mName);
            command.Parameters.AddWithValue("@lName", lName);
            command.Parameters.AddWithValue("@address", address);

            try
            {
                connection.Open();
                DBLib.ExecAndGetInsertedID(ref insertedPK, command);

            } catch
            {
                insertedPK = -1;
            }
            finally
            {
                connection.Close();
            }

            return insertedPK > 0;
        }

        public static bool UpdatePersonByID(int personID, string fName, string mName, string lName, string address)
        {
            int rowEffected = 0;

            string query = $@"UPDATE {PERSONS} 
                            SET {PERSON_COLUMN_FIRST_NAME} = @fName,
                                {PERSON_COLUMN_MID_NAME} = @mName,
                                {PERSON_COLUMN_LAST_NAME} = @lName,
                                {PERSON_COLUMN_ADDRESS} = @address
                          WHERE {PERSON_COLUMN_PK} = @personID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@fName", fName);
            command.Parameters.AddWithValue("@mName", mName);
            command.Parameters.AddWithValue("@lName", lName);
            command.Parameters.AddWithValue("@address", address);

            try
            {
                connection.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                connection.Close();
            }
            return rowEffected > 0;
        }



        /************ MemberS ************/
        public static bool AddNewMemberToDB(int personID, bool isActive, int lBRID, ref int insertedPK)
        {

            string query = $@"{InsInto(MEMBERS)} 
                            (
                            {MEMBER_COLUMN_PERSON_ID},
                            {MEMBER_COLUMN_IS_ACTIVE},
                            {MEMBER_COLUMN_LBR_ID}
                            )
                            VALUES (@personID, @isActive, @lastBeltRankID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@lastBeltRankID", lBRID);

            try
            {
                connection.Open();
                DBLib.ExecAndGetInsertedID(ref insertedPK, command);

            }
            catch
            {
                insertedPK = -1;
            }
            finally
            {
                connection.Close();
            }

            return insertedPK > 0;
        }

        public static bool DeleteMemberByID(int memberID, int personID)
        {
            int rowEffected = 0;

            string query1 = $@"DELETE {MEMBERS} WHERE {MEMBER_COLUMN_PK} = @memberID";
            string query2 = $@"DELETE {PHONES} WHERE {PHONE_COLUMN_PERSON_ID} = @personID";
            string query3 = $@"DELETE {PERSONS} WHERE {PERSON_COLUMN_PK} = @personID";

            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlCommand command2 = new SqlCommand(query2, connection);
            SqlCommand command3 = new SqlCommand(query3, connection);
            command1.Parameters.AddWithValue("@memberID", memberID);
            command2.Parameters.AddWithValue("@personID", personID);
            command3.Parameters.AddWithValue("@personID", personID);


            try
            {
                connection.Open();
                rowEffected = command1.ExecuteNonQuery();
                rowEffected += command2.ExecuteNonQuery();
                rowEffected += command3.ExecuteNonQuery();
            }
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                connection.Close();
            }

            return rowEffected > 0;
        }


        public static DataTable GetAllMembers()
        {
            DataTable dt = new DataTable();

            string query = $@"SELECT 
                            {MEMBER_COLUMN_PK},
                            {PERSON_COLUMN_FIRST_NAME} + ' ' +
                            {PERSON_COLUMN_MID_NAME} + ' ' +
                            {PERSON_COLUMN_LAST_NAME} AS Name,
                            {PERSON_COLUMN_ADDRESS},
                            {BELT_RANKS}.{BELT_RANK_COLUMN_NAME},
                            {MEMBER_COLUMN_IS_ACTIVE}
                            FROM {MEMBERS}
                            JOIN {PERSONS} ON {MEMBERS}.{MEMBER_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                            JOIN {BELT_RANKS} ON {MEMBERS}.{MEMBER_COLUMN_LBR_ID} = {BELT_RANKS}.{BELT_RANK_COLUMN_PK}";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool GetMemberByID
           (
           int memberID, ref int personID, ref int LastBeltRankID,
           ref string fName, ref string mName,
           ref string lName, ref string address
           )
        {
            bool isFound = false;

            string query = $@"SELECT {PERSONS}.*, {MEMBERS}.*
                              FROM {MEMBERS}
                              JOIN {PERSONS} ON {MEMBERS}.{MEMBER_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              WHERE {MEMBER_COLUMN_PK} = @memberID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@memberID", memberID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    personID = (int)reader[PERSON_COLUMN_PK];
                    fName = (string)reader[PERSON_COLUMN_FIRST_NAME];
                    mName = (string)reader[PERSON_COLUMN_MID_NAME];
                    lName = (string)reader[PERSON_COLUMN_LAST_NAME];
                    address = (string)reader[PERSON_COLUMN_ADDRESS];
                    LastBeltRankID = (int)reader[MEMBER_COLUMN_LBR_ID];

                }
                else isFound = false;

                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool GetMemberByName
            (
            string memberName,
            ref int memberID, ref int personID, ref int LastBeltRankID,
            ref string fName, ref string mName,
            ref string lName, ref string address
            )
        {
            bool isFound = false;

            string query = $@"SELECT {PERSONS}.*, {MEMBERS}.*
                              FROM {MEMBERS}
                              JOIN {PERSONS} ON {MEMBERS}.{MEMBER_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              WHERE {PERSON_COLUMN_FIRST_NAME} + ' ' + 
                                    {PERSON_COLUMN_MID_NAME} + ' ' + 
                                    {PERSON_COLUMN_LAST_NAME} = @memberName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@memberName", memberName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    memberID = (int)reader[MEMBER_COLUMN_PK];
                    personID = (int)reader[PERSON_COLUMN_PK];
                    fName = (string)reader[PERSON_COLUMN_FIRST_NAME];
                    mName = (string)reader[PERSON_COLUMN_MID_NAME];
                    lName = (string)reader[PERSON_COLUMN_LAST_NAME];
                    address = (string)reader[PERSON_COLUMN_ADDRESS];
                    LastBeltRankID = (int)reader[MEMBER_COLUMN_LBR_ID];

                } else isFound = false;

                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        /************ InstractorS ************/
        public static bool AddNewInstractorToDB(int personID)
        {
            int rowEffected = 0;

            string query = $@"{InsInto(INSTRACTORS)} ({INSTRACTOR_COLUMN_PERSON_ID}) values(@personID)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                connection.Close();
            }


            return rowEffected > 0;
        }

        public static bool DeleteInstractorByID(int instractorID, int personID)
        {
            int rowEffected = 0;

            string query1 = $@"DELETE {INSTRACTORS} WHERE {INSTRACTOR_COLUMN_PK} = @instractorID";
            string query2 = $@"DELETE {PHONES} WHERE {PHONE_COLUMN_PERSON_ID} = @personID";
            string query3 = $@"DELETE {PERSONS} WHERE {PERSON_COLUMN_PK} = @personID";

            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlCommand command2 = new SqlCommand(query2, connection);
            SqlCommand command3 = new SqlCommand(query3, connection);
            command1.Parameters.AddWithValue("@instractorID", instractorID);
            command2.Parameters.AddWithValue("@personID", personID);
            command3.Parameters.AddWithValue("@personID", personID);


            try
            {
                connection.Open();
                rowEffected = command1.ExecuteNonQuery();
                rowEffected += command2.ExecuteNonQuery();
                rowEffected += command3.ExecuteNonQuery();
            }
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                connection.Close();
            }

            return rowEffected > 0;
        }

        public static DataTable GetAllInstractor()
        {
            DataTable dt = new DataTable();

            string query = $@"SELECT 
                            {INSTRACTORS}.{INSTRACTOR_COLUMN_PK},
                            {PERSON_COLUMN_FIRST_NAME} + ' ' +
                            {PERSON_COLUMN_MID_NAME} + ' ' +
                            {PERSON_COLUMN_LAST_NAME} AS Name,
                            {PERSON_COLUMN_ADDRESS}
                            FROM {INSTRACTORS}
                            JOIN {PERSONS} ON {INSTRACTORS}.{INSTRACTOR_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool GetInstractorByID
            (
           ref int instractorID, ref int personID, string name,
           ref string fName, ref string mName,
           ref string lName, ref string address
            )
        {
            bool isFound = false;

            string query = $@"SELECT {PERSONS}.*, {INSTRACTORS}.*
                              FROM {INSTRACTORS}
                              JOIN {PERSONS} ON {INSTRACTORS}.{INSTRACTOR_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              WHERE {PERSON_COLUMN_FIRST_NAME} + ' ' +
                                    {PERSON_COLUMN_MID_NAME} + ' ' + 
                                    {PERSON_COLUMN_LAST_NAME} = @name";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    instractorID = (int)reader[INSTRACTOR_COLUMN_PK];
                    personID = (int)reader[PERSON_COLUMN_PK];
                    fName = (string)reader[PERSON_COLUMN_FIRST_NAME];
                    mName = (string)reader[PERSON_COLUMN_MID_NAME];
                    lName = (string)reader[PERSON_COLUMN_LAST_NAME];
                    address = (string)reader[PERSON_COLUMN_ADDRESS];

                }
                else isFound = false;

                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        public static bool GetInstractorByID
            (
           int instractor, ref int personID,
           ref string fName, ref string mName,
           ref string lName, ref string address
            )
        {
            bool isFound = false;

            string query = $@"SELECT {PERSONS}.*, {INSTRACTORS}.*
                              FROM {INSTRACTORS}
                              JOIN {PERSONS} ON {INSTRACTORS}.{INSTRACTOR_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              WHERE {INSTRACTOR_COLUMN_PK} = @instractor";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@instractor", instractor);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    personID = (int)reader[PERSON_COLUMN_PK];
                    fName = (string)reader[PERSON_COLUMN_FIRST_NAME];
                    mName = (string)reader[PERSON_COLUMN_MID_NAME];
                    lName = (string)reader[PERSON_COLUMN_LAST_NAME];
                    address = (string)reader[PERSON_COLUMN_ADDRESS];

                }
                else isFound = false;

                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        /************ Phones ************/
        public static bool AddNewPhoneToDB(int personID, string number)
        {
            int rowEffected = 0;

            string query = $@"{InsInto(PHONES)} 
                              ({PHONE_COLUMN_PERSON_ID},
                              {PHONE_COLUMN_NUMBER}) 
                              VALUES(@personID, @number)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@number", number);

            try
            {
                connection.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                connection.Close();
            }

            return rowEffected > 0;
        }

        public static bool DeletePhoneByID(int phoneID)
        {
            int rowEffected = 0;

            string query = $@"DELETE {PHONES} WHERE {PHONE_COLUMN_PK} = @phoneID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@phoneID", phoneID);

            try
            {
                connection.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                connection.Close();
            }

            return rowEffected > 0;
        }

        public static DataTable GetPersonPhones(int personID)
        {
            DataTable dt = new DataTable();


            string query = $@"SELECT 
                              {PHONE_COLUMN_PK}, {PHONE_COLUMN_NUMBER}
                              FROM {PHONES}
                              WHERE {PHONE_COLUMN_PERSON_ID} = @personID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


        /************ METHODS ************/
        public static bool AddNewPaymentMethod(string methodName)
        {
            int rowEffected = 0;

            string query = $@"{InsInto(PAYMENT_METHODS)} 
                              ({PAYMENT_METHOD_COLUMN_METHOD})
                              VALUES (@methodName)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@methodName", methodName);

            try
            {
                connection.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch
            {
                rowEffected = -1;
            } 
            finally
            {
                connection.Close();
            }

            return rowEffected > 0;

        }
        public static DataTable GetAllPaymentMethods()
        {
            DataTable dt = new DataTable();

            string query = $"{Select(PAYMENT_METHODS)}";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            } 
            catch
            {

            } 
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static int GetMethodIDByName(string method)
        {
            int methodID = 0;
            string query = $@"SELECT {PAYMENT_METHOD_COLUMN_PK}
                            FROM {PAYMENT_METHODS}
                            WHERE {PAYMENT_METHOD_COLUMN_METHOD} = @method";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@method", method);

            try
            {
                connection.Open();
                DBLib.ExecAndGetIntClmValue(ref methodID, PAYMENT_METHOD_COLUMN_PK, command);

            } 
            catch
            {
                methodID = -1;
            } 
            finally
            {
                connection.Close();
            }

            return methodID;
        }

        public static bool GetMethodIDByID(int methodID, ref string methodName)
        {
            bool isFound = false;

            string query = $@"{Select(PAYMENT_METHODS)}
                            WHERE {PAYMENT_METHOD_COLUMN_PK} = @methodID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@methodID", methodID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    methodName = (string)reader[PAYMENT_METHOD_COLUMN_METHOD];
                }
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool UpdateMethod(int methodID, string newName)
        {
            int rowEffected = 0;

            string query = $@"UPDATE {PAYMENT_METHODS} 
                              SET {PAYMENT_METHOD_COLUMN_METHOD} = @newName
                              WHERE {PAYMENT_METHOD_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@newName", newName);
            command.Parameters.AddWithValue("@id", methodID);

            try
            {
                connection.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                connection.Close();

            }

            return rowEffected > 0;
        }



        /************ PAYMENTS ************/
        public static bool AddNewPaymentToDB(int methodID, int memberID, decimal amount, DateTime date, string note, ref int insertedPK)
        {

            string query = $@"{InsInto(PAYMENTS)}
                            (
                            {PAYMENT_COLUMN_METHOD_ID},
                            {PAYMENT_COLUMN_MEMBER_ID},
                            {PAYMENT_COLUMN_AMOUNT},
                            {PAYMENT_COLUMN_DATE},
                            {PAYMENT_COLUMN_NOTE}
                            )
                            VALUES (@methodID, @memberID, @amount, @date, @note);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@methodID", methodID);
            command.Parameters.AddWithValue("@memberID", memberID);
            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@note", note);

            try
            {
                connection.Open();
                DBLib.ExecAndGetInsertedID(ref insertedPK, command);
            }
            catch
            {
                insertedPK = -1;
            }
            finally
            {
                connection.Close();
            }

            return insertedPK > 0;
        }

        public static DataTable GetPaymentHistoryByMemberID(int memberID)
        {
            DataTable dt = new DataTable();

            string query = $@"SELECT 
                              {SUBSCRIPTION_COLUMN_PK},
                              {PERSON_COLUMN_FIRST_NAME} + ' ' +
                              {PERSON_COLUMN_MID_NAME} + ' ' +
                              {PERSON_COLUMN_LAST_NAME} AS Name,
                              {SUBSCRIPTION_COLUMN_S_DATE},
                              {SUBSCRIPTION_COLUMN_E_DATE},
                              {SUBSCRIPTION_COLUMN_FEE},
                              {PAYMENT_COLUMN_AMOUNT},
                              {PAYMENT_METHOD_COLUMN_METHOD},
                              {SUBSCRIPTION_COLUMN_FEE} - {PAYMENT_COLUMN_AMOUNT} AS Remaining
                              FROM {SUBSCRIPTIONS}
                              JOIN {MEMBERS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_MEMBER_ID} = {MEMBERS}.{MEMBER_COLUMN_PK}
                              JOIN {PERSONS} ON {MEMBERS}.{MEMBER_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              JOIN {PAYMENTS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_PAYMENT_ID} = {PAYMENTS}.{PAYMENT_COLUMN_PK}
                              JOIN {PAYMENT_METHODS} ON {PAYMENTS}.{PAYMENT_COLUMN_METHOD_ID} = {PAYMENT_METHODS}.{PAYMENT_METHOD_COLUMN_PK}
                              WHERE {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_MEMBER_ID} = @memberID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@memberID", memberID);
            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            } 
            catch
            {

            } 
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable GetPaymentHistoryByMemberIDAndDateAndMethod(int memberID, DateTime from, DateTime to, int methodID)
        {
            DataTable dt = new DataTable();

            string query = $@"SELECT 
                              {SUBSCRIPTION_COLUMN_PK},
                              {PERSON_COLUMN_FIRST_NAME} + ' ' +
                              {PERSON_COLUMN_MID_NAME} + ' ' +
                              {PERSON_COLUMN_LAST_NAME} AS Name,
                              {SUBSCRIPTION_COLUMN_S_DATE},
                              {SUBSCRIPTION_COLUMN_E_DATE},
                              {SUBSCRIPTION_COLUMN_FEE},
                              {PAYMENT_COLUMN_AMOUNT},
                              {PAYMENT_METHOD_COLUMN_METHOD},
                              {SUBSCRIPTION_COLUMN_FEE} - {PAYMENT_COLUMN_AMOUNT} AS Remaining
                              FROM {SUBSCRIPTIONS}
                              JOIN {MEMBERS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_MEMBER_ID} = {MEMBERS}.{MEMBER_COLUMN_PK}
                              JOIN {PERSONS} ON {MEMBERS}.{MEMBER_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              JOIN {PAYMENTS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_PAYMENT_ID} = {PAYMENTS}.{PAYMENT_COLUMN_PK}
                              JOIN {PAYMENT_METHODS} ON {PAYMENTS}.{PAYMENT_COLUMN_METHOD_ID} = {PAYMENT_METHODS}.{PAYMENT_METHOD_COLUMN_PK}
                              WHERE {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_MEMBER_ID} = @memberID
                              AND {SUBSCRIPTION_COLUMN_S_DATE} BETWEEN @from and @to
                              AND {PAYMENTS}.{PAYMENT_COLUMN_METHOD_ID} = @methodID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@memberID", memberID);
            command.Parameters.AddWithValue("@from", from);
            command.Parameters.AddWithValue("@to", to);
            command.Parameters.AddWithValue("@methodID", methodID);

            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }



        /************ Belt RankS ************/
        public static bool GetBeltRankByID(int beltRankID, ref string rankName, ref decimal testFee)
        {
            bool isFound = false;

            string query = $@"{Select(BELT_RANKS)} WHERE {BELT_RANK_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", beltRankID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    rankName = (string)reader[BELT_RANK_COLUMN_NAME];
                    testFee = (decimal)reader[BELT_RANK_COLUMN_TEST_FEE];

                } else isFound = false;
            } 
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }



            return isFound;
        }

        public static bool GetBeltRankByName(ref int beltRankID, string rankName, ref decimal testFee)
        {
            bool isFound = false;

            string query = $@"{Select(BELT_RANKS)} WHERE {BELT_RANK_COLUMN_NAME} = @name";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", rankName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    beltRankID = (int)reader[BELT_RANK_COLUMN_PK];
                    testFee = (decimal)reader[BELT_RANK_COLUMN_TEST_FEE];

                }
                else isFound = false;
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }



            return isFound;
        }

        public static short GetBeltRankIDByName(string beltRankName)
        {
            int beltRankID = 0;

            string query = $@"SELECT {BELT_RANK_COLUMN_PK}
                              FROM {BELT_RANKS} 
                              WHERE {BELT_RANK_COLUMN_NAME} = @name";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", beltRankName);

            try
            {
                connection.Open();
                DBLib.ExecAndGetIntClmValue(ref beltRankID, BELT_RANK_COLUMN_PK, command);
            } 
            catch
            {
                beltRankID = -1;
            } 
            finally
            {
                connection.Close();
            }


            return (short)beltRankID;
        }

        public static DataTable GetAllBeltRanks()
        {
            DataTable dt = new DataTable();

            string query = $"{Select(BELT_RANKS)}";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            } 
            catch
            {

            } 
            finally
            {
                connection.Close();
            }


            return dt;
        }

        public static bool UpdateBeltRankFee(int beltRankID, decimal newFee)
        {
            int rowEffected = 0;

            string query = $@"UPDATE {BELT_RANKS}
                            SET {BELT_RANK_COLUMN_TEST_FEE} = @newFee
                            WHERE {BELT_RANK_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", beltRankID);
            command.Parameters.AddWithValue("@newFee", newFee);

            try
            {
                connection.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch
            {
                rowEffected = -1;
            } 
            finally
            {
                connection.Close();
            }

            return rowEffected > 0;
        }



        /************ SUBSCRIPTIONS ************/
        public static bool AddNewSubscriptionToDB
            (int memberID, int paymentID, decimal fee, DateTime startDate, DateTime endDate)
        {
            int rowEffected = 0;

            string query = $@"{InsInto(SUBSCRIPTIONS)}
                           ({SUBSCRIPTION_COLUMN_MEMBER_ID}, 
                            {SUBSCRIPTION_COLUMN_PAYMENT_ID}, 
                            {SUBSCRIPTION_COLUMN_FEE}, 
                            {SUBSCRIPTION_COLUMN_S_DATE}, 
                            {SUBSCRIPTION_COLUMN_E_DATE})
                            values
                            (@memberID, @paymentID, @fee, @startDate, @endDate)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@memberID", memberID);
            command.Parameters.AddWithValue("@paymentID", paymentID);
            command.Parameters.AddWithValue("@fee", fee);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);

            try
            {
                connection.Open();
                rowEffected = command.ExecuteNonQuery();
            }
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                connection.Close();
            }

            return rowEffected > 0;
        }


        public static DataTable FindSubscriptionByID(int subscriptionID)
        {
            DataTable dt = new DataTable();

            string query = $@"SELECT {SUBSCRIPTION_COLUMN_PK},
                              {PERSON_COLUMN_FIRST_NAME} + ' ' +
                              {PERSON_COLUMN_MID_NAME} + ' ' + 
                              {PERSON_COLUMN_LAST_NAME} as Name,
                              {SUBSCRIPTION_COLUMN_FEE},
                              {PAYMENT_COLUMN_AMOUNT} as Paid,
                              {PAYMENT_METHOD_COLUMN_METHOD},
                              {SUBSCRIPTION_COLUMN_S_DATE},
                              {SUBSCRIPTION_COLUMN_E_DATE}
                              FROM {SUBSCRIPTIONS}
                              JOIN {MEMBERS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_MEMBER_ID} = {MEMBERS}.{MEMBER_COLUMN_PK}
                              JOIN {PERSONS} ON {MEMBERS}.{MEMBER_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              JOIN {PAYMENTS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_PAYMENT_ID} = {PAYMENTS}.{PAYMENT_COLUMN_PK}
                              JOIN {PAYMENT_METHODS} ON {PAYMENTS}.{PAYMENT_COLUMN_METHOD_ID} = {PAYMENT_METHODS}.{PAYMENT_METHOD_COLUMN_PK}
                              WHERE {SUBSCRIPTION_COLUMN_PK} = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", subscriptionID);


            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable GetAllSubscription()
        {
            DataTable dt = new DataTable();


            string query = $@"SELECT {SUBSCRIPTION_COLUMN_PK},
                              {PERSON_COLUMN_FIRST_NAME} + ' ' +
                              {PERSON_COLUMN_MID_NAME} + ' ' + 
                              {PERSON_COLUMN_LAST_NAME} as Name,
                              {SUBSCRIPTION_COLUMN_FEE},
                              {PAYMENT_COLUMN_AMOUNT} as Paid,
                              {PAYMENT_METHOD_COLUMN_METHOD},
                              {SUBSCRIPTION_COLUMN_S_DATE},
                              {SUBSCRIPTION_COLUMN_E_DATE}
                              FROM {SUBSCRIPTIONS}
                              JOIN {MEMBERS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_MEMBER_ID} = {MEMBERS}.{MEMBER_COLUMN_PK}
                              JOIN {PERSONS} ON {MEMBERS}.{MEMBER_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              JOIN {PAYMENTS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_PAYMENT_ID} = {PAYMENTS}.{PAYMENT_COLUMN_PK}
                              JOIN {PAYMENT_METHODS} ON {PAYMENTS}.{PAYMENT_COLUMN_METHOD_ID} = {PAYMENT_METHODS}.{PAYMENT_METHOD_COLUMN_PK}";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static DataTable GetSubscriptionByMember(DateTime startDate, DateTime endDate, string member)
        {
            DataTable dt = new DataTable();


            string query = $@"SELECT {SUBSCRIPTION_COLUMN_PK},
                              {PERSON_COLUMN_FIRST_NAME} + ' ' +
                              {PERSON_COLUMN_MID_NAME} + ' ' + 
                              {PERSON_COLUMN_LAST_NAME} as Name,
                              {SUBSCRIPTION_COLUMN_FEE},
                              {PAYMENT_COLUMN_AMOUNT} as Paid,
                              {PAYMENT_METHOD_COLUMN_METHOD},
                              {SUBSCRIPTION_COLUMN_S_DATE},
                              {SUBSCRIPTION_COLUMN_E_DATE}
                              FROM {SUBSCRIPTIONS}
                              JOIN {MEMBERS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_MEMBER_ID} = {MEMBERS}.{MEMBER_COLUMN_PK}
                              JOIN {PERSONS} ON {MEMBERS}.{MEMBER_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              JOIN {PAYMENTS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_PAYMENT_ID} = {PAYMENTS}.{PAYMENT_COLUMN_PK}
                              JOIN {PAYMENT_METHODS} ON {PAYMENTS}.{PAYMENT_COLUMN_METHOD_ID} = {PAYMENT_METHODS}.{PAYMENT_METHOD_COLUMN_PK}
                              WHERE {SUBSCRIPTION_COLUMN_S_DATE}
                              BETWEEN @startDate AND @endDate
                              AND {PERSON_COLUMN_FIRST_NAME} + ' ' +
                              {PERSON_COLUMN_MID_NAME} + ' ' + 
                              {PERSON_COLUMN_LAST_NAME} = @member";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);
            command.Parameters.AddWithValue("@member", member);

            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static DataTable GetSubscriptionByDateAllMethods(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();


            string query = $@"SELECT {SUBSCRIPTION_COLUMN_PK},
                              {PERSON_COLUMN_FIRST_NAME} + ' ' +
                              {PERSON_COLUMN_MID_NAME} + ' ' + 
                              {PERSON_COLUMN_LAST_NAME} as Name,
                              {SUBSCRIPTION_COLUMN_FEE},
                              {PAYMENT_COLUMN_AMOUNT} as Paid,
                              {PAYMENT_METHOD_COLUMN_METHOD},
                              {SUBSCRIPTION_COLUMN_S_DATE},
                              {SUBSCRIPTION_COLUMN_E_DATE}
                              FROM {SUBSCRIPTIONS}
                              JOIN {MEMBERS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_MEMBER_ID} = {MEMBERS}.{MEMBER_COLUMN_PK}
                              JOIN {PERSONS} ON {MEMBERS}.{MEMBER_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              JOIN {PAYMENTS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_PAYMENT_ID} = {PAYMENTS}.{PAYMENT_COLUMN_PK}
                              JOIN {PAYMENT_METHODS} ON {PAYMENTS}.{PAYMENT_COLUMN_METHOD_ID} = {PAYMENT_METHODS}.{PAYMENT_METHOD_COLUMN_PK}
                              WHERE {SUBSCRIPTION_COLUMN_S_DATE}
                              BETWEEN @startDate AND @endDate";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);

            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            } 
            catch
            {

            } 
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static DataTable GetSubscriptionByDateAndByMthods(DateTime startDate, DateTime endDate, string method)
        {
            DataTable dt = new DataTable();


            string query = $@"SELECT {SUBSCRIPTION_COLUMN_PK},
                              {PERSON_COLUMN_FIRST_NAME} + ' ' +
                              {PERSON_COLUMN_MID_NAME} + ' ' + 
                              {PERSON_COLUMN_LAST_NAME} as Name,
                              {SUBSCRIPTION_COLUMN_FEE},
                              {PAYMENT_COLUMN_AMOUNT} as Paid,
                              {PAYMENT_METHOD_COLUMN_METHOD},
                              {SUBSCRIPTION_COLUMN_S_DATE},
                              {SUBSCRIPTION_COLUMN_E_DATE}
                              FROM {SUBSCRIPTIONS}
                              JOIN {MEMBERS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_MEMBER_ID} = {MEMBERS}.{MEMBER_COLUMN_PK}
                              JOIN {PERSONS} ON {MEMBERS}.{MEMBER_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              JOIN {PAYMENTS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_PAYMENT_ID} = {PAYMENTS}.{PAYMENT_COLUMN_PK}
                              JOIN {PAYMENT_METHODS} ON {PAYMENTS}.{PAYMENT_COLUMN_METHOD_ID} = {PAYMENT_METHODS}.{PAYMENT_METHOD_COLUMN_PK}
                              WHERE {SUBSCRIPTION_COLUMN_S_DATE}
                              BETWEEN @startDate AND @endDate
                              AND {PAYMENT_METHOD_COLUMN_METHOD} in(@method)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);
            command.Parameters.AddWithValue("@method", method);

            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static DataTable GetSubscriptionByDateAndByMthodsAndByMember(DateTime startDate, DateTime endDate, string method, string member)
        {
            DataTable dt = new DataTable();


            string query = $@"SELECT {SUBSCRIPTION_COLUMN_PK},
                              {PERSON_COLUMN_FIRST_NAME} + ' ' +
                              {PERSON_COLUMN_MID_NAME} + ' ' + 
                              {PERSON_COLUMN_LAST_NAME} as Name,
                              {SUBSCRIPTION_COLUMN_FEE},
                              {PAYMENT_COLUMN_AMOUNT} as Paid,
                              {PAYMENT_METHOD_COLUMN_METHOD},
                              {SUBSCRIPTION_COLUMN_S_DATE},
                              {SUBSCRIPTION_COLUMN_E_DATE}
                              FROM {SUBSCRIPTIONS}
                              JOIN {MEMBERS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_MEMBER_ID} = {MEMBERS}.{MEMBER_COLUMN_PK}
                              JOIN {PERSONS} ON {MEMBERS}.{MEMBER_COLUMN_PERSON_ID} = {PERSONS}.{PERSON_COLUMN_PK}
                              JOIN {PAYMENTS} ON {SUBSCRIPTIONS}.{SUBSCRIPTION_COLUMN_PAYMENT_ID} = {PAYMENTS}.{PAYMENT_COLUMN_PK}
                              JOIN {PAYMENT_METHODS} ON {PAYMENTS}.{PAYMENT_COLUMN_METHOD_ID} = {PAYMENT_METHODS}.{PAYMENT_METHOD_COLUMN_PK}
                              WHERE {SUBSCRIPTION_COLUMN_S_DATE}
                              BETWEEN @startDate AND @endDate
                              AND {PAYMENT_METHOD_COLUMN_METHOD} = @method
                              AND {PERSON_COLUMN_FIRST_NAME} + ' ' +
                              {PERSON_COLUMN_MID_NAME} + ' ' + 
                              {PERSON_COLUMN_LAST_NAME} = @member";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@startDate", startDate);
            command.Parameters.AddWithValue("@endDate", endDate);
            command.Parameters.AddWithValue("@method", method);
            command.Parameters.AddWithValue("@member", member);

            try
            {
                connection.Open();
                DBLib.LoadDataToDataTable(ref dt, command);
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;

        }



        /************ FEES ************/
        public static bool UpdateFee(decimal newFee)
        {
            int rowEffected = 0;

            string query = $@"UPDATE {FEES} 
                            SET {FEE_COLUMN_SUBSCRIPTION_Fee} = @newFee";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@newFee", newFee);

            try
            {
                connection.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch
            {
                rowEffected = -1;
            }
            finally
            {
                connection.Close();
            }

            return rowEffected > 0;
        }

        public static decimal GetCurrentFee()
        {
            decimal fee = 0;

            string query = $@"SELECT {FEE_COLUMN_SUBSCRIPTION_Fee} FROM {FEES}";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                DBLib.ExecAndGetDecimalClmValue(ref fee, FEE_COLUMN_SUBSCRIPTION_Fee, command);
            } 
            catch
            {
                fee = 0;
            }
            finally
            {
                connection.Close();
            }

            return fee;
        }



        /************ TEST ************/
        public static bool AddNewTestToDB
            (
            int instractorID, int memberID, int rankID,
            bool result, DateTime date, int paymentID
            )
        {
            int rowEffected = 0;

            string query = $@"{InsInto(BELT_TESTS)}
                              ({TESTS_COLUMN_INSTRACTOR_ID}, 
                               {TESTS_COLUMN_MEMBER_ID},
                               {TESTS_COLUMN_RANK_ID},
                               {TESTS_COLUMN_PAYMENT_ID},
                               {TESTS_COLUMN_RESULT}, 
                               {TESTS_COLUMN_DATE}) 
                               VALUES (@instractorID, @memberID, @rankID, @paymentID, @result, @date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@instractorID", instractorID);
            command.Parameters.AddWithValue("@memberID", memberID);
            command.Parameters.AddWithValue("@rankID", rankID);
            command.Parameters.AddWithValue("@paymentID", paymentID);
            command.Parameters.AddWithValue("@result", result);
            command.Parameters.AddWithValue("@date", date);

            try
            {
                connection.Open();
                rowEffected = command.ExecuteNonQuery();
            } 
            catch
            {
                rowEffected = -1;
            } 
            finally
            {
                connection.Close();
            }

            return rowEffected > 0;
        }

    }
}