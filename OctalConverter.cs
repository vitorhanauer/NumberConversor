class OctalConverter
{
    private BinaryOctalDictionary dictionary = new();
    public string toBinary(string octalList)
    {
        string valueOutput = "";
        foreach(var octal in octalList)
        {
            valueOutput += dictionary.getBinary($"{octal}");
        }
        return valueOutput;
    }
}