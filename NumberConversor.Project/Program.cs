// See https://aka.ms/new-console-template for more information
using NumberConversor.Project;

string inputType = args[0];
string value = args[1];
string outputType = args[2];

DecimalConverter decimalConverter = new();
HexadecimalConverter hexadecimalConverter = new();
OctalConverter octalConverter = new();
BinaryConverter binary = new();
string valueOutput = "";

// Binary Conversors
if(inputType == "-b" && outputType == "-d") valueOutput = binary.toDecimal(value);
if(inputType == "-b" && outputType == "-x") valueOutput = binary.toHexadecimal(value);
if(inputType == "-b" && outputType == "-o") valueOutput = binary.toOctal(value);

if(inputType == "-d" && outputType == "-b") valueOutput = decimalConverter.toBinary(value);
if(inputType == "-d" && outputType == "-x") valueOutput = decimalConverter.toHexadecimal(value);
if(inputType == "-d" && outputType == "-o") valueOutput = decimalConverter.toOctal(value);

if(inputType == "-x" && outputType == "-b") valueOutput = hexadecimalConverter.toBinary(value);
if(inputType == "-x" && outputType == "-d") valueOutput = hexadecimalConverter.toDecimal(value);
if(inputType == "-x" && outputType == "-o") valueOutput = hexadecimalConverter.toOctal(value);

if(inputType == "-o" && outputType == "-b") valueOutput = octalConverter.toBinary(value);
if(inputType == "-o" && outputType == "-x") valueOutput = octalConverter.toHexadecimal(value);
if(inputType == "-o" && outputType == "-d") valueOutput = octalConverter.toDecimal(value);

Console.WriteLine(valueOutput);