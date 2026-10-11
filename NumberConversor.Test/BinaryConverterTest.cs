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
}
