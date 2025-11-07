using System.Globalization;

partial class Program
{
    static public void TimesTable(byte number, byte size = 12)
    {
        WriteLine("The number {0} times table with {1} rows", number, size);

        for (int i = 0; i <= size; i++)
        {
            WriteLine("{0} multiplied by {1} is {2}", number, i, number * i);
        }
    }

    static public decimal CalculateTax(decimal amount, string regionCode = "GB")
    {
        decimal rate = regionCode switch
        {
            "CH" => 0.08M,
            "DK" or "NO" => 0.25M,
            "GB" or "FR" => 0.2M,
            "HU" => 0.27M,
            _ => 0.06M
        };

        return amount * rate;
    }

    static void ConfigureConsole(string culture = "en-GB", bool useComputerCulture = false)
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.DisplayName);
    }

    static void RunCardinalToOrdinal()
    {
        for (uint i = 1; i <= 1500; i++)
        {
            WriteLine(CardinalToOridinal(i));
        }
    }

    
    static void RunFactorials()
    {
        for (int i = -2; i <= 15; i++)
        {
            try
            {
                WriteLine("{1}! is {0:N0}", Factorials(i), i);
            }
            catch (OverflowException)
            {
                WriteLine("{0} is too big or too small!", i);
            }
            catch (ArgumentOutOfRangeException ex) 
            {
                   WriteLine(ex.Message, ex.StackTrace);
            }
        }
    }
    
    static int Factorials(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(message: $"Factorial function is defined for non-negative number input: {number}", paramName: nameof(number));
        } else if (number == 0)
        {
            return 1;
        } else
        {
            checked
            {
                return number * Factorials(number - 1);
            }
        }
    }
    
    static string CardinalToOridinal(uint number)
    {
        // you should use statements when need to make a choice/ perform an action
        // expressions are used when you want to compute things and return a value
        // this is an odd example but it shows clearly the special cases before 
        // applying the rules in the expression logic
        uint lastTwoDigits = number % 100;
        switch(lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                uint lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    }
}