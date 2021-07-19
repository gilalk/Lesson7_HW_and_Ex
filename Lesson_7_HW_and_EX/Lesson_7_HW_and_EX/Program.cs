using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_HW_and_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects by using loop

            for (int i = 0; i < 3; i++)
            {
                Airplain myAirplain = new Airplain(108, "GilSky");
            }


            // Creating by object initializer

            Airplain myAirplain1 = new Airplain
            {
                _Company = "GilAir",
                _seats = 216,
                _PilotName = "Motke"
            };

            object
        }
    }

    public class Airplain
    {
        public int _seats;
        public string _PilotName;
        public string _Company;

        public Airplain()
        {
        }

        public Airplain(int seats, string company)
        {
            _seats = seats;
            _Company = company;
        }
    }
}
