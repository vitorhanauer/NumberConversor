public class DecimalConverter
{
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
}