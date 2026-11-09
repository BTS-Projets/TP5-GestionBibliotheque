public class Livre : Volume
{
    public bool Emprunte { get; internal set; }

    public Livre(string titre, string auteur) : base(titre, auteur)
    {
    }

    public override string ToString() => $"{base.ToString()}\nemprunté : {Emprunte}";
}
