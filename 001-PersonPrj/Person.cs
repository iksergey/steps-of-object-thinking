class Person
{
    public Person(string n, int a)
    {
        Name = n;
        Age = a;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }
}