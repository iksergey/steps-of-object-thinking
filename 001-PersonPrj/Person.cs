class Person
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }

    public string ToString()
    {
        return $"Имя: {this.Name} возраст: {this.Age}";
    }
}