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
            bibli.AjouterDocument(new Journal("Dr Dobbs", Convert.ToDateTime("12/05/2017")));
            bibli.AjouterDocument(new BD("Thorgal: La galère noire", "Van Hamme", "Rosinsky"));
            bibli.AjouterDocument(new Dictionnaire("Petit Robert", "Robert !."));
            // ad.EmprunterLivre(livre1);
            // Afficher la liste des documents de la blibliothèque
            Console.WriteLine("------ Liste des documents ------");
            foreach (Document d in bibli.LesDocuments)
            {
                Console.WriteLine("\n"+d);
            }
            Console.ReadKey();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Une erreur a été détectée :\n" + ex.Message);
        }
    }
}