using lerningClassConstructorEtc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraysLength = 10;
            
            int[] integerArray = new int[arraysLength];
            string[] stringArray = new string[arraysLength];

            PERSON Nurgul = new PERSON();
            Nurgul.hairColor = "Green";

            Nurgul nurgul = new Nurgul();
            nurgul.hairColor = "orange";


            string nurgulHairColor = nurgul.hairColor;
        }
    }



    class Nurgul 
    {
        public string hairColor="black";
    }
}
