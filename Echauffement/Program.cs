using System.Security.Cryptography.X509Certificates;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Je m'appelle Owen et mon jeu préféré est League of Legends");
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
            Console.WriteLine("Quel est ton prénom ?");
            string playName = Console.ReadLine();
            Console.WriteLine("Quel est ton âge ?");
            int age = Convert.ToInt32(Console.ReadLine());
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
                if (age < 18) Console.WriteLine("Tu es mineur"); else Console.WriteLine("Tu es majeur");
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
                    Console.WriteLine("Combien d'euro as-tu ?");
                    int money = Convert.ToInt32(Console.ReadLine());
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
                        Console.WriteLine("Veux-tu acheter une arme?");
                        Console.WriteLine("1.Calibrum 150€");
                        Console.WriteLine("2.Severum 120€");
                        Console.WriteLine("3.Infernum 200€");
                        Console.WriteLine("4.Crescendum 300€");
                        int choix = Convert.ToInt32(Console.ReadLine());
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
                           
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
            // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
            // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible
            
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}