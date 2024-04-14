class Repository
{
    private Person[] people;
    private int count;
    private int index = 0;
    public Repository(int count)
    {
        this.count = count;
        this.people = new Person[this.count];
    }

    // public int Index { get { return index; } }
    // public int Index { get => index; }
    public int Index => index;

    public void Append(Person person)
    {
        if (index >= count) return;
        people[index] = person;
        index++;
    }

    public Person GetPersonById(int id)
    {
        if (id < 0 || id >= index)
        {
            return new Person("empty", -1);
        }
        return people[id];
    }
}