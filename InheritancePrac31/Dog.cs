using System;

namespace InheritancePrac31
{
    internal class Dog : Animal
    {
        public string Color {  get; set; }

        public void bark()
        {
            Console.WriteLine("왈왈왈왈");
        }
    }
}