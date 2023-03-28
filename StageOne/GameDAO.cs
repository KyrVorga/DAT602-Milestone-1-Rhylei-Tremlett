using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageOne
{
    internal class GameDAO : DatabaseAccessObject
    {

        public List<String> GetChat()
        {

            DataSet chat_logs = MySqlHelper.ExecuteDataset(DatabaseAccessObject.MySqlConnection, "call GetChatHistory();");

            //register_result.Tables[0].Rows[0]["message"].ToString();
            var chat_messages = new List<String>();
            foreach (DataRow row in chat_logs.Tables[0].Rows)
            {
                chat_messages.Add(row[0].ToString());
            }

            return chat_messages;
        }

        public String[] GetLeaderboard()
        {
            return new String[0];
        }
    }
}
