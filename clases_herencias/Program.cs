
Console.WriteLine("-------------- BIENVENIDO AL PROGRAMA DE HERENCIAS Y CLASES-----------");
Console.WriteLine("");
Console.WriteLine("EJERCICIO #1: Area y Perimetro");

var rect = new Rectangulo();

rect.Base= 20;
rect.Altura= 40;
Console.WriteLine($"El área es: {rect.Area()}");
Console.WriteLine($"El perimetro es: {rect.Perimetro()}");

Console.WriteLine($"");
Console.WriteLine("EJERCICIO #2: Lado del cuadrado");
Console.WriteLine($"");

var cuad = new Cuadrado();
cuad.Base= 20;
cuad.Altura= 40;
Console.WriteLine($"El área es: {cuad.Area()}");
Console.WriteLine($"El perimetro es: {cuad.Perimetro()}");
Console.WriteLine($"El lado es: {cuad.Lado}");

class Rectangulo{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area() => Base*Altura;
    public double Perimetro() => 2* Base + 2 *Altura;
}

class Cuadrado : Rectangulo{
    public double Lado{
        set{ Base = value; Altura= value;  }
        get{return Base;}
    } 
}

