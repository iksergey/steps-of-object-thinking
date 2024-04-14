Person person1 = new Person("Ваня К.", 23);
Person person2 = new Person("Юля К.", 21);
Person person3 = new Person("Инна В.", 25);

Repository repository = new Repository(10);
repository.Append(person1); // 0
repository.Append(person2);
repository.Append(person3);

repository.Print();

var res = repository.GetPersonById(2);
Console.WriteLine(res.Name);
