using System.Xml;



object height = 1.88; // storing a double in an object box


object name = "Ben"; // storing a string in an object box

Console.WriteLine($"{name} is {height} meters tall.");

// int length1 = name.Length;

int length2 = ((string)name).Length;

Console.WriteLine($"{name} has {length2} letters.");

dynamic something;

something = new[] { 3, 5, 7 };

something = 12;

something = "Ben";


Console.WriteLine($"{something} has {something.Length} letters.");

Console.WriteLine($"{something.GetType()} is the runtime type of something.");

// Limitations of dynamic are intelisense cannot work as it does not know the type at compile time
// and errors will only show at runtime not compile time

var population = 67_000_000;
var weight = 1.88;
var price = 4.99M; 
var fruit = "Apples";
var letter = 'Z';
var happy = true;

var xml1 = new XmlDocument();

// only works with versions c# 3 and later

XmlDocument xml2 = new XmlDocument();

// works with all versions of C# and .NET

XmlDocument xml3 = new();

// target typed new expression avaiable in c# 9 and later 
// these arre good when instantiating arrays and objects
// best practice to use this as you can see the type from the left side of the assignment
// also reduces code duplication



var file1 = File.CreateText("myfile.txt");

StreamWriter file2 = File.CreateText("myfile.txt");
/// bad use of var because you cannot tell the type by looking at it
/// should use the second version where you can see the type
/// i.e Streamwriter not var
/// if in doubt spell it out
/// 


// string is reference type and therefore the default value is null
// int is a value type and therefore the default value is 0

Console.WriteLine($"default(string) is {(default(string))}");
Console.WriteLine($"default(int) is {default(int)}");
Console.WriteLine($"default(bool) is {default(bool)}");
Console.WriteLine($"default(DateTime) is {default(DateTime)}");

int number = 13;

Console.WriteLine($"number set to : {number}");

number = default;
Console.WriteLine($"number reset to default : {number}");






