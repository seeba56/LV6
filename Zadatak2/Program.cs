using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.AddProduct(new Product("Kinder jaje", 6.50));
            box.AddProduct(new Product("Lizalica", 1.50));
            box.AddProduct(new Product("Zvake", 0.50));

            BoxIterator iterator = new BoxIterator(box);

            while (iterator.isDone == false)
            {
                Console.WriteLine(iterator.Current.ToString());
                iterator.Next();
            }
        }
    }
}
