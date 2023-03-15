﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuentesMadison
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Bridge bridge = new Bridge();

                Console.Write("Enter the bridge: ");
                bridge.Structure = Console.ReadLine();



                Console.WriteLine(bridge.Structure);
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
            }
            Console.Write("Press a key to end... ");
            Console.ReadKey();
        }
    }
}
