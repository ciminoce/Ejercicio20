Console.Write("Ingrese el primer número:");
var numeroUno=int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número:");
var numeroDos=int.Parse(Console.ReadLine());
if (numeroUno==numeroDos)
{
    Console.WriteLine("Ambos números son iguales");
}else if (numeroUno > numeroDos)
{
    Console.WriteLine($"{numeroUno} es mayor a {numeroDos}");
}
else
{
    Console.WriteLine($"{numeroDos} es mayor a {numeroUno}");

}
