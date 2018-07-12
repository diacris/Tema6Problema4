using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6Problema4
{
    class RaseCaini : Caine
    {
        private string rasa;
        public string Rasa
        {
            get { return rasa; }
        }

        public RaseCaini(string respira, string mananca, int doarme, string rasa) : base(respira, mananca, doarme)
        {
            this.rasa = rasa;
        }
        public override void Latra()
        {
            Console.WriteLine($"Ham ham haaaaaam! Sunt un {Rasa}");
        }
    }
}


