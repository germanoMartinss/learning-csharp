Console.Write($"Digite um número: ");
float number1 = Convert.ToSingle(Console.ReadLine());

Console.Write($"Digite a porcentagem de (1 a 100): ");
float percentage = Convert.ToSingle(Console.ReadLine());

Console.WriteLine($"{percentage}% de {number1} é {number1 * percentage / 100}");