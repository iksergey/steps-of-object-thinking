interface IRepository
{
    int Index { get; }
    void Append(params Person[] people);
    public Person GetById(int id);
}
