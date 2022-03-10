using FileOperations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadFromFile
{
    class Program
    {
        static FileOperation fileOperation = new FileOperation();

        static void Main(string[] args)
        {
            while (true) 
            {
                string result = fileOperation.ReadFromFileFirstLineOfRandomNumber(FilePath());
                if (result.Contains("***"))
                { 
                    result = result.Replace("***", "Sensör1:");
                }
                if (result.Contains("###")) 
                { 
                    result = result.Replace("###", "Sensör2:");
                }
                Console.WriteLine(result);
                Thread.Sleep(1000);
            }
        }
        public static string FilePath()
        {
            string path = "C:\\Nurgul.txt";
            if (!File.Exists(path)) File.Create(path);
            return path;
        }
    }
}
