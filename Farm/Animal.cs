using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Animal
    {
        public string Color { get; set; }
        public AnimalType AnimalType { get; set; }

        public string Speak()
        {
            if(AnimalType == AnimalType.Cow)
            {

               //play a sound
                return "Moo!";
            }
            else if(AnimalType == AnimalType.Pig)
            {
                return "Oink!";
            }
            else
            {
                return "Boo!";
            }
        }




    }
}
