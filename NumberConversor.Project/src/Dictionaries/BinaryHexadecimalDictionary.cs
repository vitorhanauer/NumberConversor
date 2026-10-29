namespace NumberConversor.Project.Dictionaries;

public class BinaryHexadecimalDictionary
{
    private IDictionary<string, string> dictionary = new Dictionary<string, string>()
    {
        {"0000", "0"},
        {"0001", "1"},
        {"0010", "2"},
        {"0011", "3"},
        {"0100", "4"},
        {"0101", "5"},
        {"0110", "6"},
        {"0111", "7"},
        {"1000", "8"},
        {"1001", "9"},
        {"1010", "A"},
        {"1011", "B"},
        {"1100", "C"},
        {"1101", "D"},
        {"1110", "E"},
        {"1111", "F"},
    };

    public string getHexadecimal(string bits)
    {
        return this.dictionary[bits];
    }

    public string getBinary(string hexa)
    {
        return this.dictionary.FirstOrDefault(x => x.Value == hexa).Key;
    }
}