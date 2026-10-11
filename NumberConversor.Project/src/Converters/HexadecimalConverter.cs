namespace NumberConversor.Project.Converters;

public class HexadecimalConverter
{
    private BinaryHexadecimalDictionary BinaryHexadecimalDictionary = new();
    private BinaryConverter Binary = new();

    public string toBinary(string hexa)
    {
        string valueOutput = "";
        foreach(var bits in hexa){
            valueOutput += BinaryHexadecimalDictionary.getBinary($"{bits}");
        }

        return valueOutput;
    }

    public string toDecimal(string hexa)
    {
        string bits = toBinary(hexa);
        return $"{Binary.toDecimal(bits)}";
    }

    public string toOctal(string hexa)
    {
        string bits = toBinary(hexa);
        return Binary.toOctal(bits);
    }
}