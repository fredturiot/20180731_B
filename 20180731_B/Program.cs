using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _20180731_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //TP methode
            Console.WriteLine("Entrez le premier prix brut");
            decimal prixBrut = Convert.ToDecimal(Console.ReadLine());
            CalculerPrixNet(prixBrut);
            Console.WriteLine("Entrez le second prix brut");
            prixBrut = Convert.ToDecimal(Console.ReadLine());
            CalculerPrixNet(prixBrut);
            Console.WriteLine("Entrez le dernier prix brut");
            prixBrut = Convert.ToDecimal(Console.ReadLine());
            CalculerPrixNet(prixBrut);

            //autre version
            Console.WriteLine($"prix ttc de l'article: {CalculerPrixNet(100)}euros");
            Console.WriteLine($"prix ttc de l'article: {CalculerPrixNet(200)}euros");
            Console.WriteLine($"prix ttc de l'article: {CalculerPrixNet(156)}euros");

            //exemple
            /*
            Console.WriteLine(Methode2(2));
            */
            var test = Methode2(15);

            var prenom = PoserQuestion("quel est votre prenom");
            var nom = PoserQuestion("quel est votre nom");
            var age = PoserQuestion("quel est votre age");

            Console.WriteLine($"bonjour {prenom} {nom}, vous avez {age} ans.");

            
        }
        
        // methode d'exemple
        static string Methode2(int age)
        {
            return (age.ToString() + " ans.");
        }

        

        static string PoserQuestion(string question)
        {
            Console.WriteLine(question);
            var saisie = Console.ReadLine();
            Console.Clear();

            return saisie;
        }

        static decimal CalculerPrixNet(decimal prixBrut)
        {
            
            decimal tva = 1.206m; //20.6%   m imperatif pour decimal
            decimal prixNet = prixBrut * tva ;
            Console.WriteLine("Le prix net est " + prixNet);
            return prixNet;

        }

        


    }
}
