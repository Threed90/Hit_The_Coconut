using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Interfaces
{
    public interface IFruit
    {
        public string Name { get; }
        public int Points { get; }
        public string ImgPath { get; }
    }
}
