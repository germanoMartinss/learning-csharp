// Crie um programa que mostre se o número é par ou ímpar

Console.WriteLine("Digite um número: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} é par!");
}
else
{
    Console.WriteLine($"{number} é ímpar!");
}
