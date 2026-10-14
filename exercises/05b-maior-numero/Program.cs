Console.WriteLine("Digite o primeiro número: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} é maior que {number2}");
}
else
{
    Console.WriteLine($"{number2} é maior que {number1}");
}