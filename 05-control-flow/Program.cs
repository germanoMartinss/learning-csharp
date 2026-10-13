int balance = 1500;

if (balance >= 1000)
{
    balance = balance - 1000;
    Console.WriteLine("Parabéns você comprou a espada!");
}
else
{
    Console.WriteLine("Saldo insuficiente!");
}

Console.WriteLine($"Saldo do jogador: {balance}");
