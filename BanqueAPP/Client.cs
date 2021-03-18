using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BanqueAPP
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adressse;
        private List<Compte> compte_list ;
       // private int cmpt;


        public Client(string n, string p, string a)
        {
            
            this.nom = n;
            this.prenom = p;
            this.adressse = a;
            this.compte_list =new List<Compte>();
        }

        public void afficher()
        {

            Console.WriteLine("le nom est :" + this.nom);
            Console.WriteLine("le prenom est :" + this.prenom);
            Console.WriteLine("l'adresse est :" + this.adressse);
            Console.WriteLine("liste des num de compt");
            
            
        }

        public void affectercompt_client(Compte cp )
        {

            this.compte_list.Add(cp);
        }
        public void afich_liste()
        {
            foreach (var val in compte_list)

                val.consulter();
        } 
             
    }   


}
