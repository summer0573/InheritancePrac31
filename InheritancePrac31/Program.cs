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

        class Parent
        {
            public static int counter = 0;
            public Parent() { Console.WriteLine("부모 생성자"); }
            public Parent(int param) { Console.WriteLine("Parant (int param)"); }
            public Parent(string param) { Console.WriteLine("Parent(string param)"); }

            public void ContParent()
            {
                Parent.counter++;
            }
        }

        public Child : Parent
            {
                public void CountChild() { Child.counter++; }
                public Child() : base(10)
                {
                    Console.WriteLine("Child():base(10");
                }
                public Child(string input) : base(input)
                {
                    Console.WriteLine("Child(string input):base(input)");
                }
            }

    class Child : Parent { 
            public void CountChild()
            {
                Child.counter++;
            }
        }

        class Child : Parent
        {
            public Child() : base(10)
            {
                Console.WriteLine("Child() : base(10)");
            }
            public Child(String input) : base(input) { Console.WriteLine("Child(string input):base(input)"); }
        }


        static void Main(String[] args)
        {
            Dog d = new Dog();
            d.Public();
            //d.Protected();
            //d.Private();

            List<Animal> animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };

            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();

                Dog dog = item as Dog;
                if (dog != null)
                {
                    dog.bark();
                }
                Cat cat = item as Cat;
                if (cat != null)
                {
                    cat.Meow();
                }

                //    if(item is Dog)
                //    {
                //        ((Dog)item).bark();
                //    } else if(item is Cat)
                //    {
                //        ((Cat)item).Meow();
                //    }

                //    ((Dog)item).bark();
                //    ((Cat)item).Meow();
                //}

            }
        }
    }
}
