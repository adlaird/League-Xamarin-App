using League.Models;
using League.Repositories;
using League.Services;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace League.Tests
{
    [TestFixture]
    public class TeamServiceTests
    {
        [Test]
        public void GetAllTeams_calls_repo_GetAllTeams_function_once()
        {
            var mockTeamRepo = new Mock<ITeamRepository>();
            mockTeamRepo.Setup(m => m.GetAllTeams()).Returns(new List<Team>());

            var teamService = new TeamService(mockTeamRepo.Object);

            teamService.GetAllTeams();

            mockTeamRepo.Verify(m => m.GetAllTeams(), Times.Once());
        }

        [Test]
        public void Reset_calls_repo_Reset_function_once()
        {
            var mockTeamRepo = new Mock<ITeamRepository>();

            var teamService = new TeamService(mockTeamRepo.Object);

            teamService.Reset();

            mockTeamRepo.Verify(m => m.Reset(), Times.Once());
        }
    }
}
