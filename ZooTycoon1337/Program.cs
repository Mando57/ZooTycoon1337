using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon1337
{
    class Program
    {
        //attribut
        private Zoo zoo;
        bool fin = false;
        //constructeur
        public Program()
        {
            this.zoo = new Zoo();
        }
        //méthode
        public void run()
        {
            zoo.ajouteAnimal(new Lion("seigneur"));
            zoo.ajouteAnimal(new GrosMinet("Titi"));
            zoo.ajouteAnimal(new Tigre("gros chat"));
            zoo.ajouteAnimal(new Ours("balou"));
            zoo.ajouteAnimal(new Tigre("sherkan"));
            do
            {
                Console.WriteLine("0=Quitter, 1=Endormir :, 2=Concert,3=Compter les animaux,4=ajout d'un animal,5=suppression d'un animaux, ");
                int choix = Convert.ToInt16(Console.ReadLine());
                Console.Clear();

                switch (choix)
                {
                    case 0:
                        fin = true;
                        break;
                    case 1:
                        zoo.endormirLesAnimaux();
                        break;

                    case 2:
                        zoo.Concert();
                        break;
                    case 3:
                        zoo.nbAnimaux();
                        break;
                    case 4:
                        Console.WriteLine("NOm ?");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Quelle type 1=lion ,2=ours,3=tigre,4=GrosMinet");
                        int choix2 = Convert.ToInt16(Console.ReadLine());
                        switch (choix2)
                        {
                            case 1:
                                zoo.ajouteAnimal(new Lion(nome));
                                break;
                            case 2:
                                zoo.ajouteAnimal(new Ours(nome));
                                break;
                            case 3:
                                zoo.ajouteAnimal(new Tigre(nome));
                                break;
                            case 4:
                                zoo.ajouteAnimal(new GrosMinet(nome));
                                break;
                            default:
                                break;
                        }
                        break;

                    case 5:
                        Console.WriteLine("lequelle ?");
                        string aDel = Console.ReadLine();
                        zoo.deleteAnimaux(aDel);
                        break;
                    default:
                        Console.WriteLine("0=Quitter, 1=Endormir :, 2=Concert,3=Compter les animaux,4=ajout d'un animal,5=suppression d'un animaux, ");
                        choix = Convert.ToInt16(Console.ReadLine());
                        break;
                       

                }

            } while (fin==false);
            
        }
            static void Main(string[] args)
        {
            Program c = new Program();
            c.run();
        }
    }
}
