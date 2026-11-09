public class Volume : Document
{
    public string Auteur { get; }

    public Volume(string titre, string auteur) : base(titre)
    {
        Auteur = auteur;
    }

    public override string ToString() => $"{base.ToString()}\nAuteur : {Auteur}";
}
