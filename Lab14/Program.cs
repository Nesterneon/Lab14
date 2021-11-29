using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.ShowInfo();
            dog.Say();
            cat.ShowInfo();
            cat.Say();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string name { get; set; }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(name);
            Say();
        }
    }
    class Dog : Animal
    {
        public string dog="Собака";

        public override string name
        {
            get
            {
                return dog;
            }
            set
            {
                dog = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
    class Cat : Animal
    {
        public string cat="Кошка";

        public override string name
        {
            get
            {
                return cat;
            }
            set
            {
                cat = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
