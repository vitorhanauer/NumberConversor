// See https://aka.ms/new-console-template for more information
using NumberConversor.Project.Converters;

string inputType = args[0];
string value = args[1];
string outputType = args[2];

IConverter converter = ConverterFactory.create(inputType);
string valueOutput = "";

if(outputType == "-b") valueOutput = converter.toBinary(value);
if(outputType == "-d") valueOutput = converter.toDecimal(value);
if(outputType == "-x") valueOutput = converter.toHexadecimal(value);
if(outputType == "-o") valueOutput = converter.toOctal(value);

Console.WriteLine(valueOutput);