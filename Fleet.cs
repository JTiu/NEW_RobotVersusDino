using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots_v_Dino_Jan28
{
    public class Fleet
    {
        public List<Robot> theFleet;
        //variables
        public Robot myrobot1;
        public Robot myrobot2;
        public Robot myrobot3;
        //constructor
        public Fleet(string incomingName, int incomingHealth, int incomingPowerLevel)
        {
            myrobot1 = new Robot("R2D2", 50, 50);
            myrobot2 = new Robot("C3P0", 40, 40);
            myrobot3 = new Robot("Robby", 30, 30);

            theFleet.Add(myrobot1);
            theFleet.Add(myrobot2);
            theFleet.Add(myrobot3);
        }
       
        //methods
    }
}
