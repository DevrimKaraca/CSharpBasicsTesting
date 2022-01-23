using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object a = true;
                string ax = (string)a;
            }
            catch (Exception ex)
            { 
            string message = "";
            if (ex.Message!= null) string.Concat(message, ex.Message.ToString(), "\n", "\n", "\n", "\n");
            if (ex.InnerException != null) string.Concat(message, ex.InnerException.ToString(), "\n", "\n", "\n", "\n");
            if (ex.TargetSite != null) string.Concat(message, ex.TargetSite.ToString(), "\n", "\n", "\n", "\n");
            if (ex.Source != null) string.Concat(message, ex.Source.ToString(), "\n", "\n", "\n", "\n");
            if (ex.HelpLink != null) string.Concat(message, ex.HelpLink.ToString(), "\n", "\n", "\n", "\n");
            Console.WriteLine(message);

            Console.WriteLine(ex.ToString(), ex.StackTrace, MethodInfo.GetCurrentMethod().Name);
            }
            Console.ReadKey();
        }
    }
}
