using NumberConversor.Project.Structs;

namespace NumberConversor.Project.Converters;

public class ConverterFactory
{
    public static IConverter create(string flag)
    {
        if(flag == BaseNumber.Binary.ToString()) return new BinaryConverter();
        if(flag == BaseNumber.Decimal.ToString()) return new DecimalConverter();
        if(flag == BaseNumber.Octal.ToString()) return new OctalConverter();
        return new HexadecimalConverter();
    }
}