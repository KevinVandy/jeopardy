using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    public class Team
    {
        private int? id;
        private string teamName;
        private int score;

        public Team() { }

        public Team(int? id, string teamName, int score = 0)
        {
            this.id = id;
            this.teamName = teamName;
            this.score = score;
        }

        public int? Id
        {
            get => id;
            set => id = value;
        }

        public string TeamName
        {
            get => teamName;
            set
            {
                if (ValidateData.ValidateTeamName(value))
                {
                    teamName = value;
                }
                else
                {
                    teamName = "Team";
                }
            }
        }

        public int Score
        {
            get => score;
            set
            {
                if (ValidateData.ValidateTeamScore(value))
                {
                    score = value;
                }
                else
                {
                    score = 0;
                }
            }
        }
        
    }
}