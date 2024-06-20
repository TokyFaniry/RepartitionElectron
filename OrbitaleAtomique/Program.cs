using System;
using OrbitaleAtomique;

internal class Program()
    {
        private static void Main(string[] args)
        {
            Atome Carbone = new Atome(6);
            Console.Write("C(z=6): ");
            //Carbone.AfficherSousCouche();
            Carbone.RepartitionerElectrons();

            Atome Argon = new Atome(18);
            Console.WriteLine();
            Console.Write("Ar(z=18): ");
            //Argon.AfficherSousCouche();
            Argon.RepartitionerElectrons();

            Atome Sb = new Atome(51);
            Console.WriteLine();
            Console.Write("Sb(z=51): ");
            //Sb.AfficherSousCouche();
            Sb.RepartitionerElectrons();

            Atome Cr = new Atome(24);
            Console.WriteLine();
            Console.Write("Cr(z=24): ");
            //Sb.AfficherSousCouche();
            Cr.RepartitionerElectrons();

    }
}

