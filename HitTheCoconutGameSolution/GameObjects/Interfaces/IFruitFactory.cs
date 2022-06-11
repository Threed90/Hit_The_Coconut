using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Interfaces
{
    public interface IFruitFactory<T>
    {   
        /// <summary>
        /// Method for creating a object of type IFruit
        /// </summary>
        /// <param name="name">The name of the fruit</param>
        /// <param name="path">Please add the image of the fruit into img folder. Then just give the file name and its extension</param>
        /// <param name="points">The points that fruit will give.</param>
        /// <returns></returns>
        public IFruit CreateFruit(string name);

        public IFruit CreateRandomFruit(IRandomItemGiver<T> fruit);
    }
}
