public class Person
{
    public string Name;
    public int Age;


    public Person(string Name,
                  int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
    public virtual void print()
    {
        Console.Write($"My name is {Name} , my age is {Age}");
    }
}

public class Student : Person
{
    public int Year;
    public float GPA;


    public Student(string Name, int Age, int Year, float GPA) : base(Name, Age)
    {
        this.Name = Name;
        this.Age = Age;
        this.Year = Year;
        this.GPA = GPA;
    }

    public override void print()
    {
        base.print();
        Console.WriteLine($" and my GPA is {GPA}");
    }

}

public class Staff : Person
{
    public double Salary;
    public int JoinYear;

    public Staff(string Name, int Age, double Salary, int JoinYear) : base(Name, Age)
    {
        this.Salary = Salary;
        this.JoinYear = JoinYear;
    }

    public override void print()
    {
        base.print();
        Console.WriteLine($" and my salary is {Salary}");
    }
}


public class Database
{
    private int _currentIndex;
    public Person[] People = new Person[50];

    public void AddStudent(Student Student)
    {
        People[_currentIndex++] = Student;
    }

    public void AddStaff(Staff Staff)
    {
        People[_currentIndex++] = Staff;
    }

    public void AddPerson(Person Person)
    {
        People[_currentIndex++] = Person;
    }

    public void PrintAll()
    {
        for (var i = 0; i < _currentIndex; i++)
        {
            People[i].print();
        }
    }
}


public class Work
{
    private static void Main()
    {
        var database = new Database();

        while (true)
        {
            Console.WriteLine("Please enter the number of process");
            Console.WriteLine("1 for Student\n2 for Staff\n3 for Person\n4 for All people");

            Console.Write("Option: ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    {
                        Console.Write("Name : ");

                        var name = Console.ReadLine();

                        Console.Write("Age : ");

                        var age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Year : ");

                        var year = Convert.ToInt32(Console.ReadLine());

                        Console.Write("GPA : ");

                        var gpa = Convert.ToSingle(Console.ReadLine());

                        database.AddStudent(new Student(name, age, year, gpa));

                        break;
                    }

                case 2:
                    {
                        Console.Write("Name : ");

                        var name = Console.ReadLine();

                        Console.Write("Age : ");

                        var age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Salary : ");

                        var salary = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Join Year : ");

                        var joinYear = Convert.ToInt32(Console.ReadLine());

                        database.AddStaff(new Staff(name, age, salary, joinYear));

                        break;
                    }

                case 3:

                    {
                        Console.Write("Name : ");

                        var name = Console.ReadLine();

                        Console.Write("Age : ");

                        var age = Convert.ToInt32(Console.ReadLine());

                        database.AddPerson(new Person(name, age));

                        break;
                    }

                case 4:

                    {
                        database.PrintAll();
                        break;
                    }
                default:
                    return;
            }
        }

    }
}