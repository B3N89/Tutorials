using System.Data;
using System.Runtime.CompilerServices;

string[] names;


names = new string[4];
names[0] = "Zoe";
names[1] = "Alice";
names[2] = "Bob";
names[3] = "Charlie";

foreach (string name in names)
{
    WriteLine("name is {0} at position {1}", name, Array.IndexOf(names, name));
}


string[] moreNames = { "Zoe", "Alice", "Bob", "Charlie" };
foreach (string name in moreNames)
{
    WriteLine("name is {0} at position {1}", name, Array.IndexOf(moreNames, name));
}


string[,] grid =
{
    { "1", "2", "3" },
    { "4", "5", "6" }
};

WriteLine("2D array element at row 1, column 2 is {0}", grid[1, 2]);
WriteLine("2D array element at row 0, column 1 is {0}", grid[0, 1]);
WriteLine("The 2D array has {0} rows and {1} columns", grid.GetLength(0), grid.GetLength(1));


// you can also use get upperbound here
for (int row = 0; row < grid.GetLength(0); row++)
{
    for (int col = 0; col < grid.GetLength(1); col++)
    {
        WriteLine("Element at row {0}, column {1} is {2}", row, col, grid[row, col]);
    }
}

string[,] grid2 = new string[3, 4]; ///allocate memory

grid2[0, 0] = "Alpha";
grid2[1, 1] = "Beta";
grid2[0, 2] = "Charlie";

for (int row = 0; row < grid2.GetLength(0); row++)
{
    for (int col = 0; col < grid2.GetLength(1); col++)
    {
        if (!string.IsNullOrEmpty(grid2[row, col]))
        {
            WriteLine("Element at row {0}, column {1} is {2}", row, col, grid2[row, col]);
        }
        else
        {
            WriteLine("Element at row {0}, column {1} is {2}", row, col, "is null");
        }
    }
}


string[][] jagged =
{
    ["Alpha", "Beta", "Gamma"],
    ["Anne", "Ben", "Isla", "Zack"],
    ["Dog", "Cat"]
};

WriteLine("Number of rows in jagged {0}", jagged.GetLength(0));

foreach (string[] row in jagged)
{
    WriteLine("Number of columns in {1} is {0}", row.Length, Array.IndexOf(jagged, row));
    foreach (string col in row)
    {
        WriteLine("The value of {1} is {0}", col, Array.IndexOf(row, col));
    }
}


#region pattern matching arrays

int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

int[] oneTwoNumbers = { 1, 2 };

int[] oneTwoTenNumbers = { 1, 2, 10 };

int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };

int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 4, 8, 13, 21, 34, 55, 89 };

int[] emptyNumbers = [];

int[] threeNumbers = { 9, 7, 5 };

int[] sixNumbers = { 9, 7, 5, 4, 2, 10 };

WriteLine("{0}, {1}", nameof(sequentialNumbers), CheckSwitch(sequentialNumbers));

WriteLine("{0}, {1}", nameof(oneTwoNumbers), CheckSwitch(oneTwoNumbers));

WriteLine("{0}, {1}", nameof(oneTwoTenNumbers), CheckSwitch(oneTwoTenNumbers));

WriteLine("{0}, {1}", nameof(oneTwoThreeTenNumbers), CheckSwitch(oneTwoThreeTenNumbers));

WriteLine("{0}, {1}", nameof(primeNumbers), CheckSwitch(primeNumbers));

WriteLine("{0}, {1}", nameof(fibonacciNumbers), CheckSwitch(fibonacciNumbers));

WriteLine("{0}, {1}", nameof(emptyNumbers), CheckSwitch(emptyNumbers));

WriteLine("{0}, {1}", nameof(threeNumbers), CheckSwitch(threeNumbers));

WriteLine("{0}, {1}", nameof(sixNumbers), CheckSwitch(sixNumbers));

static string CheckSwitch(int[] values) => values switch
{
    [] => "Empty array",
    [1, 2] => "Contains 1 and 2",
    [1, 2, 10] => "Starts with 1, 2 and ends with 10",
    [1, 2, 3, 10] => "Starts 1, 2, 3 and ends with 10",
    [1, 2, ..] => "Starts with 1 and 2",
    [.., 10] => "Ends with 10",
    [var first, var second, ..] => $"First two numbers are {first} and {second}",
    _ => "No match"
};



#endregion


#region inline arrays (high performance)

// these oculd be good for writing a game engine or numerics library but needs to be maanged properly

var values = new FourInts();

values[0] = 10;
values[1] = 20;
values[2] = 30;
values[3] = 40;

for (int i = 0; i < 4; i++) WriteLine(values[i]);


[InlineArray(4)]
public struct FourInts
{
    private int _element0; // compiler automatically generates _element1, _element2, _element3
}
#endregion

// use arrays when you don't need to add / remove items as they are more performant hwoever if you need
// to manipulate the data stored then using a collection