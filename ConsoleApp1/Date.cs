public class Date
{
    public DateTime Valeur { get; }

    public Date(DateTime valeur)
    {
        Valeur = valeur.Date;
    }

    public override string ToString() => Valeur.ToString("d/M/yyyy");
}
