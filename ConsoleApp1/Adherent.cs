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
        if (l.Emprunte)
        {
            throw new InvalidOperationException("Ce livre est déjà emprunté.");
        }

        l.Emprunte = true;
        LesLivres.Add(l);
    }

    public void rendre(Livre l)
    {
        if (!LesLivres.Remove(l))
        {
            throw new InvalidOperationException("Cet adhérent n'a pas emprunté ce livre.");
        }

        l.Emprunte = false;
    }

    public override string ToString() =>
        $"Nom : {Nom}, Prénom : {Prenom}, Livres : {string.Join(", ", LesLivres)}";
}
