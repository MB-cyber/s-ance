using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    namespace comptes_bancaires
    {
        class compte
        {
            
           static MAD plafond= new MAD(100000);
 
            static Int32 compt = 0;
            client clients;
            Int32 compt_id;
            MAD solde ;
            
            public compte(client C, double mont)
            {
                compt++;
                this.compt_id = compt;
                this.clients = C;
                this.solde = new MAD (mont);
               
            }
            public void showcom()
            {
                Console.WriteLine("le num_compt : " + this.compt_id + "  " + this.clients.showclients() + "   montant: " + this.solde.showVal());
                
            }

            public bool crediter(MAD montant) 
            {
                
                    this.solde=this.solde.ajouter(montant);
                    return true;
            }


            public bool debiter(MAD montant)
            {
                if (this.solde.xx(montant) == 1 && montant.xx(plafond) == -1)
                {
                    this.solde=this.solde.supp(montant);
                    return true;
                }
                else
                {
                    Console.WriteLine("solde insuffisant ou bien vous atteignez votre plafond : " +plafond.showVal());
                    return false;
                }

            }

            public   void  verment(ref compte Cp, MAD mont)
            {
                if (this.solde.xx(mont)==1 && mont.xx(plafond)==-1)
                {
                    this.debiter(mont);
                    Cp.crediter(mont);

                    Console.WriteLine(mont.showVal() + "DH , versement effectue par : compt_id  "+this.compt_id+clients.showclients()+ "le solde compte "+Cp.compt_id+" = "+Cp.solde.showVal());
                    
                }
                else
                {
                    Console.WriteLine("solde insuffisant ou bien vous atteignez votre plafond : " + plafond.showVal());
                }
            }
        }
    }
}
