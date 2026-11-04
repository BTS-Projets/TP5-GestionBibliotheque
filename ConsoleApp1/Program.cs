using System.Reflection.Metadata;

static void Main(string[] args)
{
    try
    {
        Bibliotheque bibli = new Bibliotheque();
        // Ajouter des adhérents à la bibliothéque dans la collection d'adhérents 
        Adherent ad = new Adherent("Jean", "Dupond");
        bibli.AjouterAdherent(ad);
        Adherent ad2 = new Adherent("Marie", "Dubois");
        bibli.AjouterAdherent(ad2);
        // Créer deux livres qui vont être conservés dans des variables
        Livre livre1 = new Livre("Misérables", "Hugo V.");
        Livre livre2 = new Livre("Systèmes multi-agents", "Ferber J.");
        // Ajouter des documents dans la collection de bibliothéque
        bibli.AjouterDocument(livre1);
        bibli.AjouterDocument(livre2);
        bibli.AjouterDocument(new Journal("Dr Dobbs", Convert.ToDateTime("12/05/2017")));
        bibli.AjouterDocument(new BD("Thorgal: La galère noire", "Van Hamme", "Rosinsky"));
        bibli.AjouterDocument(new Dictionnaire("Petit Robert", "Robert !."));
        // Afficher la liste des documents de la bibliothèque
        Console.WriteLine("------liste des documents---------------");
        foreach (Document d in bibli.LesDocuments)
        {
            Console.WriteLine(d);
        }
        Console.ReadKey();

    }
    catch (Exception ex)
    {
        Console.WriteLine("Une erreur a été detectée :\n" + ex.Message);
    }
}