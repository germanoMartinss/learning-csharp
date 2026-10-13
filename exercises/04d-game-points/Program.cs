Console.WriteLine("Digite a pontuação das últimas 5 partidas:");

Console.Write("Partida 1: ");
int score1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Partida 2: ");
int score2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Partida 3: ");
int score3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Partida 4: ");
int score4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Partida 5: ");
int score5 = Convert.ToInt32(Console.ReadLine());

int total = score1 + score2 + score3 + score4 + score5;
float average = total / 5f;

Console.WriteLine($"Pontuação total: {total}");
Console.WriteLine($"Média de pontos: {average}");