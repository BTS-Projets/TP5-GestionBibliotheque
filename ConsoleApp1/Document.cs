public class Document
{
    public string Titre { get; }

    public Document(string titre)
    {
        Titre = titre;
    }

    public override string ToString() => $"Titre : {Titre}";
}
