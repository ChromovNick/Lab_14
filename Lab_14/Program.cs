using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog doggo = new Dog("Пёс");
            doggo.ShowInfo();
            Cat citty = new Cat("Кошка");
            citty.ShowInfo();
            Console.ReadKey();
        }
    }
}
