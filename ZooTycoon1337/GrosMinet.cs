using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon1337
{
    class GrosMinet : IAnimal
    {
        //constructeur
        public GrosMinet(string nom):base(nom)
        {
        }
        public override void dormir()
        {
            Console.WriteLine(getNom() + " : Je dors sur le canapé.");
        }

        public override void exprimeToi()
        {
            Console.WriteLine(getNom() + ": Miaou");
        }
    }
}
