class Printer
{
    public void Print(Repository repository)
    {
        int max = repository.Index;

        for (int i = 0; i < max; i++)
        {
            Console.WriteLine(repository.GetPersonById(i).ToString());
        }
    }
}