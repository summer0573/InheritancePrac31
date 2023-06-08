using System;

namespace InheritancePrac31
{
    internal class Cat : Animal
    {
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("뇸뇸뇸뇸");
        }
        public void Sleep()
        {
            Console.WriteLine("도로로롱");
        }

        public void Meow()
        {
            Console.WriteLine("냥냥냥냥");
        }

        public void TestB()
        {
            //Private();
            Protected();
            Public();
        }
    }
}