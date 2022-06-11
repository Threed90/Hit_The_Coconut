using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Interfaces
{
    public interface IRandomItemGiver<T>
    {
        T GetRandomItem();
    }
}
