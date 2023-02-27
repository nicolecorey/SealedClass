interface IEmployee
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
    public double Pay();
}
class Program
{ 
class Employee : IEmployee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee()
    {
        Id = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
    }
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    public string Fullname()
    {
        return FirstName + " " + LastName;
    }
    public virtual double Pay()
    {
        double salary;
        Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
        salary = double.Parse(Console.ReadLine());
        return salary;
    }

}

sealed class Executive : Employee
{
    public string Title { get; set; }
    public double Salary { get; set; }

    public Executive() : base()
    {
        Title = string.Empty;
        Salary = 0;
    }
    public Executive(int id, string firstName, string lastName, string title, double salary)
        : base(id, firstName, lastName)
    {
        Title = title;
        Salary = salary;
    }

    public string jobTitle()
    {
        return Title;
    }

    public override double Pay()
    {
        double salary;
        Console.WriteLine($"How much does {this.Fullname()} make as an executive?");
        salary = double.Parse(Console.ReadLine());
        return salary;

    }
}

    static void Main(string[] args)
    {
        
        Employee spongebob = new Employee(5, "Spongebob", "Squarepants");
        Console.WriteLine($"Name: " + spongebob.Fullname() + " " + "Salary: "  + spongebob.Pay());
        
        Executive krabs = new Executive(10, "Eugene", "Krabs", "Executive", 100);
        Console.WriteLine($"Name: " + krabs.Fullname() + " " + "Title: " + krabs.jobTitle() + " " + "Salary: " + krabs.Pay());

    }
}