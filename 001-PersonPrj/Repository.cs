class Repository
{
    private Person[] people;
    private int count;
    private int index = 0;
    public Repository(int count)
    {
        this.count = count;
        people = new Person[count];
    }

    public void Append(Person person)
    {
        people[index] = person;
        index++;
    }

    public void Print()
    {
        for (int i = 0; i < this.index; i++)
        {
            Person temp = people[i];
            Console.WriteLine($"Имя: {temp.Name} возраст: {temp.Age}");
        }
    }
}