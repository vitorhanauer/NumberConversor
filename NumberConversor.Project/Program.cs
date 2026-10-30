// See https://aka.ms/new-console-template for more information
using NumberConversor.Project.Converters;
using NumberConversor.Project.Structs;

string inputType = args[0];
string value = args[1];
string outputType = args[2];

IConverter converter = ConverterFactory.create(inputType);
string valueOutput = "";

if(outputType == BaseNumber.Binary.ToString()) valueOutput = converter.toBinary(value);
if(outputType == BaseNumber.Decimal.ToString()) valueOutput = converter.toDecimal(value);
if(outputType == BaseNumber.Hexadecimal.ToString()) valueOutput = converter.toHexadecimal(value);
if(outputType == BaseNumber.Octal.ToString()) valueOutput = converter.toOctal(value);

Console.WriteLine(valueOutput);