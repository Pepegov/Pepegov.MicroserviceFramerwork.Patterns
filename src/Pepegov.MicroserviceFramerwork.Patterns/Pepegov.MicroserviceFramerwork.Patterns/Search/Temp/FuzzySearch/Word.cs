namespace Pepegov.MicroserviceFramerwork.Patterns.Search.Temp.FuzzySearch;

public class Word
{
    public string Text { get; set; }
    public List<int> Codes { get; set; } = new List<int>();
}