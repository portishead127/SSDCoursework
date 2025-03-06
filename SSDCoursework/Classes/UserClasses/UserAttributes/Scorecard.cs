using SSDCoursework.Classes.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDCoursework.Classes.UserClasses.UserAttributes
{
    public class Scorecard
    {
        public int OverallScore { get; private set; }
        public int TrueFalseHighScore { get; private set; }
        public int MultipleChoiceHighScore { get; private set; }
        public int WrittenHighScore { get; private set; }

        public Scorecard()
        {
            OverallScore = 0;
            TrueFalseHighScore = 0;
            MultipleChoiceHighScore = 0;
            WrittenHighScore = 0;
        }

        public Scorecard(int overallScore, int trueFalseHighScore, int multipleChoiceHighScore, int writtenHighScore)
        {
            OverallScore = overallScore;
            TrueFalseHighScore = trueFalseHighScore;
            MultipleChoiceHighScore = multipleChoiceHighScore;
            WrittenHighScore = writtenHighScore;
        }

        public void UpdateScore(GameType gameType, int score)
        {
            switch (gameType)
            {
                case GameType.TrueFalse:
                    if(score > TrueFalseHighScore)
                    {
                        TrueFalseHighScore = score;
                    }
                    break;
                case GameType.MultipleChoice:
                    if(score > MultipleChoiceHighScore)
                    {
                        MultipleChoiceHighScore = score;
                    }
                    break;
                case GameType.WrittenQuestion:
                    if (score > WrittenHighScore)
                    {
                        WrittenHighScore = score;
                    }
                    break;
                default:
                    throw new Exception("Invalid game type.");
            }

            OverallScore += score;
            UserDatabase.Instance.Write();
        }
    }
}


