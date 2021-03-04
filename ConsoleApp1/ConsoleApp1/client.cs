using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class client
    {
        String nom;
        String prenom;
        String adress;

        public client(string nom, string pre, string add)
        {
            this.nom = nom;
            this.prenom = pre;
            this.adress = add;
        }
        public String showclients()
        {

            String s = this.nom.ToString()+" "+this.prenom.ToString();
            return s;
        }
    }

}
