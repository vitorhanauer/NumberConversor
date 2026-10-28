namespace NumberConversor.Project.Converters;
public interface IConverter
{
    string toBinary(string value);
    string toDecimal(string value);
    string toOctal(string value);
    string toHexadecimal(string value);
}