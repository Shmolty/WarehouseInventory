using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseInventory
{
    internal class Warehouse<T> : IEnumerable<T>
    {
        // COLLECTION
        private T[] products = new T[8];
        private int top = 0;

        // METHOD TO ADD TO THE COLLECTION
        public void Add(T product)
        {
            products[top] = product;
            top++;
        }

        // REMOVE A PRODUCT
        public T Remove(T product)
        {
            top--;
            return products[top];
        }

        // ITERATOR
        public IEnumerator<T> GetEnumerator()
        {
            for (int index = 0; index <= top - 1; index++)
            {
                yield return products[index];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
