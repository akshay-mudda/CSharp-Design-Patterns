using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Design_Patterns._1._Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        // Private constructor to prevent instantiation from outside
        private Singleton() { }

        // Public static method to get the instance
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Add any other methods or properties you need here
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
