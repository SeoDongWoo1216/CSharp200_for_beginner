using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp200_beginner_WPF
{
    

    class _37_Class
    {
        public enum E37 { Red, Green, Blue };
    }

    class MyList37<T>
    {
        private class Node
        {
            public T data;
            public Node next;
        }
        private Node head = default;

        public void AddNode(T t)
        {
            Node newNode = new Node();
            newNode.next = head;
            newNode.data = t;
            head = newNode;
        }

        public T GetLast()
        {
            T temp = default(T);
            Node current = head;
            
            while(current != null)
            {
                temp = current.data;
                current = current.next;
            }
            return temp;
        }
    }
}
