using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week14_2
{
    public class TeamRepository
    {
        public List<Team> getTeams()
        {
            List<Team> list = new List<Team>();

            Database database = new Database();
            try
            {
                database.Connect();
                string query = "SELECT name FROM teams";
                var dataReader = database.GetDataReader(query);
                while (dataReader.Read())
                {
                    list.Add(new Team(dataReader["name"].ToString()));
                }
                dataReader.Close();
            }
            catch (Exception)
            {
                
            }
            finally
            {
                database.Disconnect();
            }
            return list;
        }
    }
}
