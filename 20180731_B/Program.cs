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
            //PARSE TP
            Console.WriteLine("tapper un truc");
            string saisie2 = (Console.ReadLine());
            SaisirEntier(saisie2);

            //CORRIGE?
            //var textAAfficher = "Entrez un nombre";
            var saisie3 = SaisirEntierCorrige("Entrez un nombre");
            Console.WriteLine(saisie3);



            // PARSE DATE EXEMPLE
            Console.WriteLine("date de naissance?");
            var saisie = Console.ReadLine();
            var dateDeNaissance = DateTime.Parse(saisie);

            var ageCalcule = DateTime.Now.Subtract(dateDeNaissance).TotalDays / 365;
            Console.WriteLine($"Age:{ageCalcule}");// MAJUSCULE A LINE!!!!!

           



            //TP methode
            Console.WriteLine("Entrez le premier prix brut");
            decimal prixBrut = Convert.ToDecimal(Console.ReadLine());//convertir en decimal l'entree string
            CalculerPrixNet(prixBrut);
            Console.WriteLine("Entrez le second prix brut");
            prixBrut = Convert.ToDecimal(Console.ReadLine());
            CalculerPrixNet(prixBrut);
            Console.WriteLine("Entrez le troisieme prix brut");
            prixBrut = Convert.ToDecimal(Console.ReadLine());
            CalculerPrixNet(prixBrut);
            Console.WriteLine("Entrez le dernier prix brut");
            prixBrut = Decimal.Parse(Console.ReadLine());// pareil que convert au dessus.
            CalculerPrixNet(prixBrut);

            Console.WriteLine("\n");

            //autre version
            Console.WriteLine($"prix ttc de l'article: {CalculerPrixNet(100)}euros");
            Console.WriteLine($"prix ttc de l'article: {CalculerPrixNet(200)}euros");
            Console.WriteLine($"prix ttc de l'article: {CalculerPrixNet(156)}euros");

            Console.WriteLine("\n");
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

        static int SaisirEntier(string saisie2)
        {
            int sortie = int.Parse(saisie2);
            Console.WriteLine(sortie);
            return sortie;


        }

        static int SaisirEntierCorrige(string textAAfficher)
        {
            Console.WriteLine(textAAfficher);
            
            //return int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            i++; //on doit calculer avant d'afficher
            return i;


        }

    }
}
