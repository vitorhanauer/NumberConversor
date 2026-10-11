using NumberConversor.Project.Converters;

namespace NumberConversor.Test;

public class HexadecimalConverterTest
{
    private HexadecimalConverter hexadecimalConverter = new();
    private string hexadecimalNumber = "A";

    [Fact]
    public void HexadecimalToBinary()
    {
        string binaryNumber = "1010";

        Assert.Equal(binaryNumber, hexadecimalConverter.toBinary(hexadecimalNumber));
    }

    [Fact]
    public void HexadecimalToDecimal()
    {
        string decimalNumber = "10";

        Assert.Equal(decimalNumber, hexadecimalConverter.toDecimal(hexadecimalNumber));
    }

    [Fact]
    public void HexadecimalToOctal()
    {
        string octalNumber = "12";

        Assert.Equal(octalNumber, hexadecimalConverter.toOctal(hexadecimalNumber));
    }
}