using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6Problema4
{
    class Mamifer : Animal
    {
        public string Culoare
        {
            get { return culoare; }
            set { culoare = value; }
        }

        public Mamifer(string respira, string mananca, int doarme) : base(respira, mananca, doarme)
        {

        }

        public void Naste()
        {
            Console.WriteLine("Acest animal naste");
        }
    }
}
