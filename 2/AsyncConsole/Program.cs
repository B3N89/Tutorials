
HttpClient client = new();

HttpResponseMessage response = await client.GetAsync("https://www.apple.com/");

WriteLine($"Response status code: {response.StatusCode}");

WriteLine("Apple's homepage has {0:N0} bytes.", arg0: response.Content.Headers.ContentLength ?? 0);


// this is answers to chapter 2.1 questions

//1
// answer is #error version

// Compiler version: '4.14.0-3.25465.8 (b0a9adbf)'. Language version: 13.0.

/// The build failed. Fix the build errors and run again.
WriteLine(Environment.Version);

// think you could add some meta data into the assembly to get the compiler used etc and then just 
// reflect that out at runtime? 


// 2 inline

/* 


multi line comment
 */

//3 verbatim is exactly as typed no escape sequences
// string path = @"C:\MyFolder\MyFile.txt";

// interpolated is with $ and allows expressions inside {}

//4 float and double are not precise for financial calculations decimal is better
// the reason being that float and double are binary floating point types and cannot accurately represent some decimal fractions
// decimal is a decimal floating point type and can represent decimal fractions exactly


// 5 you can determine how many bytes a type uses with sizeof() for primitive types
// for non primitive types you can use Marshal.SizeOf() from System.Runtime.InteropServices

// 6 use the var keyword when the type is obvious from the right side of the assignment
// or when the specific type is not important and you want to use the most general type possible

// 7 = new () is target typed new expression

//8 dynamic shouuldn't be used unless working with something like javascript 
// as you don't have compile time type checking and its also not performant

//9
// var test = WriteLine(format: {0,0} {1,1}, arg0: "test", arg1: 123); the 2nd object should right align


// 10 
// spaces seperate arguements for a console app

// 2.2

// telephone number formatted string

// persons height double with 2 decimal places

// persons age int or byte (0 - 255)

// salary decimal

// ISBN string formatted

// books price decimal

// shipping wieght double

// countries population uint with thousand separators

// stars in the universe ulong with thousand separators

// num of employes (max 50k) ushort to save memory with thousand separators


