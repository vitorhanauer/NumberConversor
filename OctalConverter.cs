class OctalConverter
{
    private BinaryOctalDictionary dictionary = new();
    private Binary binary = new();
    public string toBinary(string octalNumber)
    {
        string valueOutput = "";
        foreach(var octal in octalNumber)
        {
            valueOutput += dictionary.getBinary($"{octal}");
        }
        return valueOutput;
    }

    public string toHexadecimal(string octalNumber)
    {
        string bits = toBinary(octalNumber);
        return binary.toHexadecimal(bits);
    }

    public string toDecimal(string octalNumber)
    {
        string bits = toBinary(octalNumber);
        return $"{binary.toDecimal(bits)}";
    }
}