Console.Write("Digite o nome do seu personagem:\n");
string name = Console.ReadLine(); 

Console.Write("Digite a altura do seu personagem:\n");
float height = float.Parse(Console.ReadLine());

Console.Write("Digite a força do seu personagem:\n");
int strength = int.Parse(Console.ReadLine());

Console.Write("Digite a agilidade do seu personagem:\n");
int agility = int.Parse(Console.ReadLine());

Console.Write("Digite a inteligência do seu personagem:\n");
int intelligence = int.Parse(Console.ReadLine());

Console.Write("Seu personagem será um Herói, digite True para sim ou False para não:\n");
bool isHero = bool.Parse(Console.ReadLine());

Console.WriteLine($"O nome do seu personagem é {name}, sua altura é {height}, sua força é {strength}, sua agilidade é {agility}, sua inteligência é {intelligence} e você é {( isHero ? "um Heóri" : "um Vilão")}!");