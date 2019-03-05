using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWarsApp
{
    public class Compass
    {
        private enum coordinates
        {
            N = 0,
            E = 1,
            S = 2,
            W = 3
        }

        public int getValue(string name)
        {
            return (int)Enum.Parse(typeof(coordinates), name);
        }

        public string getRightCoordinate(string coordinate)
        {
            if (coordinate == "W")
                return "N";

            return Enum.GetName(typeof(coordinates), getValue(coordinate) + 1);
        }
        public string getLeftCoordinate(string coordinate)
        {
            if (coordinate == "N")
                return "W";

            return Enum.GetName(typeof(coordinates), getValue(coordinate) - 1);
        }
    }
}
