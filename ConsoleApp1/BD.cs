public class BD : Volume
{
    public string Dessinateur { get; }

    public BD(string titre, string auteur, string dessinateur) : base(titre, auteur)
    {
        Dessinateur = dessinateur;
    }

    public override string ToString() => $"{base.ToString()}, Dessinateur : {Dessinateur}";
}
