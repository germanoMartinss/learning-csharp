Console.WriteLine($"Cadastre os atributos do seu personagem:");

Console.Write($"Pontos de vida(HP): ");
int hp = Convert.ToInt32(Console.ReadLine());
Console.Write($"Pontos de mana(MP): ");
int mana = Convert.ToInt32(Console.ReadLine());
Console.Write($"Pontos de força: ");
int strength = Convert.ToInt32(Console.ReadLine());
Console.Write($"Pontos de velocidade: ");
int agility = Convert.ToInt32(Console.ReadLine());
Console.Write($"Pontos de altura: ");
float height = Convert.ToSingle(Console.ReadLine());

Console.WriteLine($"Atributos do seu personagem:");
Console.WriteLine($"- Pontos de vida(HP): {hp}");
Console.WriteLine($"- Pontos de mana(MP): {mana}");
Console.WriteLine($"- Pontos de força: {strength}");
Console.WriteLine($"- Pontos de velocidade: {agility}");
Console.WriteLine($"- Pontos de altura: {height}");
