using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots_v_Dino_Jan28
{
    public class Robot
    {
        //variables
        public string name;
        public int health;
        public int powerLevel;
        public Weapon AttackWeapon;

        //constructor
        public Robot(string incomingName, int incomingHealth, int incomingPowerLevel, Weapon weapon)//does not need a return type=implicit, unlike a traditional method
        {
            //weapon = new Weapon("Gun", 50);
            this.name = incomingName;
            this.health = incomingHealth;
            this.powerLevel = incomingPowerLevel;
            AttackWeapon = weapon;
        }
            
        //methods
        public void Attack(Dinosaur dinoToAttack)//using Nevin's code as an example
        {
            dinoToAttack.health -= AttackWeapon.attackDamage;

            Console.WriteLine($"{name} attacked {dinoToAttack.name} for { AttackWeapon.attackDamage} damage");
            Console.WriteLine($"{dinoToAttack.name} has {dinoToAttack.health} health remaining");
        }

       
       

    }
}
