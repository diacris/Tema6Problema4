using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6Problema4
{
    class Animal
    {
        private string _respira;
        private string _mananca;
        private int _doarme;
        protected string culoare;


        public Animal(string respira, string mananca, int doarme)
        {
            _respira = respira;
            _mananca = mananca;
            _doarme = doarme;
        }

        public string Respira
        {
            get { return _respira; } 
        }

        public string Mananca
        {
            get { return _mananca; }
        }

        public int Doarme
        {
            get { return _doarme;  }
        }

        public void AfiseazaCaracteristici()
        {
            Console.WriteLine($"Caracteristicile animalului sunt: {Respira}, {Mananca}, {Doarme}");
        }
    }
}
