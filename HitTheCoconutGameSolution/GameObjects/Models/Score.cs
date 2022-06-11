using GameObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Models
{
    public class Score : IScore
    {
        private int score;
        public Score()
        {
            this.score = 0;
        }

        public Score(int initialScore)
        {
            this.score = initialScore;
        }

        public int TotalScore => this.score;

        public void AddPoints(int value)
        {
            this.score += value;
        }

        public void ResetScore()
        {
            this.score = 0;
        }

        public virtual string ShowScore()
        {
            return $"Score: {TotalScore}";
        }
    }
}
