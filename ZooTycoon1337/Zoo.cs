using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon1337
{
    class Zoo
    {
        private List<IAnimal> animaux; // collection d'animaux
        private int del;
        public Zoo()
        {
            // création de la collection
            this.animaux = new List<IAnimal>();
            // A ce niveau, la liste est crée, mais vide.
        }
        /** endort tous les animaux
        * en appelant leur méthode dormir().
        */
        public void endormirLesAnimaux()
        {
            // Les indices d'une liste commencent à zéro.
            // La méthode Count() retourne le nombre d'éléments
            // de la collection.
            for (int i = 0; i < animaux.Count(); i++)
            {
                IAnimal animal = animaux.ElementAt(i);
                animal.dormir();
            }
        }
        public void Concert()
        {
            for (int i = 0; i < animaux.Count(); i++)
            {
                IAnimal animal = animaux.ElementAt(i);
                animal.exprimeToi();
            }
        }

        public void ajouteAnimal(IAnimal animal)
        {
            this.animaux.Add(animal);
        }
        public void nbAnimaux()
        {
            Console.WriteLine("il y'a " + animaux.Count() + " animaux");
        }
        public void deleteAnimaux(string nom)
        {
            bool trouvé = false;
            for (int i = 0; i < animaux.Count(); i++)
            {
                
                IAnimal animal = animaux.ElementAt(i);
                if(animal.getNom()==nom)
                {
                    trouvé = true;
                    del = i;      
                }
                
            }
            if(trouvé==true)
            {
                animaux.Remove(animaux.ElementAt(del));
            }
            else
            {
                Console.WriteLine("nom invalide");
            }
            
            
        }
        
    }
}
