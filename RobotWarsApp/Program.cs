using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWarsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INPUT: ");

            var arenaSize = Console.ReadLine().Split();

            var robo1Location = Console.ReadLine().Split(); ;
            var robo1Instruction = Console.ReadLine();

            var robo2Location = Console.ReadLine().Split(); ;
            var robo2Instruction = Console.ReadLine();

            // Set Compass
            var Compass = new Compass();

            // Set Arena
            var O2Arena = new Arena(int.Parse(arenaSize[0]),
                int.Parse(arenaSize[1]));

            // Set Robo 1
            var Johnny5 = new Robot(
                int.Parse(robo1Location[0]),
                int.Parse(robo1Location[1]),
                robo1Location[2].ToString());
            Johnny5._compass = Compass;
            O2Arena._robot = Johnny5;
            Johnny5._arena = O2Arena;
            O2Arena.add();
            Johnny5.setInstructions(robo1Instruction);

            Console.WriteLine(string.Format("{0} {1} {2}", Johnny5._y, Johnny5._x, Johnny5.status));

            // Set Robo 2
            var R2D2 = new Robot(
                int.Parse(robo2Location[0]),
                int.Parse(robo2Location[1]),
                robo2Location[2].ToString());
            R2D2._compass = Compass;
            O2Arena._robot = R2D2;
            R2D2._arena = O2Arena;
            O2Arena.add();
            R2D2.setInstructions(robo2Instruction);
            
            Console.WriteLine(string.Format("{0} {1} {2}", R2D2._y, R2D2._x, R2D2.status));
        }
    }
}
