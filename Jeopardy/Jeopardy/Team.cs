using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    class Team
    {
        private int id;
        private string teamName;
        private int score;

        public Team() { }

        public Team(int id, string teamName, int score = 0)
        {
            this.id = id;
            this.teamName = teamName;
            this.score = score;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string TeamName
        {
            get => teamName;
            set => teamName = value;
        }

        public int Score
        {
            get => score;
            set => score = value;
        }


    }
}