using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp200_beginner_WPF
{
    class MyClass94<T>
    {
        private T[] arr;
        private int count = 0;

        public MyClass94(int length)
        {
            arr = new T[length];
            count = length;
        }

        public void Insert94(params T[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                arr[i] = args[i];
            }
        }

        public void Print94()
        {
            foreach (T i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        public T AddAll94()
        {
            T sum = default(T);
            foreach (T item in arr)
                sum = sum + (dynamic)item;
            return sum;
        }

    }
    class _94_Class
    {
    }
}
