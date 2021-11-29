using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    /// <summary>
    /// Bird is an abstract class
    /// When we want to use it we will need to implement the abstract method birdCall
    /// but we will be able to use the non abstract method birdnest
    /// </summary>
    abstract class Bird
    {
        public abstract void birdCall();// birdCall is an abstract method
        public void birdNest()
        {
            Console.WriteLine("zzzzzzz");
        }
    }
}
