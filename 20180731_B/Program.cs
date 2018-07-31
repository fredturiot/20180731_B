using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180731_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Methode2(15);

            var prenom = PoserQuestion("quel est votre prenom");
            var nom = PoserQuestion("quel est votre nom");
            var age = PoserQuestion("quel est votre age");

            Console.WriteLine($"bonjour {prenom} {nom}, vous avez {age} ans.");
        }
        
        // methode d'exemple
        static string Methode2(int age)
        { return (age.ToString() + " ans.");}


        static string PoserQuestion(string question)
        {
            Console.WriteLine(question);
            var saisie = Console.ReadLine();
            Console.Clear();

            return saisie;
        }

        


    }
}
