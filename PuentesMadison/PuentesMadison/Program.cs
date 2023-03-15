using System;
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

                Console.Write("Ingrese la viga: ");
                viga.Weight = Console.ReadLine();

                viga.Endurance = viga.AnalizeBase();
                viga.VerifyWeight();
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
            }
            Console.Write("Press a key to end... ");
            Console.ReadKey();
        }
    }
}
