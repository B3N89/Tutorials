int x = 1;

double y = x;

WriteLine("x is {0}, y is {1}", x, y);


double c = 9.8;

int d = (int)c;

WriteLine("c is {0}, d is {1}", c, d);


long e = 10;

int f = (int)e;

WriteLine("e is {0:N0}, f is {1:N0}", e, f);

e = long.MaxValue;

f = (int)e;

WriteLine("e is {0:N0}, f is {1:N0}", e, f);

e = 5_000_000_000;

f = (int)e;

WriteLine("e is {0:N0}, f is {1:N0}", e, f);


int b = int.MaxValue;

WriteLine("b as decimal {0:N0}, b as binary {0:B}", b);

int m = 8;

for (int i = m; i > -9; i--)
{
    WriteLine("i as decimal {0:N0}, b as binary {0:B}", i);
}

int t = int.MinValue;

WriteLine("value for t is {0}", t);

#region Convert

// using convert rounds numbers up rather then trimming like casting would

double g = 9.8;

int h = ToInt32(g);

WriteLine("g is {0}, h is {1}", g, h);

double[,] doubles =
{
    { 9.49, 9.5, 9.51 },
    { 10.49, 10.5, 10.51 },
    { 11.49, 11.5, 11.51 },
    { 12.49, 12.5, 12.51 },
    { -12.49, -12.5, -12.51 },
    { -11.49, -11.5, -11.51 },
    { -10.49, -10.5, -10.51 },
    { -9.49, -9.5, -9.51 },
};

WriteLine("| double | ToInt32 | double | ToInt32 |");

for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 3; j++)
    {
        WriteLine("| {0,6} | {1,7}", doubles[i, j], ToInt32(doubles[i, j]));
    }
    WriteLine("| ");
}

foreach (double n in doubles)
{
     // 🧮 Banker's Rounding (MidpointRounding.ToEven)
            // Rounds to the nearest even number when the value is exactly halfway between two integers.
            // Example: 2.5 → 2, 3.5 → 4, -2.5 → -2, -3.5 → -4
            WriteLine("Math.Round({0}, 0, MidpointRounding.ToEven) = {1}", n,
                Math.Round(n, 0, MidpointRounding.ToEven));

            // 📈 Traditional rounding (MidpointRounding.AwayFromZero)
            // Always rounds .5 *away* from zero.
            // Example: 2.5 → 3, -2.5 → -3
            WriteLine("Math.Round({0}, 0, MidpointRounding.AwayFromZero) = {1}", n,
                Math.Round(n, 0, MidpointRounding.AwayFromZero));

            // ✂️ MidpointRounding.ToZero
            // Rounds .5 *toward* zero — effectively truncates at midpoint.
            // Example: 2.5 → 2, -2.5 → -2
            WriteLine("Math.Round({0}, 0, MidpointRounding.ToZero) = {1}", n,
                Math.Round(n, 0, MidpointRounding.ToZero));

            // ⬆️ MidpointRounding.ToPositiveInfinity
            // For midpoint values, rounds *upward* (toward +∞).
            // Example: 2.5 → 3, -2.5 → -2
            WriteLine("Math.Round({0}, 0, MidpointRounding.ToPositiveInfinity) = {1}", n,
                Math.Round(n, 0, MidpointRounding.ToPositiveInfinity));

            // ⬇️ MidpointRounding.ToNegativeInfinity
            // For midpoint values, rounds *downward* (toward -∞).
            // Example: 2.5 → 2, -2.5 → -3
            WriteLine("Math.Round({0}, 0, MidpointRounding.ToNegativeInfinity) = {1}", n,
                Math.Round(n, 0, MidpointRounding.ToNegativeInfinity));
}


#endregion


#region toString

int number = 12;

WriteLine(number.ToString());
bool boolean = true;

WriteLine(boolean.ToString());

DateTime now = DateTime.Now;

WriteLine(now.ToString());

object me = new();

WriteLine(me.ToString());

#endregion


#region base64encoding

byte[] binaryObject = new byte[128];

Random.Shared.NextBytes(binaryObject);

WriteLine("Binary Object as bytes");

for (int index =0; index < binaryObject.Length; index++)
{
    // outputting as hexidecimal
    Write("{0:X2}", binaryObject[index]);
}

WriteLine();

string encoded = ToBase64String(binaryObject);

WriteLine("Binary Object as Base64: {0}", encoded);


#endregion

#region  parsing

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int friends = int.Parse("27");

DateTime birthday = DateTime.Parse("4 June 1980");

WriteLine("I have {0} friends to invite to my party", friends);

WriteLine("My birthday is {0}", birthday);
WriteLine("My birthday is {0:D}", birthday);

Write("How many pokemone cards have you got?");

string? input = ReadLine();

if (int.TryParse(input, out int result))
{
    WriteLine("You have {0}", result);
} else
{
    WriteLine("I could not parse !!");
}


#endregion