using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Classes_HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer Asus = new Computer
            {
                _model = "SX3 muvmuv z170",
                _price = 4800,
                _screenSize = 15.4f,
                _numberOfProcessors = 2
            };

            Computer Lenovo = new Computer
            {
                _model = "IdealPad 33574",
                _price = 3700,
                _screenSize = 11.3f,
                _numberOfProcessors = 1
            };

            Computer HP = new Computer
            {
                _model = "SR7830",
                _price = 5000,
                _screenSize = 17,
                _numberOfProcessors = 3
            };

            Lenovo.TellMeThePrice();
            Lenovo.TellMeTheScreenSize();
            Lenovo.AddProcessor();
            Lenovo.TurnOn();
            Console.WriteLine(Lenovo.ToString());
        }
    }

    public class Computer
    {
        #region fields

        public string _model;
        public int _price, _numberOfProcessors;
        public float _screenSize;
        public bool _isTurnOn;

        #endregion

        #region ctors



        #endregion

        #region abilities

        public void TellMeThePrice()
        {
            Console.WriteLine(_price);
        }

        public void TellMeTheScreenSize()
        {
            Console.WriteLine(_screenSize);
        }

        public void TurnOn()
        {
            _isTurnOn = true;
        }

        public void TurnOff()
        {
            _isTurnOn = false;
        }

        public void AddProcessor()
        {
            _numberOfProcessors++;
        }

        public override string ToString()
        {
            return $"Model: {_model}, Price: {_price}, Screen Size: {_screenSize}, Number of Processors: {_numberOfProcessors}, Is Turn On? <{_isTurnOn}>";
        }

        #endregion
    }
}
