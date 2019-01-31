using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jeopardy;

namespace Jeopardy.UnitTests
{
    [TestClass]
    public class TeamTests
    {
        [TestMethod]
        public void SetTeamName_SetLength10_ReturnLength10()
        {
            string name = "ThisEquals";
            Team team = new Team();

            team.TeamName = name;

            Assert.AreEqual(team.TeamName, name);
        }

        [TestMethod]
        public void SetTeamName_SetLength0_ReturnDefault()
        {
            string name = "";
            Team team = new Team();

            team.TeamName = name;

            Assert.AreEqual(team.TeamName, "Team");
        }

        [TestMethod]
        public void SetTeamScore_Set1000_Return1000()
        {
            int score = 1000;
            Team team = new Team();

            team.Score = score;

            Assert.AreEqual(team.Score, score);
        }

        [TestMethod]
        public void SetTeamScore_Set10000000_Return()
        {
            int score = 10000000;
            Team team = new Team();

            team.Score = score;

            Assert.AreEqual(team.Score, 0);
        }
    }
}
