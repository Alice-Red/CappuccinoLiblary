using System;
using Cappuccino;

namespace NotLightWin
{
    public class Program
    {
        public static void Main(string[] args) {
            //Console.WriteLine("Hello.");
            Console.Write("Booting !light ...");

            NotLight nl = new NotLight();
            nl.Boot();
        }
    }
}
