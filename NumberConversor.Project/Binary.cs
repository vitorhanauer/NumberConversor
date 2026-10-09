class Binary
{
    private BinaryHexadecimalDictionary BinaryHexadecimalDictionary = new();
    private BinaryOctalDictionary BinaryOctalDictionary = new();
    
    public string toDecimal(string Bits)
    {
        int valueOutput = 0;
        String[] list = Bits.Select(c => c.ToString()).Reverse().ToArray();
        for (int i = 0; i < list.Length; i++)
        {
            int digit = ((int)Math.Pow(2,i));
            valueOutput += Int16.Parse(list[i]) * digit;
        }
        return $"{valueOutput}";
    }

    public string toHexadecimal(string Bits)
    {
        string valueOutput = "";

        var list = Bits.Select(c => c.ToString()).ToArray().Reverse().Chunk(4);
        foreach(var item in list)
        {
            string halfByte = string.Join("", item.Reverse());
            halfByte = new string('0', 4 - halfByte.Length) + halfByte;

            valueOutput = BinaryHexadecimalDictionary.getHexadecimal(halfByte) + valueOutput;
            
        }
        return valueOutput;
    }
    public string toOctal(string Bits)
    {
        string valueOutput = "";
        var list = Bits.Select(c => c.ToString()).ToArray().Reverse().Chunk(3);
        foreach(var item in list)
        {
            string octal = string.Join("", item.Reverse());
            octal = new string('0', 3 - octal.Length) + octal;

            valueOutput = BinaryOctalDictionary.getOctal(octal) + valueOutput;
        }
        return valueOutput;
    }
}
