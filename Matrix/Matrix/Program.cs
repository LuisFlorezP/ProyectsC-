using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Matrix matrix = new Matrix(10);
            matrix.Fill();

            do
            {
                Console.WriteLine(
                    "\nMENU ARRAY.\n" +
                        "   - Option 1: Change size matrix.\n" +
                            "   - Option 2: Show matrix.\n" +
                                "   - Option 3: Main diagonal.\n" +
                                    "   - Option 4: Secondary diagonal.\n" +
                                        "   - Option 0: Salir.\n");

                Console.Write("Type your option: ");
                menu = matrix.Menu();

                switch (menu)
                {
                    case 1:
                        Console.Write("Enter your new size: ");
                        matrix = new Matrix(matrix.Menu());
                        matrix.Fill();
                        Console.WriteLine("Successfully assigned!");
                        break;
                    case 2:
                        Console.WriteLine("********************************* MATRIX *********************************\n" + matrix);
                        break;
                    case 3:
                        Console.WriteLine(matrix.GetMainDiagonal());
                        break;
                    case 4:
                        Console.WriteLine(matrix.GetSecondaryDiagonal()); break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("\nOption is not valid, just use numbers.");
                        break;
                }
            } while (menu != 0);
        }
    }
}
