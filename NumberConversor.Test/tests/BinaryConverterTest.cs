using NumberConversor.Project;

namespace NumberConversor.Test;

public class BinaryConverterTest
{
    private BinaryConverter binaryConverter = new();
    private string binaryNumber = "1010";

    [Fact]
    public void BinaryToDecimal()
    {
        string decimalNumber = "10";

        Assert.Equal(decimalNumber, binaryConverter.toDecimal(binaryNumber));
    }

    [Fact]
    public void BinaryToHexadecimal()
    {
        string hexadecimalNumber = "A";

        Assert.Equal(hexadecimalNumber, binaryConverter.toHexadecimal(binaryNumber));
    }

    [Fact]
    public void BinaryToOctal()
    {
        string octalNumber = "12";

        Assert.Equal(octalNumber, binaryConverter.toOctal(binaryNumber));
    }
}
