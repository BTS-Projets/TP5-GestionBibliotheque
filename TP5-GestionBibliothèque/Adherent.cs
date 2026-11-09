public class Adherent
{
    public string Nom { get; }
    public string Prenom { get; }
    public List<Livre> LesLivres { get; } = new();

    public Adherent(string nom, string prenom)
    {
        Nom = nom;
        Prenom = prenom;
    }

    public void emprunter(Livre l)
    {
        if (l.Emprunte == false)
        {
            l.Emprunte = true;
            LesLivres.Add(l);
        }
        else
        {
            Console.WriteLine("Ce livre est déjà emprunté.");
        }
    }

    public void rendre(Livre l)
    {
        if (LesLivres.Contains(l))
        {
            LesLivres.Remove(l);
            l.Emprunte = false;
        }
        else
        {
            Console.WriteLine("Cet adhérent n'a pas emprunté ce livre.");
        }
    }

    public override string ToString()
    {
        return "Nom : " + Nom + ", Prénom : " + Prenom + ", Livres : " + string.Join(", ", LesLivres);
    }
}
