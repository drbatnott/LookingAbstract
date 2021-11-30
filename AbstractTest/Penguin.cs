using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    class Penguin : Bird , IBirdSong
    {
        float m_Volume; // this variable has class scope or can be called a member variable 
        float m_Frequency;// the warble frequency
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
        /// <summary>
        /// Set the bird warble frequency
        /// </summary>
        /// <param name="f">Is the number of times the call will be repeated
        /// when the bird warbles.</param>
        public void Frequency(float f)
        {
            m_Frequency = f;
        }
        /// <summary>
        /// Warble will repeat the birdCall for the number of times set
        /// by the frequency m_Frequency
        /// </summary>
        public void Warble()
        {
            float f = m_Frequency;
            while(f > 0)
            {
                birdCall();
                f -= 0.5f;
            }
        }
    }
}
