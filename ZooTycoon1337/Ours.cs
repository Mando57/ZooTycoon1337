using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon1337
{
    class Ours : IAnimal
    {
        //constructeur
        public Ours(string nom):base(nom)
        {
        }
        //méthodes

        public override void dormir()
        {
            Console.WriteLine(getNom() + " : Je dors dans une grotte.");
        }
        public override void exprimeToi()
        {
            Console.WriteLine(getNom() + ": Gronde");
        }
    }
}
