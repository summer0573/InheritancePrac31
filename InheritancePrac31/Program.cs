using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritancePrac31
{
    internal static class Program
    {
        static void Main(String args[])
        {
            
            List<Animal> animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };

            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();

                ((Dog)item).bark();
                ((Cat)item).Meow();
            }

        }
    }
}
