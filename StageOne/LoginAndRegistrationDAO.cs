using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace StageOne
{
    internal class LoginAndRegistrationDAO : DatabaseAccessObject
    {

        public String RegisterUser(String username_param, String email_param, String password_param)
        {
            List<MySqlParameter> procedure_params = new List<MySqlParameter>();

            MySqlParameter username = new("@username", MySqlDbType.VarChar, 50)
            {
                Value = username_param
            };
            procedure_params.Add(username);

            MySqlParameter email = new("@email", MySqlDbType.VarChar, 100)
            {
                Value = email_param
            };
            procedure_params.Add(email);

            MySqlParameter password = new("@password", MySqlDbType.VarChar, 50)
            {
                Value = password_param
            };
            procedure_params.Add(password);

            DataSet auth_result = MySqlHelper.ExecuteDataset(DatabaseAccessObject.MySqlConnection, "call CreateAccount(@username, @email, @password)", procedure_params.ToArray());


            return auth_result.Tables[0].Rows[0]["MESSAGE"].ToString();
        }
    }
}
