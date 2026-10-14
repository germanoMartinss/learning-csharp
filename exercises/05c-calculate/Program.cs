Console.WriteLine("""
Escolha o tipo de conta que deseja:
1 - Soma
2 - Subtração
3 - Multiplicação
4 - Divisão
"""
);  

int option = Convert.ToInt32(Console.ReadLine());
if (option == 1)
{
    Console.WriteLine("Digite o primeiro número: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
}
else if (option == 2)
{
    Console.WriteLine("Digite o primeiro número: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
}
else if (option == 3)
{
    Console.WriteLine("Digite o primeiro número: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
}
else if (option == 4)
{
    Console.WriteLine("Digite o primeiro número: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
}