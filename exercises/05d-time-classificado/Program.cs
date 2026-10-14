int wins = 0;
int balance = 0;

Console.WriteLine("Jogo 1");
Console.Write("Pontos do time: ");
int team = Convert.ToInt32(Console.ReadLine());
Console.Write("Pontos do adversário: ");
int rival = Convert.ToInt32(Console.ReadLine());

if (team > rival)
{
    wins = wins + 1;
}
balance = balance + (team - rival);

Console.WriteLine("Jogo 2");
Console.Write("Pontos do time: ");
team = Convert.ToInt32(Console.ReadLine());
Console.Write("Pontos do adversário: ");
rival = Convert.ToInt32(Console.ReadLine());

if (team > rival)
{
    wins = wins + 1;
}
balance = balance + (team - rival);

Console.WriteLine("Jogo 3");
Console.Write("Pontos do time: ");
team = Convert.ToInt32(Console.ReadLine());
Console.Write("Pontos do adversário: ");
rival = Convert.ToInt32(Console.ReadLine());

if (team > rival)
{
    wins = wins + 1;
}
balance = balance + (team - rival);

if (wins >= 2)
{
    Console.WriteLine($"O time venceu {wins} jogos, tem saldo de {balance} pontos e está classificado!");
}
else
{
    Console.WriteLine($"O venceu apenas {wins} jogo, tem saldo de {balance} pontos e não está classificado!");
}