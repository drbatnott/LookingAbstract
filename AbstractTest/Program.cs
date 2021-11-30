using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bird emperor = new Bird(); Bird is abstract - it doesn't or can't exist
            Penguin emperor = new Penguin();
            emperor.birdCall();
            //This implements polymorphism of the function birdNest
            emperor.birdNest();//this will call the base version of 
            emperor.birdNest(10f);//this calls the overloaded version
            emperor.Frequency(2f);//Penguin class implemented the Frequency interface method
            emperor.Warble();//Penguin class implents the Warble interface method
            Console.ReadLine();
        }
    }
}
