class Binary
{
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
}