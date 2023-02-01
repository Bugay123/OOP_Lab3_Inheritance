using System;

/*У похідному класі Робітник створити 2 власні методи з
параметрами.
Перший метод. Передати як параметри посаду і зарплату
робітника і вивести їх на консоль.
Посада з переліку: {слюсар, токар}
Другий метод – функція без вхідних параметрів. Повертає 1
результат типу double. Обчислює середню зарплату за 6
місяців і повертає її у main. Створити масив зарплат за 6
місяців і обчислити середню зарплату. Викликати метод з main
і вивести результат на консоль.*/

namespace Task1
{
    public class Worker : Persona
    {
        public double Salary { get; set; }
        public string Role { get; set; }
        //в конструкторі треба ініціалізувати всі поля
        public Worker(string n, int a, double s, string r) : base(n, a)
        {
            Name = n;
            Age = a;
            Salary = s;
            Role = r;   
        }

        public void WorkerSalaryAndRole(double s, string r)
        {
            // цей метод зайвий
            Salary = s;
            Role = r;
            Console.WriteLine($"зарплата - {Salary}, посада - {Role}");
        }
        // так краще не робити
        //віртуальні методи, які перевизначаються в похідних класах, повинні мати різну реалізацію,
        //якщо метод має таку саму реалізацію, він просто успадковується.
        //     public override void GetAge() { base.GetAge(); }
        //     public override void GetName() { base.GetName(); }
// наприклад
        public override void AboutPerson() 
        {  //все про робітника
            Console.WriteLine($"Це робітник на ім'я {Name}, йому {Age} років, зарплата {Salary}");
        }
        public override void PutAge() 
        {
            //вік робітника
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
}

