namespace IpadVerwaltung
{
    public class Leihvorgang
    {
        public int Id { get; set; }
        public DateTime AusleihDatum { get; set; }
        public DateTime RueckgabeDatum { get; set; }
        public string? Schueler { get; set; }
        public string? Lehrer { get; set; }
        public string? Schaden { get; set; }
    }
}
