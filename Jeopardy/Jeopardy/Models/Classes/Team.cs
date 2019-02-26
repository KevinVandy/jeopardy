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
            Id = id;
            TeamName = teamName;
            Score = score;
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
                if (Validation.ValidateTeamName(value))
                {
                    teamName = value.Trim();
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
                if (Validation.ValidateTeamScore(value))
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