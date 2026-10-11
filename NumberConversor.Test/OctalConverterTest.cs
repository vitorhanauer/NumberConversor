using NumberConversor.Project;

namespace NumberConversor.Test;

public class OctalConverterTest
{
    private OctalConverter OctalConverter = new();
    private string octalNumber = "12";

    [Fact]
    public void OctalToBinary()
    {
        string binaryNumber = "1010";

        Assert.Equal(binaryNumber, OctalConverter.toBinary(octalNumber));
    }

    [Fact]
    public void OctalToDecimal()
    {
        string decimalNumber = "10";

        Assert.Equal(decimalNumber, OctalConverter.toDecimal(octalNumber));
    }

    [Fact]
    public void OctalToHexadecimal()
    {
        string hexadecimalNumber = "A";

        Assert.Equal(hexadecimalNumber, OctalConverter.toHexadecimal(octalNumber));
    }
}