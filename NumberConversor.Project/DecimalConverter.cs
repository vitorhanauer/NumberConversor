namespace NumberConversor.Project;
public class DecimalConverter
{
    private BinaryConverter Binary = new BinaryConverter();

    public String toBinary(string value)
    {
        return String.Join("", convertToBinary(Int16.Parse(value)));
    }

    private String[] convertToBinary(int value)
    {
        if (value == 0 || value == 1) return [$"{value}"];
        String rest = $"{value % 2}";

        return convertToBinary(value / 2).Append(rest).ToArray();
    }

    public string toHexadecimal(string value)
    {
        var bits = toBinary(value);
        return this.Binary.toHexadecimal(bits);
    }

    public string toOctal(string value)
    {
        var bits = toBinary(value);
        return this.Binary.toOctal(bits);
    }
}