using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Interfaces
{
    public interface IScore
    {
        public int TotalScore { get; }
        public void AddPoints(int value);
        public void ResetScore();
        public string ShowScore();
    }
}
