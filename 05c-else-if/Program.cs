int level = 1;

if (level == 1)
{
    Console.WriteLine("Você ganho uma skin!");
}
else if (level == 2)
{
    Console.WriteLine("Você ganho uma armadura!");
}
else if (level == 3)
{
    Console.WriteLine("Você ganhou uma habilidade rara!");
}
else if (level >= 4)
{
    Console.WriteLine("Você ganhou um selo raro!");
}
else
{
    Console.WriteLine("Você não ganhou nada!");
}
