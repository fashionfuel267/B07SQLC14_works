using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B07SQLC14_w02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FIFO=>Patient,counter,q
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(31);
            queue.Enqueue(41);
            queue.Enqueue(16);
            queue.Enqueue("Kamal");
            foreach (var item in queue) { 
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            queue.Dequeue();
            queue.Clear();
            Console.WriteLine("Item after remove 1st item");
            foreach (var item in queue)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine($"First Item : {queue.Peek()}");
            queue.Dequeue();
            Console.WriteLine("Item after remove 2nd item");
            foreach (var item in queue)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            queue.Dequeue();
            Console.WriteLine("Item after remove 3rd item");
            foreach (var item in queue)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            queue.Dequeue();
            Console.WriteLine("Item after remove 4th item");
            foreach (var item in queue)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            queue.Dequeue();
            Console.WriteLine("Item after remove 5th item");
            foreach (var item in queue)
            {
                Console.Write($"{item}\t");
            }
            if (queue.Count > 0)
            {
                queue.Dequeue();
                Console.WriteLine("Item after remove 6th item");
                foreach (var item in queue)
                {
                    Console.Write($"{item}\t");
                }
            }
       
            Console.ReadKey();
        }
    }
}
