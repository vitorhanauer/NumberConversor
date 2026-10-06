// See https://aka.ms/new-console-template for more information
String inputType = args[0];
String value = args[1];
String outputType = args[2];

DecimalConverter decimalConverter = new();
Binary binary = new();
String valueOutput = "";

// Binary Conversors
if(inputType == "-b" && outputType == "-d") valueOutput = $"{binary.toDecimal(value)}";
if(inputType == "-b" && outputType == "--hexa") valueOutput = binary.toHexadecimal(value);

if(inputType == "-d" && outputType == "-b") valueOutput = decimalConverter.toBinary(value);

Console.WriteLine(valueOutput);