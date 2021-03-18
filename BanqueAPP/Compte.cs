using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Compte
    {
        private  readonly int numcomp;
        private static int cpt;
        private  readonly Client titulaire;
        private MAD solde;
        private  static MAD plafond;
        private List<operation> historique;
        private int numop;
        
        public Compte() { }
         static Compte()
        {
            cpt = 0;
            plafond = new MAD(3000);

        }
        public Compte(Client titu, MAD somme)
        {
            this.numcomp = ++cpt;
            this.titulaire = titu;
            this.solde = somme;
            this.historique = new List<operation>();
            this.numop = 0;
           // titu.ajouterliste(this);
        }

        public virtual void consulter()
        {
            Console.WriteLine("le num est :" + this.numcomp);
            this.titulaire.afficher();
            this.solde.afficher();
            
            
        }
        
        public virtual bool crediter(MAD somme)
        {
            MAD valnul = new MAD(0);
            if (somme > valnul)
            {
                this.solde += somme;

                this.ADD_OP(somme, "+");
                
                return true;
            }
             return false;
        }

        public virtual  bool debiter(MAD somme)
        {
            MAD valnul = new MAD(0);
            if (somme > valnul )
            {
                if(plafond > somme)
                {
                    if(this.solde > somme)
                    {
                        this.solde -= somme;
                        this.ADD_OP(somme, "-");
                        return true;
                    }
                    else {
                        Console.WriteLine("somme > solde ");
                        return false;
                    }
                }
                    else
                    {
                        Console.WriteLine("somme > plafond ");
                        return false;

                    }
            }
            else
                    {
                        Console.WriteLine("somme  invalide ");
                        return false;
                    }

        }

        public virtual bool verser(Compte c, MAD somme)
        {
            if (this.debiter(somme))
            {
                c.crediter(somme);
                return true;
            }
            return false;
        }

        public bool verifier(MAD m)
        {
            return this.solde > m;
        }

         public void ADD_OP(MAD somme,string s)
            { 
                
                operation op = new operation(somme,s, ++this.numop);
                        this.historique.Add(op);
           }
        public void afich_op()
        {
            Console.WriteLine("le num de compte  :" + this.numcomp + "effectue ces operations");
            foreach (var val in historique)

                val.showop();
        }
        public MAD multipledesolde(double b)
        {
           MAD s = this.solde * b;
            return s;
        }


    }
}





