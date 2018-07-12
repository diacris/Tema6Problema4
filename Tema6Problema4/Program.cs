using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("oxigen", "mancare", 4);
            Mamifer oaie = new Mamifer("oxigen", "iarba", 8);
            oaie.Culoare = "neagra";
            Console.WriteLine(oaie.Culoare);
            
            
            Pisica pisica = new Pisica("oxigen", "lapte", 8);

            pisica.Miauna();

            pisica.Toarce(); 

            Caine caine = new Caine("oxigen", "oase", 7);

            caine.Latra();

            caine.AfiseazaCaracteristici();
            pisica.AfiseazaCaracteristici();

            RaseCaini raseCaini = new RaseCaini("oxigen", "oase", 5, "ciobanesc");
            RaseCaini raseCainiMari = new RaseCaini("oxigen", "oase", 5, "doberman");
            raseCaini.Latra();
            raseCainiMari.Latra();

            Console.ReadLine();
        }
    }
}
