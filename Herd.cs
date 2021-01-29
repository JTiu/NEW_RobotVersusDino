using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robots_v_Dino_Jan28
{
    public class Herd
    {
        public List<Dinosaur> theHerd;


        //variables
        public Dinosaur mydinosaur1;
        public Dinosaur mydinosaur2;
        public Dinosaur mydinosaur3;

        //constructor //why does my constructor look different from Nevin's?
        public Herd(string incomingType, int incomingHealth, int incomingEnergy, int IncomingAttackPower)
        {
            theHerd = new List<Dinosaur>();
            mydinosaur1 = new Dinosaur("T-Rex", 45, 45, 45);
            mydinosaur2 = new Dinosaur("Velociraptor", 55, 55, 55);
            mydinosaur3 = new Dinosaur("Brontosaurus", 30, 40, 50);
            theHerd.Add(mydinosaur1);
            theHerd.Add(mydinosaur2);
            theHerd.Add(mydinosaur3);

                
                
            
            
            //methods

        }

    }

    

}



   


