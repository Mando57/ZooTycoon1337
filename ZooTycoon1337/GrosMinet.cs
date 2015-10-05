﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon1337
{
    class GrosMinet : IAnimal
    {
        //attribut
        private string nom;
        //constructeur
        public GrosMinet(string nom)
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
            Console.WriteLine(this.nom + " : Je dors sur le canapé.");
        }

        public void exprimeToi()
        {
            Console.WriteLine(this.nom + ": Miaou");
        }
    }
}