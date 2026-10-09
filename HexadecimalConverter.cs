public class HexadecimalConverter
{
    private BinaryHexadecimalDictionary BinaryHexadecimalDictionary = new();

    public string toBinary(string hexa)
    {
        string valueOutput = "";
        foreach(var bits in hexa){
            valueOutput += BinaryHexadecimalDictionary.getBinary($"{bits}");
        }

        return valueOutput;
    }
}