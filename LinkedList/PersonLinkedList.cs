using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class RemoveLinkedList<T> : IEnumerable<T>
    {
        public int Count { get; set; }

        private Node<T> _head;

        public RemoveLinkedList()
        {
            Count = 0;
            _head = null;
        }

        public RemoveLinkedList( params T[] values) :this()
        {
            foreach (var value in values)
            {
                Insert(value);
            }
        }

        public void Insert(T data)
        {
            var node = CreateNode(data);
            node.Next = _head;
            _head = node;
        }

        private Node<T> CreateNode(T data)
        {
            Count++;
            return new Node<T>
            {
                Data = data
            };
        }

        public T Get(int index)
        {
            int position = 0;
            Node<T> node = _head;
            while(position < index && node != null)
            {
                node = node.Next;
                position++;
            }

            if(node!= null)
            {
                return node.Data;
            }

            return default(T);
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = _head;
            
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void RemoveWhere(Func<T, bool> condition)
        {
            // Remove all nodes at the beginning of the list meeting the condition
            while( _head != null && condition(_head.Data))
            {
                _head = _head.Next;
            }

            Node<T> node = _head;

            while(node != null)
            {
                // While the next node meets the criteria, forget it
                while(node.Next != null && condition(node.Next.Data))
                {
                    node.Next = node.Next.Next;

                }
                node = node.Next;
            }
        }
    }    
}