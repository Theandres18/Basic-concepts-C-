namespace HelloWorld
{
    class Program
    {
        static void Main()
        {   DateOnly dateConverted = new DateOnly();
            string nameImput;
            string birthdayImput;
            Console.WriteLine(" !Hola Bienvenido a el calculador de años! ");
            Console.WriteLine("Ingresa tu nombre: ");
            nameImput = Console.ReadLine();
            Console.WriteLine($" Un gusto conocerte {nameImput}");
            Console.WriteLine("Ingresa tu fecha de nacimiento en formato dd/mm/yy : ");
            birthdayImput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayImput, out dateConverted);
            if (isDateValid==false) Console.WriteLine($"La fecha ingresada no es válida. Informacion no reconocida {birthdayImput}");
            var person1 = new Person()
             { Name = nameImput,
             BirthDate = dateConverted,
             Age = DateTime.Now.Year - dateConverted.Year

             };

            Console.WriteLine($"Tu nombre es {person1.Name}");
            Console.WriteLine($"Tu fecha de nacimiento es {person1.BirthDate}");
            Console.WriteLine($"Tu edad es {person1.Age} años");


            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateOnly BirthDate { get; set; }

    }

}