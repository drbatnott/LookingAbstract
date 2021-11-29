using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    class Penguin : Bird
    {
        float m_volume; // this variable has class scope or can be called a member variable 
        public override void birdCall()
        {
            m_volume = 27.3f;
            float lVolume = 2 * m_volume;
            //the local volume lVolume has only got method scope
            Console.WriteLine("Squuuuuaaaaakkkkkkkkkk at " + lVolume) ;
            //throw new NotImplementedException(); This was put in by VS but not needed
        }
        //birdNest(float f) overloads the birdNest method
        public void birdNest(float f)// it has a different signature to the root
        {
            Console.WriteLine("zzzzzzzz at " + f);
        }
    }
}
