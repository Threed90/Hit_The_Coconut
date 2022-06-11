using GameObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Models.Fruits
{
    public abstract class Fruit : IFruit
    {
        public Fruit(string name, int points, string imgPath)
        {
            this.Name = name;
            this.Points = points;
            this.ImgPath = imgPath;

        }
        public string Name { get; private set; }

        public int Points { get; private set; }

        public string ImgPath { get; private set; }
    }
}
