using System;
namespace InheritancePrac31
{
    internal class Animal
    {
        private void Private()
        {

        }

        protected void Protected()
        {

        }

        public void Public()
        {

        }

        public void TestA()
        {

        }


        public int Age { get; set; }

        public Animal()
        {
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
    }
}