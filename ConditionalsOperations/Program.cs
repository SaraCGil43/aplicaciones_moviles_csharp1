
// Conditionals on C#
Console.WriteLine("Escribe un número:");
int num = int.Parse(Console.ReadLine());

if(num >0){
    Console.WriteLine("El número "+num +" es positivo");
}else{
 Console.WriteLine("El número "+num +" es negativo");
}

Console.WriteLine("Escribe el primer número:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Escribe el segundo número:");
double b = double.Parse(Console.ReadLine());
const string Indeterminado = "Indeterminado";

Console.WriteLine($"Suma: {a+b}, Resta:  {a-b}, Multiplicación: {a*b}, Divisón {(b!=0 ? a/b : Indeterminado)}");
