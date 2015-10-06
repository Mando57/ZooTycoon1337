using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon1337
{
    abstract class  IAnimal
    {
        private string nom;

        public IAnimal(string n)
        {
            this.nom = n;
        }

        public string getNom()
        { 
           return nom;
        }
        public abstract void dormir();
        public abstract void exprimeToi();
    }
}
