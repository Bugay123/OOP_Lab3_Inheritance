namespace Task2;

/*Зробити клас Персона абстрактним, а реалізацію
віртуальних методів перенести в похідні класи.*/

abstract class Persona
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void AboutPerson();
    public abstract void PutAge();
}

class Worker : Persona
{
    public double Salary { get; set; }
    public string Role { get; set; }
    public Worker(string n, int a, double s, string r) {
        Name = n;
        Age = a;
        Salary = s;
        Role = r;
    }

    public override void AboutPerson()
    {  
        Console.WriteLine($"Це робітник на ім'я {Name}, йому {Age} років, зарплата {Salary}");
    }
    public override void PutAge()
    {
        Console.WriteLine($"Вік цього робітника {Age}");
    }

    public double AvgSalary()
    {
        double[] monSalary = { 1, 2, 3, 4, 2, 4 };
        double aveSalary = monSalary.AsQueryable().Average();
        Console.WriteLine("Середня зарплата " + aveSalary);
        return aveSalary;
    }
}

class Engineer : Persona
{
    public double Salary { get; set; }
    public int Exp { get; set; }
    public Engineer(string n, int a, double s, int e)
    {
        Name = n;
        Age = a;
        Salary = s;
        Exp = e;
    }

    public override void AboutPerson()
    {  
        Console.WriteLine($"Це інженер на ім'я {Name}, йому {Age} років, стаж роботи {Exp}, зарплата {Salary}");
    }
    public override void PutAge()
    {
        Console.WriteLine($"Вік інженера {Age}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Worker worker = new Worker("Tob", 25, 3000, "токар");
        worker.AboutPerson();
        worker.PutAge();
        worker.AvgSalary();

        Engineer eng = new Engineer("Cat", 20, 1000, 5);
        worker.AboutPerson();
        worker.PutAge();
    }
}