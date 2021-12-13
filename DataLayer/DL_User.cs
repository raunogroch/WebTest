using System.Data.SqlClient;
using System.Data;
using System;

namespace DataLayer
{
    public class DL_User
    {
        private DL_Connections connection = new DL_Connections();

        SqlCommand command = new SqlCommand();

        public bool authentication(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            string resp = verifyPassword(email);

            bool comparison = resp.Equals(password);

            if (comparison)
            {
                return true;
            }
            
            return false;
            
        }
        private string verifyPassword(string email)
        {
            string data = string.Empty;
            try
            {

                command.Connection = connection.OpenConnection();
                command.CommandText = "findUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Email", email);


                IDataParameter dataResponse = command.CreateParameter();
                dataResponse.ParameterName = "@Password";
                dataResponse.Direction = ParameterDirection.Output;
                dataResponse.DbType = DbType.String;
                //dataResponse.Size = 50;
                command.Parameters.Add(dataResponse);

                var res = command.ExecuteReader();
                command.ExecuteNonQuery();

                data = (string)dataResponse.Value;


                connection.CloseConnection();
                command.Parameters.Clear();
            }
            catch(Exception e) { 
                Console.WriteLine(e.Message);
            }

            return data;

        }
    }
}
