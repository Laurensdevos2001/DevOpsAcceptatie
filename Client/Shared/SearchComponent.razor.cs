namespace Oogarts.Client.Shared;

public partial class SearchComponent
{
    static readonly int ResultsPerCategoryLimit = 3;
    Dictionary<string, List<SearchResult>> results = new();
    string search = "";
    string? expandedCategory = null;

    void OnSearchChanged()
    {
        results = new();
        SearchDiseases("");
        SearchDoctors("");
        SearchPosts("");
    }
    // TODO get from db 
    void SearchDiseases(string search)
    {
        string category = "Oogziekten";
        List<SearchResult> results = new()
        {
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
            new(category, "Astigmatisme", "Astigmatisme is een ziekte die ik hier als voorbeeld gebruik", "/oogziekten"),
        };

        this.results.Add(category, results);
    }
    void SearchDoctors(string search)
    {
        string category = "Dokters";
        List<SearchResult> results = new()
        {
            new(category, "Dr. Özlem Köse", "Hoofdarts", "/team"),
            new(category, "Dr. Stefaan De Fixer", "Hoofdoptimetrist", "/team"),
            new(category, "Dr. Özlem Köse", "Hoofdarts", "/team"),
            new(category, "Dr. Stefaan De Fixer", "Hoofdoptimetrist", "/team")
        };

        this.results.Add(category, results);
    }
    void SearchPosts(string search)
    {
        string category = "Posts";
        List<SearchResult> results = new()
        {
            new(category, "Nieuwe Website: Onze praktijk in een nieuw jasje", "In een wereld die steeds digitaler wordt, is het essentieel voor medische praktijken om gelijke tred te houden en patiënten een naadloze en informatieve ervaring te bieden. ", "/nieuws"),
            new(category, "Oude man roept naar wolk", "Een oude man heeft gisteren naar een wolk geroepen", "/nieuws"),
            new(category, "Nieuwe Website: Onze praktijk in een nieuw jasje", "In een wereld die steeds digitaler wordt, is het essentieel voor medische praktijken om gelijke tred te houden en patiënten een naadloze en informatieve ervaring te bieden. ", "/nieuws"),
            new(category, "Oude man roept naar wolk", "Een oude man heeft gisteren naar een wolk geroepen", "/nieuws")
        };

        this.results.Add(category, results);
    }

    public class SearchResult
    {
        static readonly int NameSizeLimit = 50;
        static readonly int DescSizeLimit = 75;

        private string description;
        private string name;

        public string Category {  get; set; }
        public string Url { get; set; }
        public string Name
        {
            get => name;
            set => name = value.Length < NameSizeLimit ? value : value.Substring(0, NameSizeLimit - 3) + "...";
        }
        public string Description
        {
            get => description;
            set => description = value.Length < DescSizeLimit ? value : value.Substring(0, DescSizeLimit - 3) + "...";
        }

        public SearchResult(string category, string name, string description, string url)
        {
            Category = category;
            Name = name;
            Description = description;
            Url = url;
        }
    }
}
