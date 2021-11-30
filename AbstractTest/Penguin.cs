using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    class Penguin : Bird
    {
        /// <summary>
        /// Penguin class implements the Bird abstract class
        /// it overloads the birdNest method of the Bird class
        /// it overrides the abstract method birdCall of the Bird class
        /// it has a Global accessor Property Volume which allows outside programs to 
        /// read the value of the class variable m_volume which has class scope
       
        float m_Volume; // this variable has class scope or can be called a member variable 
        /// </summary>
        public float Volume//Volume property is encapsulated in Penguin but has global scope
        {
            get { return m_Volume; }
        }
        public override void birdCall()
        {
            m_Volume = 27.3f;
            float lVolume = 2 * m_Volume;
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
