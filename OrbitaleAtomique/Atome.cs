using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaleAtomique
{
    internal class Atome
    {
        public int NombreQuantiquePrincipale { get; set; }
        public Atome(int n)
        {
            this.NombreQuantiquePrincipale = n;
        }
        public string GetNumberQuantiqueSecondaire(int l)
        {
            switch (l)
            {
                case 0:
                    return "s";
                case 1:
                    return "p";
                case 2:
                    return "d";
                case 3:
                    return "f";
                case 4:
                    return "g";
                case 5:
                    return "h";
                default:
                    return "Valeur de l invalide";
            }
        }
        public void AfficherSousCouche()
        {
            int n;
            int l;
            for (n = 1; n <= this.NombreQuantiquePrincipale; n++)
            {
                for (l = 0; l <= n - 1; l++)
                {
                    if (l == 6)
                    {
                        break;
                    }
                    Console.Write(n + GetNumberQuantiqueSecondaire(l) + " ");
                }
                Console.WriteLine();
            }
        }

        public void RempliserCouche(ref int nb, int n, int l)
        {
            int maxCouche = 2 * (2 * l + 1); 
            int placer = Math.Min(nb, maxCouche);
            nb -= placer;
            Console.Write(n + GetNumberQuantiqueSecondaire(l) + "(" + placer + ") ");
        }
       public void RepartitionerElectrons()
        {
            int nb = this.NombreQuantiquePrincipale;
            int n = 1;
            int l = 0;
            int n1, l1;
            n1 = 0;
            l1 = 0;
            while (nb > 0)
            {
                for (n = 1; nb > 0; n++)
                {
                    for (l = 0; l <= n-1; l++)
                    {
                        for (n1 = n+1; n1 <= n+1; n1++)
                        {
                            for (l1 = 0; l1 < n1-1; l1++)
                            {
                                if ( n1 + l1<n + l)
                                {
                                    RempliserCouche(ref nb, n1, l1);
                                }
                                if ( n + l<l1 + n1 )
                                {
                                    break;
                                }
                                if(l1+ n1 == n + l)
                                {
                                    if (n1 < n)
                                    {
                                        RempliserCouche(ref nb, n1, l1);
                                    }
                                }
                            }
                        }
                        RempliserCouche(ref nb, n, l);
                    }
                }
            }

        }

    }
}
