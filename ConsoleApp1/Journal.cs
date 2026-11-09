public class Journal : Document
{
    public Date DateParution { get; }

    public Journal(string titreJournal, DateTime dateParution)
        : this(titreJournal, new Date(dateParution))
    {
    }

    public Journal(string titreJournal, Date dateParution) : base(titreJournal)
    {
        DateParution = dateParution;
    }

    public override string ToString() => $"{base.ToString()}\nDate :{DateParution}";
}
