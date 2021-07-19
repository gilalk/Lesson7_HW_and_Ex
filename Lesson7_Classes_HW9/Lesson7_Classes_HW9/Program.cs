using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Classes_HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HW9 Table class operations

            Table table1 = new Table();
            table1._numberOfLegs = 4;
            table1._color = "Brown";
            table1._woodType = "Alon";


            Table table2 = new Table(5, "White", "Egoz");

            Table table3 = new Table
            {
                _numberOfLegs = 3,
                _color = "Black",
                _woodType = "Duvdevan"
            };

            Table table4 = table3;

            table1._numberOfLegs = 6;
            table2._color = "Yellow";
            table3._woodType = "Mahogany";
            table4._color = "Offwhite";

            #endregion

            #region HW10 Rectangle class operations

            Rectangle myRectangle = new Rectangle(2.3, 4.1);

            #endregion
        }
    }

    #region HW9 Table class

    public class Table
    {
        
        public int _numberOfLegs;
        public string _color, _woodType;

        public Table()
        {

        }

        public Table(int numOfLegs, string color, string woodType)
        {
            _numberOfLegs = numOfLegs;
            _color = color;
            _woodType = woodType;
        }
    }
    #endregion

    #region HW10 Rectangle class

    public class Rectangle
    {
        public double _area;
        public double _scope;

        // constructors

        public Rectangle(double length, double width)
        {
            _area = GetArea(length, width);
            _scope = GetScope(length, width);
        }

        // functions

        public double GetArea(double length, double width)
        {
            return length * width;
        }

        public double GetScope(double length, double width)
        {
            return 2 * length + 2 * width;
        }
    }

    #endregion
}
