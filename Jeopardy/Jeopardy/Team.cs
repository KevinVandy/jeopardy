using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    class Team
    {
        private int TeamID;
        private string TeamName;
        private int Score;

        public int GetTeamID()
        {
            return TeamID;
        }

        public void SetTeamID(int Value)
        {

                TeamID = Value;
            

        }

        public string GetTeamNam()
        {
            return TeamName;
        }

        public void SetTeamName(string Value)
        {
            TeamName = Value;
        }

        public int GetScore()
        {
            return Score;
        }

        public void SetScore(int Value)
        {
            Score = Value;
        }

        public Team()
        {

        }

        public Team(int aTeamID, string aTeamName, int aTeamScore= 0)
        {
            TeamID = aTeamID;
            TeamName = aTeamName;
            Score = aTeamScore;
        }
    }
}