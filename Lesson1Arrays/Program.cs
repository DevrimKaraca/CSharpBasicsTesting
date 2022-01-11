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
            
            Nurgul nurgul = new Nurgul();
            nurgul.hairColor = "orange";


            string x = nurgul.hairColor;
        }
    }



    class Nurgul 
    {
        public string hairColor="black";
    }
}
