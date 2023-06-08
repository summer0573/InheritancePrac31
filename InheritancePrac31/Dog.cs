using System;

namespace InheritancePrac31
{
    internal class Dog
    {
        public int Age {  get; set; }
        public string Color {  get; set; }

        public Dog() { 
            this.Age = 0;
        }
        public void Eat()
        {
            Console.WriteLine("냠냠냠냠");
        }
        public void Sleep()
        {
            Console.WriteLine("쿨쿨쿨쿨");
        }
        public void bark()
        {
            Console.WriteLine("왈왈왈왈");
        }
    }
}