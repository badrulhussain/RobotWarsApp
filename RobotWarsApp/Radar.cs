using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWarsApp
{
    public class Radar
    {
        private readonly Arena _arena;
        public Radar(Arena arena)
        {
            _arena = arena;
        }

        public void scanRobos(Robot Robo)
        {
            for (int y = 0; y < _arena._robotArena.GetLength(0); y += 1)
            {
                for (int x = 0; x < _arena._robotArena.GetLength(1); x += 1)
                {
                    if(_arena._robotArena[y, x] == Robo)
                        Console.WriteLine(string.Format("{0} {1} {2} {3}", y, x, Robo._direction, Robo.status));
                }
            }
        }
    }
}
