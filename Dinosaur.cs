using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots_v_Dino_Jan28
{
    public class Dinosaur
    {
        //variables
        public string name;
        public int health;
        public int energy;
        public int attackPower;

        //constructor
        public Dinosaur(string incomingType, int incomingHealth, int incomingEnergy, int IncomingAttackPower)
        {
            this.name = incomingType;
            this.health = incomingHealth;
            this.energy = incomingEnergy;
            this.attackPower = 0;
        }
        //methods
        public void Attack(Robot robot)
        {
            robot.health -= attackPower;
            Console.WriteLine(name + " attacked " + robot.name + " for " + attackPower + " damage");
            Console.WriteLine($"{robot.name} has {robot.name} health remaining");
        }
    }
}
