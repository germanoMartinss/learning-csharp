// Crie um programa que pergunte o nome e a idade de uma pessoa e mostre um texto no console indicando se ela é maior ou menor de idade.

Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
int age = Convert.ToInt32(Console.ReadLine());

int maioridade = 18;

if (age >= maioridade)
{
    Console.WriteLine($"Olá {name}, você é maior de idade!");
}
