using System;

namespace AbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shark shark = new Shark();
            //Eagle eagle = new Eagle();
            //Animal[] arr = { shark, eagle };
            //foreach (var item in arr)
            //{
            //    item.Eat();
            //}

            //IMultiply multiply = new Calculate();
            Person p = new Person();
        }
    }

    #region Sealed
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual void Knowledge()
        {
            Console.WriteLine("nothing");
        }
    }

    class Engineer : Person
    {
        public override void Knowledge()
        {
            base.Knowledge();
        }
    }

    class Developer:Person
    {
        public sealed override void Knowledge()
        {
            Console.WriteLine("C#,Sql,Js");
        }
    }

    sealed class FrontEnd : Developer
    {
    }
    #endregion

    //abstract class - not get instance(create object)
    abstract class Animal
    {
        public abstract void Eat();
        public override string ToString()
        {
            return "animal";
        }

    }

    #region Abstract class

    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    abstract class Fish:Animal
    {
        public abstract void Swim();
    }

    class Shark : Fish,IRun
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public void Run()
        {
            Console.WriteLine();
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }
    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }

    #endregion

    #region Interface
    interface IRun
    {
        void Run();
        //void Test();
    }

    //interface ICalculate
    //{
    //    int Sum(int n1,int n2);
    //    int Difference(int n1, int n2);
    //    double Divide(int n1, int division);
    //    long Multiply(int n1, int n2); 
    //}
    interface IDivide
    {
        double Divide(int n1, int division);
    }

    interface IMultiply
    {
        long Multiply(int n1, int n2);
    }
    interface ISum
    {
        int Sum(int n1, int n2);
    }
    interface IDifference
    {
        int Difference(int n1, int n2);
    }

    class Person : IDifference
    {
        public int Difference(int n1, int n2)
        {
            throw new NotImplementedException();
        }
    }

    class Calculate : ISum,IDifference,IDivide,IMultiply
    {
        public int Difference(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public double Divide(int n1, int division)
        {
            throw new NotImplementedException();
        }

        public long Multiply(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int n1, int n2)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
