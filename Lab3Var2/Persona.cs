using System;

/*В
базовому класі Персона зробити конструктор з параметрами. В
похідних також з параметрами.
Розробити два віртуальні методи в базовому класі і їх
реалізації в кожному з похідних класів.*/

namespace Task1
{
    public class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Persona(string n, int a)
        {
            Name = n;
            Age = a;
        }

        //      public virtual void GetName() { Console.WriteLine(Name); }
        //      public virtual void GetAge() { Console.WriteLine(Age); }
      //віртуальні методи можуть не мати реалізації
        public virtual void AboutPerson() { }
        public virtual void PutAge() { }
    }
}

