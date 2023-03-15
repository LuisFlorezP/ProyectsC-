using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuentesMadison
{
    internal class Bridge
    {
        private string _structure;

        public Bridge() { }

        public string Structure 
        { 
            get => _structure; 
            set => _structure = ValidateBridge(value); 
        }

        private string ValidateBridge(string value)
        {
            if (value[0] != '*' || value[value.Length - 1] != '*')
            {
                throw new ArgumentException("The bridge is not valid.");
            }

            for (int i = 1; i < value.Length - 1; i++)
            {
                if (value[i] != '=' && value[i] != '+')
                {
                    throw new ArgumentException("The bridge is not valid.");
                }
            }

            return value;
        }
    }
}
