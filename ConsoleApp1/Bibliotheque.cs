public class Bibliotheque
{
    public List<Document> LesDocuments { get; } = new();
    public List<Adherent> LesAdherents { get; } = new();

    public void AjouterAdherent(Adherent adherent)
    {
        LesAdherents.Add(adherent);
    }

    public void AjouterDocument(Document document)
    {
        LesDocuments.Add(document);
    }

    public override string ToString() =>
        $"Documents : {string.Join(", ", LesDocuments)}; Adhérents : {string.Join(", ", LesAdherents)}";
}
