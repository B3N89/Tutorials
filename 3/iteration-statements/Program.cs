using System.Runtime.CompilerServices;
using System.Transactions;

int x = 0;

while (x < 10)
{
    WriteLine(x);
    x++;
}


string? actualPassword = "";

string? password;

int attempt = 0;

int maxAttempts = 3;

do
{
    Write("Enter your password: ");
    password = ReadLine();
} while (password != actualPassword &&  ++attempt < maxAttempts);

string resultMessage = (attempt >= maxAttempts) ? "You have exceeded the maximum number of attempts." : "You entered the correct password.";

 WriteLine(resultMessage);


for (int y = 0; y < 10; y++)
{
    WriteLine(y);
}

WriteLine("-----");

for (int y = 0; y < 10; y += 3)
{
    WriteLine(y);
}

WriteLine("-----");


string[] names = { "Alice", "Bob", "Charlie" };

foreach (string name in names)
{
    WriteLine("Name: {0} \n Length: {1}", name, name.Length);

}

// foreach will work with any type that implements IEnumerable
// it shuold have a getEnumerator method that returns an object
// the returned object should have a MoveNext method and a Current property

#region ExampleEnumerator and EvenNumberEnumerator classes
var example = new ExampleEnumerator(5);
WriteLine("Using ExampleEnumerator:");
foreach (var number in example)
{
    WriteLine(number);
}


var evenNumberExample = new EvenNumberEnumerator(20);
WriteLine("Using EvenNumberEnumerator:");
foreach (var number in evenNumberExample)
{
    WriteLine(number);
}

class ExampleEnumerator
{
    private static int _max;

    // Constructor
    public ExampleEnumerator(int max)
    {
        _max = max;
    }

    //method used by foreach
    public Enumerator GetEnumerator()
    {
        return new Enumerator(_max);
    }

    //struct that implements the enumerator
    public struct Enumerator
    {
        private readonly int _max;
        private int _current;

        internal Enumerator(int max)
        {
            _max = max;
            _current = -1;
        }

        public int Current => _current;

        public bool MoveNext()
        {
            if (_current + 1 >= _max)
                return false;

            _current++;
            return true;
        }
    }
}



class EvenNumberEnumerator : IEnumerable<int>
{
    private readonly int _max;

    public EvenNumberEnumerator(int max)
    {
        _max = max;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return new Enumerator(_max);
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        // delegate to the generic version
        return GetEnumerator();
    }


    public struct Enumerator : IEnumerator<int>
    {
        private readonly int _max;
        private int _current;

        internal Enumerator(int max)
        {
            _max = max;
            _current = -2; // start before the first even number (0)
        }

        public int Current => _current;

        object? System.Collections.IEnumerator.Current => _current;
        public bool MoveNext()
        {
            _current += 2;
            return _current <= _max;
        }

        public void Reset()
        {
            _current = -2;
        }

        public void Dispose()
        {
            // nothing to clean up, but required by interface
        }
    }
}
#endregion