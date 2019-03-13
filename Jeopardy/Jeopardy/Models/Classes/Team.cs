namespace Jeopardy
{
    public class Team
    {
        private int index;
        private string teamName;
        private int score;

        public Team() { }

        public Team(int index, string teamName, int score = 0)
        {
            Index = index;
            TeamName = teamName;
            Score = score;
        }

        public int Index
        {
            get => index;
            set => index = value;
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