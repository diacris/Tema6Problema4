using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6Problema4
{
     class Caine : Mamifer
    {
        public Caine(string respira, string mananca, int doarme) : base(respira, mananca, doarme)
        {

        }

        public virtual void Latra()
        {
            Console.WriteLine("Ham ham!");
        }
    }
}
