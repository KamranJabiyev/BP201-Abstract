using System;

namespace AccessModifiers.Models
{
    public class Car
    {
        public string Brand { get; }
        public readonly string color;
        public string Model { get; set; }
        public double HorsePower;
        private int _maxSpeed;

        public Car()
        {

        }
        public Car(string brand)
        {
            const int test=10;
            color = "white";
            Brand = "Ford";
            Console.WriteLine(Brand);
        }

        //encapsulatuion
        public int MaxSpeed { 
            get 
            {
                if (_maxSpeed != 0)
                {
                    return _maxSpeed;
                }
                Console.WriteLine("Speed is not set yet");
                return -1;
            }
            set 
            {
                if (value > 20)
                {
                    _maxSpeed = value;
                    return;
                }
                Console.WriteLine("speed must be more than 20 km/hour");
            }
        }
        //public void SetSpeed(int speed)
        //{
        //    if (speed > 20)
        //    {
        //        _maxSpeed = speed;
        //        return;
        //    }
        //    Console.WriteLine("speed must be more than 20 km/hour");
        //}

        //public int GetSpeed()
        //{
        //    if (_maxSpeed != 0)
        //    {
        //        return _maxSpeed;
        //    }
        //    Console.WriteLine("Speed is not set yet");
        //    return -1;
        //}
        public void Run()
        {
            HorsePower = 2;
            Console.WriteLine(Brand);
        }

        class test
        {

        }
    }
}
