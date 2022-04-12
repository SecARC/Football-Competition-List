using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week14_2
{
    public class CompetitionRepository
    {
        public List<Competition> getCompetitions()
        {
            List<Competition> list = new List<Competition>();

            Database database = new Database();
            try
            {
                database.Connect();
                string query = "SELECT id, team1, team2, score1, score2 FROM competition";
                var dataReader = database.GetDataReader(query);
                while (dataReader.Read())
                {
                    list.Add(new Competition()
                    {
                        id = Convert.ToInt32(dataReader["id"]),
                        team1 = new Team(dataReader["team1"].ToString()),
                        team2 = new Team(dataReader["team2"].ToString()),
                        score1 = dataReader["score1"] == DBNull.Value ? null : (int?)(dataReader["score1"]),
                        score2 = dataReader["score2"] == DBNull.Value ? null : (int?)(dataReader["score2"])
                    });
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                database.Disconnect();
            }
            return list;
        }

        internal void UpdateCompetition(Competition competition)
        {
            Database database = new Database();
            try
            {
                database.Connect();
                string query = "UPDATE competition SET score1=@score1, score2=@score2 WHERE id=@id ";

                var sqlCommand = database.CreateCommand(query);
                database.addParameter(sqlCommand, "@score1", competition.score1);
                database.addParameter(sqlCommand, "@score2", competition.score2);
                database.addParameter(sqlCommand, "@id", competition.id);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                database.Disconnect();
            }
        }
    }
}
