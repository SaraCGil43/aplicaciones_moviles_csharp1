namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string nameinput;
            string birthdayinput;

            Console.WriteLine("¡Bienvenido a tu programa");
            Console.WriteLine("Escribe tu nombre: ");
            nameinput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameinput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
            birthdayinput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayinput, out dateConverted);
            Console.WriteLine(isDateValid);
            if (isDateValid == false)
            {
                Console.WriteLine("La fecha de nacimiento es invalida");
            }
            var person = new Person
            {
                Name = nameinput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };

            Console.WriteLine($"Tu nombre: {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento: {person.Birthday}");
            Console.WriteLine($"Tu edad es: {person.Age}");

            Console.ReadLine();

        }
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateOnly Birthday { get; set; }


}