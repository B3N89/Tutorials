namespace SelectionStatements.Classes;

class Animal
{
    public string? Name;
    public DateTime BirthDate;
    public byte Legs;
}

class Cat : Animal
{
    public bool isDomestic;
}

class Spider: Animal
{
    public bool isPoisonous;
}