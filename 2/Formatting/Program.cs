int numberOfApples = 12;

decimal pricePerApple = 0.35M;


WriteLine(format: "{0} apples cost {1:C}", arg0: numberOfApples, arg1: numberOfApples * pricePerApple);  

string formatted = string.Format(format: "{0} apples cost {1:C}", arg0: numberOfApples, arg1: numberOfApples * pricePerApple);

// WriteToFile(formatted);



WriteLine(format: "The price of one apple is {0:C2}, the number of apples we have is {1} as of {2}, ", arg0: pricePerApple, arg1: numberOfApples, arg2: DateTime.Now);


// this is best practice as its easier to read and maintain
WriteLine(format: "{0},{1},{2},{3},{4}", "this", "is", "a", "test", "string");

WriteLine($"{numberOfApples} apples cost {numberOfApples * pricePerApple:C}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
WriteLine();

// ...existing code...
WriteLine(format: "{0,-10} {1,6}", arg0: "Name", arg1:"Count"); 
// {0,-10} -> place first argument in a 10-character field, left-aligned (pads right with spaces if shorter).
// {1,6}   -> place second argument in a 6-character field, right-aligned (pads left with spaces).
// No numeric format given, so the value is rendered with its default ToString(); useful for simple column headings.

WriteLine(format: "{0,-10} {1,6:N0}", arg0: applesText, arg1: applesCount);
// {0,-10}            -> left-align the name in a 10-char column (keeps columns aligned).
// {1,6:N0}           -> "N0" = Number format with zero decimal places; inserts thousand separators per current culture.
//                     -> Right-align in a width of 6; if the formatted number needs more space it expands the field.
// Example output (en-US): "Apples      1,234" — N0 turns 1234 into "1,234".

WriteLine(format: "{0,-10} {1,6:0000.0}", arg0: applesText, arg1: applesCount);
// {0,-10}            -> same left-aligned name column.
// {1,6:0000.0}       -> "0" is a required digit placeholder: at least 4 integer digits (zero-padded if needed) and exactly 1 decimal digit.
//                     -> For 1234 this prints "1234.0"; for 5 it would print "0005.0".
//                     -> Right-aligned to width 6; note the formatted text length may equal or exceed the width.

WriteLine(format: "{0,-10} {1,6:####.#}", arg0: applesText, arg1: applesCount);
// {0,-10}            -> name column.
// {1,6:####.#}       -> "#" is an optional digit placeholder: no forced leading zeros, shows digits only where present.
//                     -> One optional fractional digit (shows it only if non-zero). For 1234 this prints "1234" (no trailing ".").
//                     -> Use when you want compact output without unnecessary zeros.

WriteLine(format: "{0,-10} {1,6:0.0,,}", arg0: bananasText, arg1: bananasCount);
// {0,-10}            -> name column.
// {1,6:0.0,,}        -> each trailing comma in the format scales the number by 1,000 (so two commas divide by 1,000,000).
//                     -> "0.0" forces at least one integer digit and one decimal rounded to 1 place.
//                     -> For 56,789: 56,789 / 1,000,000 ≈ 0.0568 -> formatted as "0.1" (rounded to one decimal).
//                     -> Handy for showing values in thousands/millions with a compact notation.

WriteLine(format: "{0,-10} {1,6:N0}", arg0: bananasText, arg1: bananasCount);
// {0,-10}            -> name column.
// {1,6:N0}           -> same as the apples N0 line: group-separators, no decimals, right-aligned.
//                     -> For 56,789 prints "56,789" (or "56 789" depending on culture).

WriteLine(format: "{0,-10} {1,6:000.0%}", arg0: bananasText, arg1: bananasCount);
// {0,-10}            -> name column.
// {1,6:000.0%}       -> "%" multiplies the value by 100 and appends a percent sign.
//                     -> "000.0" requires at least 3 integer digits (zero-padded) and one decimal place.
//                     -> For bananasCount=56789 this becomes 5,678,900.0% (huge number) — percent is rarely used with raw counts.
//                     -> Width 6 may be too small for the resulting string; field expands if needed.

WriteLine(format: "{0,-10} {1,6:\\##,###\\#}", arg0: bananasText, arg1: bananasCount);
// {0,-10}            -> name column.
// {1,6:\##,###\#}    -> backslash escapes (in the custom numeric format) instruct the formatter to emit the next character literally.
//                     -> The pattern intends to produce a literal '#' before and after the grouped number: "#56,789#".
//                     -> Important: because this is a normal C# string literal, backslashes must be escaped in source (\\) so at runtime the format sees single backslashes.
//                     -> Use verbatim string (@) or double backslashes in the source to get the desired literal characters in the final output.

WriteLine(format: "{0,-10} {1,6:[0];(0);Zero}", arg0: bananasText, arg1: bananasCount);
// {0,-10}            -> name column.
// {1,6:[0];(0);Zero} -> a three-part custom format: PositivePattern;NegativePattern;ZeroPattern.
//                     -> PositivePattern "[0]" prints the number inside square brackets, e.g. "[56789]".
//                     -> NegativePattern "(0)" prints negatives in parentheses, e.g. "(56789)" (see next line).
//                     -> ZeroPattern "Zero" prints the literal word "Zero" when the value == 0.
//                     -> This is useful when you want different displays for +, -, and zero values.

WriteLine(format: "{0,-10} {1,6:[0];(0);Zero}", arg0: bananasText, arg1: -bananasCount);
// same format as previous but feeding a negative value:
// -> negative value triggers the (0) pattern; -56789 prints "(56789)".

WriteLine(format: "{0,-10} {1,6:[0];(0);Zero}", arg0: bananasText, arg1: 0);
// same format but value == 0:
// -> uses the Zero pattern and prints the literal "Zero".
//
// General notes:
// - Alignment (e.g. -10, 6) controls column layout; numeric format strings control precision, padding, grouping, scaling, literals and conditional displays.
// - Format results are affected by CultureInfo (thousand separators, decimal separator, percent symbol). Pass a CultureInfo or set DefaultThreadCurrentCulture when you need consistent symbols.
// - If the formatted text is wider than the specified width the field will expand; it won't truncate the content.


Write("Type your first name: ");
string? firstName = ReadLine();
Write("Type your age: ");
string age = ReadLine()!;
WriteLine($"Hello {firstName}, you are {age} years old.");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();

WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);