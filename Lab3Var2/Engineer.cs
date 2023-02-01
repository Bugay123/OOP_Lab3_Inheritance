using System;

/*У похідному класі Інженер створити дві властивості: зарплата
і стаж роботи. Ініціалізувати значення полів і властивостей і
базового і похідного класу у конструкторі класу (через base).
Створити 1 метод без параметрів, в якому вивести на консоль
Ім’я, вік, посаду, зарплату, стаж роботи.*/

namespace Task1
{
    class Engineer : Persona
    {
        public double Salary { get; set; }
        public int Exp { get; set; }
        public Engineer(string n, int a, double s, int e) : base(n, a)
        {
            Name = n;
            Age = a;
            Salary = s;
            Exp = e;
        }

        public override void AboutPerson()
        {  //все про інженера
            Console.WriteLine($"Це інженер на ім'я {Name}, йому {Age} років, стаж роботи {Exp}, зарплата {Salary}");
        }
        public override void PutAge()
        {
            Console.WriteLine($"Вік інженера {Age}");
        }
//Це вже зайве
  /*      public void PrintE()
        {
            Console.WriteLine($"{Name} {Age} {Salary} {Exp}");
        }
  */
    }
}

