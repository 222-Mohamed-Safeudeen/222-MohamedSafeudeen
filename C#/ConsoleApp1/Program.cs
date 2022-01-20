using System;
using System.Collections;

namespace ConsoleApp1
{
            class Program
            {
               static void Main()
               {
                   Queue myqueue = new Queue();
            myqueue.Enqueue("HELLO");
            myqueue.Enqueue(null);
            myqueue.Enqueue(1);
            myqueue.Enqueue(2);
            myqueue.Enqueue(3);
            myqueue.Enqueue(4);
            myqueue.Enqueue(5);

            foreach (var item  in myqueue)
            {
                Console.WriteLine(item);
            }


        }
             }
}
