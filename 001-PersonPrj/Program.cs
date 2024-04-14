Person person1 = new Person("Ваня К.", 23);
Person person2 = new Person("Юля К.", 21);
Person person3 = new Person("Инна В.", 25);

Repository repository = new Repository(10);
repository.Append(person1, person2, person3);
repository.Append(person1);

Printer printer = new Printer();
printer.Print(repository);

Student s = new Student("Студент 1", 11, "Школа # 322");
Console.WriteLine(s.ToString());

Employee employee = new Employee("Рабочий 1", 31, 40000);
Console.WriteLine(employee.ToString());
Teacher teacher = new Teacher("Учитель 1", 33, "Математика");
Console.WriteLine(teacher.ToString());