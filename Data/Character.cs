public class Character : IComparable
{
    public string Name {get;set;} = string.Empty;
    public string ImagePath {get;set;} = string.Empty;
    public string FirstGame{get;set;} = string.Empty;
    public int YearAppeared{get;set;}
    public string Quote{get;set;} = string.Empty;

    public Character()
    {}

    public Character(string name, string imagePath, string firstGame, int yearAppeared, string quote)
    {
        Name = name;
        ImagePath = imagePath;
        FirstGame = firstGame;
        YearAppeared = yearAppeared;
        Quote = quote;
    }

    public int CompareTo(object? obj)
    {
        var character = obj as Character;
        return this.Name.CompareTo(character!.Name);
    }
}