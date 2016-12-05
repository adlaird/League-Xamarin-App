using System;
using League.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace League.Repositories
{
    public class TeamRepository
    {
        private readonly SQLiteConnection conn;

        public TeamRepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Team>();

            var allTeams = conn.Table<Team>().ToList();
            if (allTeams.Count == 0)
            {
                CreateInitializationData();
            }
        }

        public List<Team> GetAllTeams()
        {
            return conn.Table<Team>().ToList();
            //comment
        }

        private void CreateInitializationData()
        {
            var team1 = new Team() { Id = 1, Name = "Steelers" };
            var team2 = new Team() { Id = 1, Name = "Ravens" };

            var teamList = new List<Team> { team1, team2 };

            conn.InsertAll(teamList);
        }
    }
}
