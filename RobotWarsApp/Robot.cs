using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWarsApp
{
    public class Robot
    {
        private string _direction;

        public Compass _compass;
        public int _y;
        public int _x;
        public Arena _arena;
        public string status = string.Empty;

        public Robot(
            int y, 
            int x,
            string direction)
        {
            _direction = direction;
            _y = y;
            _x = x;
        }


        // interpret instruction
        public void setInstructions(string instructions)
        {
            var instruct = instructions.ToUpper().Replace(" ", string.Empty).ToList();
            foreach(var item in instruct)
            {
                if (!string.IsNullOrEmpty(status))
                    break;

                switch (item)
                {
                    case 'M':
                        move();
                        break;
                    case 'R':
                        turnRight();
                        break;
                    case 'L':
                        turnLeft();
                        break;
                    default:
                        break;
                }
            }
        }


        // move forward
        private void move()
        {
            switch(_direction)
            {
                case "N":
                    _y++;
                    break;
                case "E":
                    _x++;
                    break;
                case "S":
                    _y--;
                    break;
                case "W":
                    _x--;
                    break;
                default:
                    break;
            }

            _arena.update();
        }

        // turn right
        private void turnRight()
        {
            _direction = _compass.getRightCoordinate(_direction);
        }

        // turn left 
        private void turnLeft()
        {
            _direction = _compass.getLeftCoordinate(_direction);
        }
    }
}
