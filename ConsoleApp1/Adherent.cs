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

    public override string ToString() =>
        $"Nom : {Nom}, Prénom : {Prenom}, Livres : {string.Join(", ", LesLivres)}";
}
