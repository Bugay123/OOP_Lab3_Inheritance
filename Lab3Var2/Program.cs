namespace Task1;

/*Розробити ієрархію класів: Персона, Робітник, Інженер.
Розробити конструктори і методи роботи з кожним класом. 

У програмі в main створити по 1 об’єкту похідних класів,
використовуючи конструктори з параметрами (або
ініціалізатори). Викликати усі розроблені методи (віртуальні і
звичайні). Результати вивести на консоль.*/

class Program
{
    static void Main(string[] args)
    {
        //    Persona persona = new Persona("Bob", 20);
        //    Console.WriteLine(persona.Name);
        //   Console.WriteLine(persona.Age);
        Worker worker = new Worker("Tob", 25, 3000, "токар");
        //перевизначені методи
        worker.AboutPerson();
        worker.PutAge();    
  //      worker.WorkerSalaryAndRole(100, "токар"); //значення вже призначили в конструкторі
        worker.AvgSalary();
        Engineer eng = new Engineer("Cat", 20, 1000, 5);
        eng.AboutPerson();
        eng.PutAge();

   //     eng.PrintE();
    }
}

