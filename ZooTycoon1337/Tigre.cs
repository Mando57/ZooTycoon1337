using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon1337
{
    class Tigre : IAnimal
    {
        //attribut
        private string nom;
        // constructeur
        public Tigre(string nom)
        {
            this.nom = nom;
        }
        //méthodes
        public string getNom()
        {
            return this.nom;
        }
        public void dormir()
        {
            Console.WriteLine(this.nom + " : Je dors sur le dos.");
        }
        public void exprimeToi()
        {
            Console.WriteLine(this.nom + ": feule");
        }
    }
}
