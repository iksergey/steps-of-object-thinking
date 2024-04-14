Person person1 = new Person("Ваня К.", 23);
Person person2 = new Person("Юля К.", 21);


Repository repository = new Repository(10);
repository.Append(person1);
repository.Append(person2);

repository.Print();