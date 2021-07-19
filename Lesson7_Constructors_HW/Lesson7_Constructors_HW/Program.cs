using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Constructors_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HW7 Ctors Car class operations

            Car myCar = new Car("Toyota");

            myCar.GetBrand();

            #endregion

            #region HW8 Ctors ConsolePlus class operations

            ConsolePlus consolePlus = new ConsolePlus("gil", 12, 23);


            #endregion

            #region HW9 Ctors Person class operations

            Random rand = new Random();

            string[] personNames;
            int[] personAge;

            Console.WriteLine("Choose number for array length: ");
            int n = int.Parse(Console.ReadLine());

            personNames = new string[n];
            personAge = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter name: ");
                Person myPerson = new Person(rand.Next(1, 101), Console.ReadLine());
                personNames[i] = myPerson._name;
                personAge[i] = myPerson._age;
            }

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine($"Name: {personNames[j]} \nAge: {personAge[j]}\n");
            }

            #endregion
        }
    }

    #region HW7 Ctors Car class 

    public class Car
    {
        // fields
        public string _carType;

        // ctors
        public Car(string carType)
        {
            _carType = carType;
        }

        //abilities
        public void GetBrand()
        {
            Console.WriteLine(_carType);
        }
    }

    #endregion

    #region HW8 Ctors ConsolePlus class

    public class ConsolePlus
    {
        // fields
        public string _str;
        public int _num1, _num2;

        // ctors
        public ConsolePlus()
        {
            Console.WriteLine("Default");
        }

        public ConsolePlus(string str) : this ()
        {
            Console.WriteLine(str); 
        }

        public ConsolePlus(string str, int num1, int num2) : this (str)
        {
            Console.WriteLine(num1 + num2);
        }

        // abilities
    }

    #endregion

    #region HW9 Ctors Person class

    public class Person
    {
        public string _name;
        public int _age;

        public Person(string name)
        {
            _name = name;
        }

        public Person(int age, string name): this(name)
        {
            _age = age;
        }
    }

    #endregion

    #region HW Challenge Ctors Saxophone class

    public class Saxophone
    {
        public int _price;
        public string _type;
        public bool _loveIt;

        public Saxophone(int price, string type, bool loveItOrNot)
        {
            _price = price;
            _type = type;
            _loveIt = loveItOrNot;
        }

        public Saxophone(Saxophone mySax)
        {
            this._price = mySax._price;
            this._type = mySax._type;
            this._loveIt = mySax._loveIt;
        }
    }

    #endregion
}
