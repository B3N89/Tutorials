using SelectionStatements.Classes;
string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Password is too short.");
}
else
{
    WriteLine("Password length is good.");
}

// we shluld avoid doing this due to boxing
// this means it will be slower and use more memory
// because the int value type is being wrapped
// in an object on the heap


object o = 3;
int j = 4;
if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an integer so it cannot multiply!");
}

int number = Random.Shared.Next(1, 7);
WriteLine("My random number is {0}", number);


// goto is generally discouraged but can be used in switch statements
// to jump to another case or to a label
switch (number)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;

    case 3:

    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}

WriteLine("After switch statement");
A_label: WriteLine("After A label");

var animals = new Animal?[]
{
    new Cat { Name = "Sophie", BirthDate = new(year: 1995, month: 6, day: 12), Legs = 4, isDomestic = true },
    new Spider { Name = "Charlotte", BirthDate = DateTime.Today, Legs = 8, isPoisonous = false }
};
        
foreach (Animal? animal in animals)
{
    switch (animal)
    {
        case Cat c when c.isDomestic:
            WriteLine($"{c.Name} is a domestic cat.");
            break;
        case Cat c:
            WriteLine($"{c.Name} is a wild cat.");
            break;
        case Spider s when s.isPoisonous:
            WriteLine($"{s.Name} is a poisonous spider.");
            break;
        case Spider s:
            WriteLine($"{s.Name} is a non-poisonous spider.");
            break;
        case null:
            WriteLine("Animal is null.");
            break;
        default:
            WriteLine("Unknown animal type.");
            break;
    }

    string message = animal switch
    {
        Cat fourleggedCat when fourleggedCat.Legs == 4
            => $"{fourleggedCat.Name} says Meow!",
        Cat wildCat when wildCat.isDomestic == false
            => $"{wildCat.Name} says Roar!",
        Spider eightLeggedSpider when eightLeggedSpider.Legs == 8
            => $"{eightLeggedSpider.Name} says Hiss!",
        Spider webSpider when webSpider.isPoisonous
            => $"{webSpider.Name} says Bite!",
        null
            => "Animal is null.",
        _
            => "Unknown animal type."
    };

    WriteLine(message);
}