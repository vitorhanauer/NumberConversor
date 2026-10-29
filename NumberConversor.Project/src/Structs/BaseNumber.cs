namespace NumberConversor.Project.Structs;

public readonly struct BaseNumber
{
    private readonly string _value;
    private BaseNumber(string value) => _value = value;

    public static BaseNumber Decimal => new BaseNumber("-d");
    public static BaseNumber Binary => new BaseNumber("-b");
    public static BaseNumber Octal => new BaseNumber("-b");
    public static BaseNumber Hexadecimal => new BaseNumber("-x");

    public override string ToString() => _value;
}