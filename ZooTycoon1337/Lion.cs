using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon1337
{
    class Lion : IAnimal
    {
        //attribut
        private string nom;
        //constructeur
        public Lion(string nom)
        {
            this.nom = nom;
        }
        // méthodes
        public string getNom()
        {
            return this.nom;
        }
        public void dormir()
        {
            Console.WriteLine(this.nom + " : Je dors sur le ventre.");
        }
        public void exprimeToi()
        {
            Console.WriteLine(this.nom + ": ROAR");
        }
    }
}
