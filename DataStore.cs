using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBasket
{
    public class DataStore<T>
    {
        private readonly int _size = 10;
        private T[] _items;
        private int _current = -1;
        private int _count = 0;
        public DataStore(int size = 10)
        {
            _items = new T[size];
            _size = size;
        }

        public DataStore(T data, int size = 10)
            : this(size)
        {
            _items[_current] = data;
            _current = 1;
        }

        public void Add(T item)
        {
            if (_current < _size - 1)
            {
                _current++;
                _items[_current] = item;
            }
            else
            {
                throw new StackOverflowException("Корзина перепонена");
            }
        }

        public void Remove(T item)
        {
            if (_current >= 0)
            {
                for (int i = 0; i < _items.Length; i++)
                {
                    if (_items[i].ToString() == item.ToString())
                    {
                        _items[i] = default(T);
                        break;
                    }
                }
            }
            else
            {
                throw new NullReferenceException("Корзина пуста!");
            }
        }

        public int Count()
        {
            _count = 0;
            foreach (T item in _items)
            {
                if (item != null)
                {
                    _count++;
                }
                else
                {
                    break;
                }
            }

            return _count;
        }

        public void Print()
        {
            foreach (T item in _items)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}