using GameObjects.Interfaces;
using System;
using System.Collections.Generic;

namespace GameObjects.Utils
{
    public class FruitNamesRepository : IRepository<string>, IRandomItemGiver<string>
    {
        private readonly List<string> fruits;

        public FruitNamesRepository()
        {
            this.fruits = new List<string>();
        }
        public IReadOnlyCollection<string> Items => this.fruits.AsReadOnly(); 

        public int Count => this.fruits.Count;

        public void AddItem(string item)
        {
            if(this.fruits.Contains(item))
            {
                throw new ArgumentException("Already exist such an item!");
            }

            this.fruits.Add(item);
        }
        public bool RemoveItem(string item)
        {
            return this.fruits.Remove(item);
        }

        public string GetRandomItem()
        {
            Random rdm = new Random();
            int index = rdm.Next(0, this.fruits.Count);

            
            
            return this.fruits[index];
        }

        public void Seed(params string[] data)
        {
            foreach (var item in data)
            {
                this.fruits.Add(item);
            }
        }
    }
}
