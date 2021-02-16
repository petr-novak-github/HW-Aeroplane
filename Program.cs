using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplane
{
    interface IGetWeight
    {          //nededi z tridy Shape, ale musi mit metodu Perimeter = interface
        double GetWeight();
    }


    class Person:IGetWeight
    {
        private string gender;
        private double height;
        private int age;

        //getters and setters and constructors
        #region
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double value)
        {
            height = value;
        }

        public string GetGender()
        {
            return gender;
        }

        public void SetGender(string value)
        {
            gender = value;
        }

        public Person(string gender, double height, int age)
        {
            this.gender = gender;
            this.height = height;
            this.age = age;
        }
        #endregion

        public double GetWeight() {

            return height - 100;
        }

    }

    class Animal:IGetWeight
    {

        private string type;
        //getters and setters and constructors

        #region


        public string GetType()
        {
            return type;
        }

        public void SetType(string value)
        {
            type = value;
        }

        public Animal(string type)
        {
            this.type = type;
        }
        #endregion

        public double GetWeight()
        {
            double w=0;
            if (type == "savci") {w = 50;}
            if (type == "plazi") {w = 10;}
            if (type == "ryby") {w = 5;}
            if (type == "ptaci") {w = 3;}
            if (type == "hmyz") {w = 0.1;}

            return w;
        }

    }

    class Thing:IGetWeight
    {
        private double height;
        private double length;
        private double width;
        //getters and setters and constructors
        #region
        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double value)
        {
            height = value;
        }

        public double GetLength()
        {
            return length;
        }

        public void SetLength(double value)
        {
            length = value;
        }

        public double GetWidth()
        {
            return width;
        }

        public void SetWidth(double value)
        {
            width = value;
        }

        public Thing(double height, double length, double width)
        {
            this.height = height;
            this.length = length;
            this.width = width;
        }

        #endregion


        public double GetWeight()
        {
           return height * length * width * 2;
        }
    }



    class TestAeroplane
    {
        static void Main(string[] args)
        {

            var p1 = new Person("male", 184, 38);

            var a1 = new Animal("savci");

            var t1 = new Thing(50, 50, 50);

            List<IGetWeight> nakladLetadla = new List<IGetWeight>() {p1, a1, t1 };

            double celkovaHmotnost = 0;
           
            foreach (IGetWeight item in nakladLetadla)
            {
                celkovaHmotnost += item.GetWeight();
               // Console.WriteLine(item.GetWeight());
            }

            Console.WriteLine($"Celkova hmotnost je: {celkovaHmotnost}");
            Console.ReadLine();

        }
    }
}
