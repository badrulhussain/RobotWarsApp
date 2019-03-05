using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWarsApp
{
    public class Arena
    {
        public readonly Robot[,] _robotArena;
        public Robot _robot;

        int robotscurrentYcoordinate;
        int robotsCurrentXcoordinate;
        
        // creats it's self with a given size 
        public Arena( int y, int x)
        {
            _robotArena = new Robot[y,x];
        }

        public void add()
        {
            if (_robot._y >= 0 &&
                _robot._x >= 0 &&
                _robot._y <= (_robotArena.GetLength(0) - 1) &&
                _robot._x <= (_robotArena.GetLength(1) - 1))
            {
                _robotArena[_robot._y, _robot._x] = _robot;
                robotscurrentYcoordinate = _robot._y;
                robotsCurrentXcoordinate = _robot._x;
            }
            else
            {
                _robot.status = "Wreck";
            }
        }

        // updates a object in the arena
        public void update()
        {
            if (_robot._y >= 0 &&
                _robot._x >= 0 &&
                _robot._y <= (_robotArena.GetLength(0) -1) &&
                _robot._x <= (_robotArena.GetLength(1) -1))
            {
                _robotArena[_robot._y,_robot._x] = _robot;

                _robotArena[robotscurrentYcoordinate, robotsCurrentXcoordinate] = null;
                robotscurrentYcoordinate = _robot._y;
                robotsCurrentXcoordinate = _robot._x;
            }
            else
            {
                _robot.status = "Wreck";
            }
        }
    }
}
