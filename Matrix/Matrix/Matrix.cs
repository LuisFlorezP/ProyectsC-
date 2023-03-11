using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix
    {
        private int _n;
        private int[,] _matrix;

        public Matrix(int n)
        {
            _n= n;
            _matrix = new int[_n, _n];
        }

        public void Fill() 
        {
            var random = new Random();

            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _matrix[i, j] = random.Next(1, 100);
                }
            }
        }

        public int Menu()
        {
            bool isValid = false;
            int menu;
            do
            {
                var validate = Console.ReadLine();
                if (!int.TryParse(validate, out menu))
                {
                    Console.WriteLine("\nOption is not valid.");
                    Console.Write("Try again: ");
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

            return menu;
        }

        public string GetMainDiagonal()
        {
            string mensaje = string.Empty;
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    if (i == j)
                    {
                        mensaje += _matrix[i, j] + "\t";
                    }
                    else
                    {
                        mensaje += "\t";
                    }
                }
                mensaje += "\n";
            }

            return mensaje;
        }

        public string GetSecondaryDiagonal()
        {
            string mensaje = string.Empty;
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {   
                    if (j == _n - i - 1)
                    {
                        mensaje += _matrix[i, j] + "\t";
                    }
                    else
                    {
                        mensaje += "\t";
                    }
                }
                mensaje += "\n";
            }

            return mensaje;
        }

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    output += $"{_matrix[i, j]} \t";
                }
                output += "\n";
            }
            return output;
        }
    }
}
