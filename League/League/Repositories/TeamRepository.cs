using League.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace League.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly SQLiteConnection Connection;

        public TeamRepository(SQLiteConnection conn)
        {
            Connection = conn;

            Connection.CreateTable<Team>();

            var allTeams = Connection.Table<Team>().ToList();
            if (allTeams.Count == 0)
            {
                CreateInitializationData();
            }
        }

        public void Reset()
        {
            Connection.DeleteAll<Team>();
            CreateInitializationData();
        }

        public List<Team> GetAllTeams()
        {
            return Connection.Table<Team>().ToList();
        }

        private void CreateInitializationData()
        {
            var team1 = new Team() { Id = 0, Name = "Steelers" };
            var team2 = new Team() { Id = 1, Name = "Ravens" };

            var teamList = new List<Team> { team1, team2 };

            Connection.InsertAll(teamList);
        }
    }
}
