using System.Reflection.Metadata;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Bibliotheque bibli = new Bibliotheque();
            // Ajouter des adhérents à la bibliothèque dans la collection des adhérents
            Adherent ad = new Adherent("Dupond", "Jean");
            bibli.AjouterAdherent(ad);
            Adherent ad2 = new Adherent("Dubois", "Marie");
            bibli.AjouterAdherent(ad2);
            // Créer deux livres qui vont être conservés dans des variables
            Livre livre1 = new Livre("Misérables", "Hugo V.");
            Livre livre2 = new Livre("Systèmes multi-agents", "Ferber J.");
            // Ajouter des documents dans la collection de la bibliothèque
            bibli.AjouterDocument(livre1);
            bibli.AjouterDocument(livre2);
            bibli.AjouterDocument(new Journal("Dr Dobbs", new DateTime(2017, 5, 12)));
            bibli.AjouterDocument(new BD("Thorgal: La galère noire", "Van Hamme", "Rosinsky"));
            bibli.AjouterDocument(new Dictionnaire("Petit Robert", "Robert !."));
            // Afficher la liste des documents de la blibliothèque
            Console.WriteLine("------ Liste des documents ------");
            foreach (Document d in bibli.LesDocuments)
            {
                Console.WriteLine(d);
                Console.WriteLine();
            }

            ad.emprunter(livre1);
            ad.emprunter(livre2);

            Console.WriteLine("------ 2/ Afficher les livres empruntés par l'adhérent ------");
            foreach (Livre livre in ad.LesLivres)
            {
                Console.WriteLine(livre);
                Console.WriteLine();
            }

            ad.rendre(livre1);
            Console.ReadKey();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Une erreur a été détectée :\n" + ex.Message);
        }
    }
}
