class Binary
{
    private IDictionary<string, string> bth = new Dictionary<string, string>()
    {
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
    public int toDecimal(string Bits)
    {
        int valueOutput = 0;
        String[] list = Bits.Select(c => c.ToString()).Reverse().ToArray();
        for (int i = 0; i < list.Length; i++)
        {
            int digit = ((int)Math.Pow(2,i));
            valueOutput += Int16.Parse(list[i]) * digit;
        }
        return valueOutput;
    }

    public string toHexadecimal(string Bits)
    {
        string valueOutput = "";

        var list = Bits.Select(c => c.ToString()).ToArray().Reverse().Chunk(4);
        foreach(var item in list)
        {
            string halfByte = string.Join("", item.Reverse());
            halfByte = new string('0', 4 - halfByte.Length) + halfByte;

            valueOutput = bth[halfByte] + valueOutput;

            Console.WriteLine(halfByte);
        }
        return valueOutput;
    }
}
