using NumberConversor.Project;

namespace NumberConversor.Test;

public class BinaryConverterTest
{
    [Fact]
    public void BinaryToDecimal()
    {
        Binary binaryConverter = new();
        string binaryNumber = "1010";
        string decimalNumber = "10";

        Assert.Equal(decimalNumber, binaryConverter.toDecimal(binaryNumber));
    }

    [Fact]
    public void BinaryToHexadecimal()
    {
        Binary binaryConverter = new();
        string binaryNumber = "1010";
        string hexadecimalNumber = "A";

        Assert.Equal(hexadecimalNumber, binaryConverter.toHexadecimal(binaryNumber));
    }

    [Fact]
    public void BinaryToOctal()
    {
        Binary binaryConverter = new();
        string binaryNumber = "1010";
        string octalNumber = "12";

        Assert.Equal(octalNumber, binaryConverter.toOctal(binaryNumber));
    }
}
