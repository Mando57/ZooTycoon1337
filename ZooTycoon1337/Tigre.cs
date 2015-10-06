using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon1337
{
    class Tigre : IAnimal
    {
        // constructeur
        public Tigre(string nom):base(nom)
        {
        }
        public override void dormir()
        {
            Console.WriteLine(getNom() + " : Je dors sur le dos.");
        }
        public override void exprimeToi()
        {
            Console.WriteLine(getNom() + ": feule");
        }
    }
}
