public class BinaryOctalDictionary
{
    private IDictionary<string, string> dictionary = new Dictionary<string, string>()
    {
        {"000", "0"},
        {"001", "1"},
        {"010", "2"},
        {"011", "3"},
        {"100", "4"},
        {"101", "5"},
        {"110", "6"},
        {"111", "7"},
    };

    public string getOctal(string bits)
    {
        return dictionary[bits];
    }

    public string getBinary(string octal)
    {
        return this.dictionary.FirstOrDefault(o => o.Value == octal).Key;
    }
}