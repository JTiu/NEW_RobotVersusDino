using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots_v_Dino_Jan28
{
    public class Battlefield
    {
        //variables
        public Fleet Fleet;
        public Herd Herd;

        //constructor
        public Battlefield()
        {
            Fleet = new Fleet();
            Herd = new Herd();
        }

        public void RunBattle()
        {
            DisplayWelcome();
            DoBattle();
            DisplayWinner();
        }

        public void DoBattle()
        {

            while (Fleet.theFleet.Count > 0 && Herd.theHerd.Count > 0)
            {
                Fleet.theFleet[0].Attack(Herd.theHerd[0]);
                if (Herd.theHerd[0].health <= 0)
                {
                    Herd.theHerd.RemoveAt(0);
                    if (Herd.theHerd.Count == 0)
                    {
                        break;
                    }
                    
                }
                Herd.theHerd[0].Attack(Fleet.theFleet[0]);
                
                if (Fleet.theFleet[0].health <= 0)
                {
                    Fleet.theFleet.RemoveAt(0);
                }
            }
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to DEVCODECAMP'S AWESOME ROBOTS v DINOSAURS GAME! Press enter to continue:");
            Console.ReadLine();
        }

        public void DisplayWinner()
        {

            if (Herd.theHerd.Count == 0)
            {
                Console.WriteLine("Robots Win, and We mark progress!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Dinosaurs Win");
                Console.ReadLine();
            }
        }
    }
}
