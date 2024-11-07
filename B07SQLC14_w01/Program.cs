using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace B07SQLC14_w01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lifo
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push("Alamin");
            stack.Push("Kamal");
            stack.Push("Jamal");
            stack.Push("Tomal");
            foreach (var item in stack) {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
           stack.Pop();
            Console.WriteLine("-------Pop------");
            foreach (var item in stack)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
