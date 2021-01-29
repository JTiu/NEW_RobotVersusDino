using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots_v_Dino_Jan28
{
    public class Weapon
    {//variables
        public string typeWeapon;
        public int attackPowerWeapon;

        //constructor
        public Weapon(string incomingTypeWeapon, int incomingAttackPowerWeapon)
        {
            this.typeWeapon = incomingTypeWeapon;
            this.attackPowerWeapon = incomingAttackPowerWeapon;
        }

        //methods
    }
}
