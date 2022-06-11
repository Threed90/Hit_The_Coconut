using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Interfaces
{
    public interface IRepository<T>
    {
        public IReadOnlyCollection<T> Items { get; }
        void AddItem(T item);
        bool RemoveItem(T item);

        void Seed(params T[] data);
        int Count { get; }
    }
}
