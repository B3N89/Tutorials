using System.Security.Cryptography;

WriteLine("Before parsing");

WriteLine("What is your age?");

string? input = ReadLine();

try
{
    if (string.IsNullOrEmpty(input))
    {
        WriteLine("You didn't enter anything!!");
        return;
    }

    int age = int.Parse(input);
    WriteLine("You are {0} years old", age);

}
catch (FormatException)
{
    WriteLine("The age you entered is not in the correct format");
}
catch (OverflowException)
{
    WriteLine("Your age is either too big or too small");
}
catch (Exception ex)
{
    // you can use this to determine the exceptions you should be catching
    // before going to production delete this as its a catch 'em all anti pattern
    // in real prodiction code you should have a central place to catch all other errors
    // which oyub can use to find unexpected errors
    WriteLine("{0} says {1}", ex.GetType(), ex.Message);
}
WriteLine("After parsing");

Write("Enter an amount:");
string? amount = ReadLine();

if (string.IsNullOrEmpty(amount))
{
    return;
}

try
{

    decimal amountValue = decimal.Parse(amount);
    WriteLine("Amount formatted as currency: {0:C}", amountValue);
}
catch (FormatException) when (amount.Contains("$"))
{
    WriteLine("Amounts cannot use the dollar sign!");

}
catch (FormatException)
{
    WriteLine("Amounts must only contain digits!!");

}

checked
{

    int x = int.MaxValue - 1;

    try
    {


        WriteLine("initial value {0}", x);

        x++;

        WriteLine("After increment {0}", x);

        x++;

        WriteLine("After increment {0}", x);

        x++;

        WriteLine("After increment {0}", x);
    }
    catch (OverflowException)
    {
        WriteLine("the code overflowed but we caught the exception");
    }
}

unchecked
{
    int y = int.MaxValue + 1;

       WriteLine("initial value {0}", y);

        y--;

        WriteLine("After increment {0}", y);

        y--;

        WriteLine("After increment {0}", y);

        y--;

        WriteLine("After increment {0}", y);
}