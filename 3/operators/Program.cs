#region explring unary operators

int a = 3;

int b = a++;

WriteLine($"a: {a}, b: {b}");

int c = 3;

int d = ++c;

WriteLine($"c: {c}, d: {d}");

// post fix assigns the original value of a then increments a (not b)

// pre fix increments c then assigns the incremented value to d 

// never actually combine assignment with unary operators like this
// it is done here just for demonstration purposes
// but avoid doing this in real code
// as it can lead to confusing code

#endregion

#region exploring binary operators

int e = 11;
int f = 3;

WriteLine("e is {0}, f is {1}", e, f);
WriteLine("e + f is {0}", e + f);
WriteLine("e - f is {0}", e - f);
WriteLine("e * f is {0}", e * f);
WriteLine("e / f is {0}", e / f);
WriteLine("e % f is {0}", e % f);

double g = 11.0;


WriteLine("g is {0:N1}", g);
WriteLine("g / f is {0}", g / f);


#endregion


#region exploring assignment operators

int p = 6;
WriteLine("Initial p: {0}", p);

p+= 3; // p = p + 3
WriteLine("p after += 3: {0}", p);

p-= 2; // p = p - 2
WriteLine("p after -= 2: {0}", p);

p *= 3; // p = p * 3
WriteLine("p after *= 3: {0}", p);

p /= 3; // p = p / 3
WriteLine("p after /= 3: {0}", p);

#endregion

#region exploring null coalescing operator

string? authorName = ReadLine();

// if authorName is null, assign it to "Unknown author"
// however reading input from console will never return null
// it will return empty string if nothing is entered    

int maxNameLength = authorName?.Length ?? 30;

authorName ??= "Unknown author";

WriteLine($"Author name: {authorName}, max length: {maxNameLength}");

authorName = string.IsNullOrEmpty(authorName) ? "Unknown author" : authorName;

maxNameLength = authorName?.Length ?? 30;

WriteLine($"Author name: {authorName}, max length: {maxNameLength}");

#endregion

#region exploring logical operators

bool h = true;

bool j = false;

WriteLine("h is {0}, j is {1, -5}", h, j);

WriteLine("AND    (H    | J)");
WriteLine("H      | {0, -5} | {1, -5}", h & h, h & j);
WriteLine("J      | {0, -5} | {1, -5}", j & h, j & j);
WriteLine();

WriteLine("OR     (H    | J)");
WriteLine("H      | {0, -5} | {1, -5}", h | h, h | j);
WriteLine("J      | {0, -5} | {1, -5}", j | h, j | j);
WriteLine();

WriteLine("XOR    (H    | J)");
WriteLine("H      | {0, -5} | {1, -5}", h ^ h, h ^ j);
WriteLine("J      | {0, -5} | {1, -5}", j ^ h, j ^ j);
WriteLine();

// XOR is one but not the other!! so needs an exactly one true value to be true

#endregion

#region exploring conditional logical operators

WriteLine("h and DoStuff(): {0}", h & DoStuff());
WriteLine("j and DoStuff(): {0}", j & DoStuff());

WriteLine("h and DoStuff(): {0}", h && DoStuff());
// since j is false, DoStuff() is never called
// this is called short-circuiting
WriteLine("j and DoStuff(): {0}", j && DoStuff());



static bool DoStuff()
{
    WriteLine("Doing Stuff!");

    return true;
}

#endregion


#region exploring bitwise and binary shift operators

// these operators work at the bit level
// they are mainly used in low level programming
// can be efficient for certain tasks

int x = 10;

int y = 6;

WriteLine("Expression  Decimal | Binary");
WriteLine("-------------------------------");
WriteLine("x           {0,7} | {0:B8}", x);
WriteLine("y           {0,7} | {0:B8}", y);
WriteLine("x & y       {0,7} | {0:B8}", x & y);
WriteLine("x | y       {0,7} | {0:B8}", x | y);
WriteLine("x ^ y       {0,7} | {0:B8}", x ^ y);

// Left shift x by three bit columns
WriteLine("x << 3      {0,7} | {0:B8}", x << 3);
// multiply x by 8
WriteLine("x * 8       {0,7} | {0:B8}", x * 8);
// Right shift y by one bit column
WriteLine("y >> 1      {0,7} | {0:B8}", y >> 1);


// use cases for these are for example:
// - storing multiple boolean flags in a single integer
// - performing fast mathematical operations (multiplications/divisions by powers of two)
// - low-level graphics programming (manipulating color values)
// - network programming (working with binary protocols)
// - cryptography (bitwise operations in encryption algorithms)
// - optimizing performance-critical code sections
// - embedded systems programming (direct hardware manipulation)
// - implementing certain algorithms (e.g., hash functions, checksums)
// - game development (efficient data packing and manipulation)
// - systems programming (operating systems, device drivers)
// - data compression algorithms
// - file permission management
#endregion
