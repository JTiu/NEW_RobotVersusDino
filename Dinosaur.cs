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
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //constructor
        public Dinosaur(string incomingType, int incomingHealth, int incomingEnergy, int IncomingAttackPower)
        {
            this.type = incomingType;
            this.health = incomingHealth;
            this.energy = incomingEnergy;
            this.energy = IncomingAttackPower;
        }
        //methods
    }
}
