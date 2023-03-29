public class CharacterReader
{
    private static string path = "Data/Characters.csv";

    public static List<Character> ReadAllCharacters()
    {
        List<Character> characters = new List<Character>();

        //Read the file
        string[] lines = File.ReadAllLines(path);

        //Loop through each line
        foreach (string line in lines)
        {
            //Split the line into parts
            string[] parts = line.Split(',');

            //Create a new character
            Character character = new Character();

            //Set the properties
            character.Name = parts[0];
            character.ImagePath = parts[1];
            character.FirstGame = parts[2];
            character.YearAppeared = int.Parse(parts[3]);
            character.Quote = parts[4];
            //Add the character to the list
            characters.Add(character);
        }

        //Return the list of characters
        return characters;
    }
}