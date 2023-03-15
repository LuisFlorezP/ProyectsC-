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
            set => _structure = value; 
        }
    }
}
