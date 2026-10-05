// See https://aka.ms/new-console-template for more information
String inputType = args[0];
String value = args[1];
String outputType = args[2];

Binary binary = new();
int valueOutput = 0;

if(inputType == "-b" && outputType == "-d") valueOutput = binary.toDecimal(value);
Console.WriteLine(valueOutput);