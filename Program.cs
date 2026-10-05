// See https://aka.ms/new-console-template for more information
String inputType = args[0];
String value = args[1];
String outputType = args[2];

Console.WriteLine($"Input Type: {inputType}");
Console.WriteLine($"Value: {value}");
Console.WriteLine($"Output Type: {outputType}");

if(inputType == "-b" && outputType == "-d")
{
    String[] list = value.Select(c => c.ToString()).Reverse().ToArray();
    int valueOutput = 0;
    for (int i = 0; i < list.Length; i++)
    {
        int digit = ((int)Math.Pow(2,i));
        valueOutput += Int16.Parse(list[i]) * digit;
    }

    Console.WriteLine(valueOutput);
}