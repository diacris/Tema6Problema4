using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6Problema4
{
     class Pisica : Mamifer
    {
        public Pisica(string respira, string mananca, int doarme) : base(respira, mananca, doarme)
        {

        }

        public void Miauna()
        {
            Console.WriteLine("Miau Miau!");
        }

        public void Toarce()
        {
            Console.WriteLine("Prr prr!");
        }
    }
}
