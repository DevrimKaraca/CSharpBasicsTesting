using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerningClassConstructorEtc
{
    class PERSON : IDisposable
    {
        public string hairColor;

        public PERSON() 
        {
            hairColor = "Black";
            Console.WriteLine("Çalıştım.");
        }


        public void Dispose()
        {
            hairColor = null;
        }
    }
}
