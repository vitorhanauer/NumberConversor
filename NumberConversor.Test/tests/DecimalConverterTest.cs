using NumberConversor.Project.Converters;

namespace NumberConversor.Test;

public class DecimalConverterTest
{
    private DecimalConverter decimalConverter = new() ;
    private string decimalNumber = "10";

    [Fact]
    public void DecimalToBinary()
    {
        string binaryNumber = "1010";

        Assert.Equal(binaryNumber, decimalConverter.toBinary(decimalNumber));
    }

    [Fact]
    public void DecimalToHexadecimal()
    {
        string hexadecimalNumber = "A";

        Assert.Equal(hexadecimalNumber, decimalConverter.toHexadecimal(decimalNumber));
    }

    [Fact]
    public void DecimalToOctal()
    {
        string octalNumber = "12";

        Assert.Equal(octalNumber, decimalConverter.toOctal(decimalNumber));
    }
}