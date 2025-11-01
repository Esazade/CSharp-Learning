using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custome_collection
{
    class BankQueue<T>:ICollection<T>
    {
        private Queue<T> _queue=new Queue<T>();
        private readonly int _maxCapacity;

        public BankQueue(int maxCapacity)
        {
            _maxCapacity = maxCapacity;
        }

        public void Add(T item)
        {
            if (_queue.Count >= _maxCapacity)
            {
                throw new InvalidOperationException("The queue is full! Only " + _maxCapacity + " people can wait.");
            }
            _queue.Enqueue(item);
            Console.WriteLine("Add item to Queue");
        }

        public bool Remove(T item)
        {
            if (_queue.Count > 0 && _queue.Peek().Equals(item))
            {
                var removed = _queue.Dequeue();
                Console.WriteLine(removed+"exit of Queue.");
                return true;
            }
            return false;
        }

        public T ServeNext()
        {
            if (_queue.Count<0)
                throw new InvalidOperationException("The queue is empty!");
        
                var next = _queue.Dequeue();
                Console.WriteLine("next person: " + next);
                return next;
        }

        public void DisplayQueue()
        {
            Console.WriteLine("Queue Status:");
            int position = 1;
            foreach (var person in _queue)
            {
                Console.WriteLine(position + " . " + person);
                position++;
            }
        }

        public int Count
        {
            get { return _queue.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Clear()
        {
            _queue.Clear();
        }

        public bool Contains(T item)
        {
            return _queue.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _queue.CopyTo(array, arrayIndex);
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

    }
}
