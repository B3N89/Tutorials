// unsigned integer which is positive whole number
using System.ComponentModel;
using System.Diagnostics;

uint naturalNumber = 42;

// an integer which can be positive or negative whole number
int integerNumber = -42;

// a float is a single-precision fractional number
// the F or f suffix indicates a float literal
// the suffix is required to compile

float realNumber = 3.14159F;

// double is a double-precision fractional number
// it is the default for a number with a decimal point

double anotherRealNumber = 2.718281828459045;

int millionUsingUnderscores = 1_000_000;
Console.WriteLine(millionUsingUnderscores);

int twoUsingBinary = 0b10;
Console.WriteLine(twoUsingBinary);

int thirtyThreeUsingHex = 0x21;
Console.WriteLine(thirtyThreeUsingHex);

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexNotation = 0x_001E_8480;

Console.WriteLine(decimalNotation == binaryNotation);
Console.WriteLine(decimalNotation == hexNotation);


Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexNotation:N0}");

Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{binaryNotation:X}");
Console.WriteLine($"{hexNotation:X}");

Console.WriteLine($"int uses {sizeof(int)} bytes. and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes. and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes. and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");


Console.WriteLine("Using doubles:");    

double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    Console.WriteLine("0.1 + 0.2 is equal to 0.3");
}
else
{
    Console.WriteLine("0.1 + 0.2 is NOT equal to 0.3");
}

// changing values to show precision issue
// these should only be used for non calculations
// like graphics not things that can be compared directly
// height would be a good use case

a = 0.1;
b = 0.3;

if (a + b == 0.4)
{
    Console.WriteLine("0.1 + 0.3 is equal to 0.4");
}
else
{
    Console.WriteLine("0.1 + 0.3 is NOT equal to 0.4");
}   

float af = 0.1F;
float bf = 0.2F;
Console.WriteLine("Using floats:");
// F suffix indicates a float literal
// these are less precise than doubles
// and should be used only when needed to save memory
// and never for financial calculations
// where precision is important
if (af + bf == 0.3F)
{
    Console.WriteLine("0.1F + 0.2F is equal to 0.3F");
}
else
{
    Console.WriteLine("0.1F + 0.2F is NOT equal to 0.3F");
}

decimal ad = 0.1M;
decimal bd = 0.2M;

// M suffix indicates a decimal literal
// these should be used for financial calculations
// where precision is important
Console.WriteLine("Using decimals:");
if (ad + bd == 0.3M)
{
    Console.WriteLine("0.1M + 0.2M is equal to 0.3M");
}
else
{
    Console.WriteLine("0.1M + 0.2M is NOT equal to 0.3M");
}


unsafe
{
    Console.WriteLine($"Half uses {sizeof(Half)} bytes. and can store numbers in the range {Half.MinValue} to {Half.MaxValue}.");
    Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes. and can store numbers in the range {Int128.MinValue} to {Int128.MaxValue}.");
}