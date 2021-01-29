using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots_v_Dino_Jan28
{
    public class Fleet
    {
        //    variables
        public List<Robot> theFleet;

        //constructor

        public Fleet()
        {
            Random random = new Random();
            theFleet = new List<Robot>();


            Weapon Axe = new Weapon("Axe", 15);
            Weapon Sword = new Weapon("Sword", 10);
            Weapon Gun = new Weapon("Gun", 50);

            List<Weapon> TheAresenal = new List<Weapon>() { Axe, Sword, Gun };

            Robot robot1 = new Robot("R2D2", 50, 50, TheAresenal[random.Next(3)]);
            Robot robot2 = new Robot("C3P0", 50, 50, TheAresenal[random.Next(3)]);
            Robot robot3 = new Robot("Robby", 40, 20, TheAresenal[random.Next(3)]);
            theFleet.Add(robot1);
            theFleet.Add(robot2);
            theFleet.Add(robot3);

        }


    }
}
