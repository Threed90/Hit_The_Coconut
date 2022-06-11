using GameObjects.Interfaces;
using GameObjects.Models.Fruits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Utils
{
    public class FruitFactory : IFruitFactory<string>
    {
        public IFruit CreateFruit(string name)
        {
            var assembly = Assembly.GetCallingAssembly();
            var type = assembly.GetTypes().FirstOrDefault(t => t.Name.ToLower() == name);

            var fruit = (IFruit)Activator.CreateInstance(type);

            return fruit;
        }

        public IFruit CreateRandomFruit(IRandomItemGiver<string> fruitInfo)
        {
            var fruit = fruitInfo.GetRandomItem();
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().FirstOrDefault(t => t.Name.ToLower() == fruit.ToLower());

            if(type == null)
            {
                return null;
            }

            var fruitObj = (IFruit)Activator.CreateInstance(type);

            return fruitObj;
        }
    }
}
