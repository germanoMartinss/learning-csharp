// Crie um jogo texto no estilo Visual Novel em que o jogador interage com um personagem e deve escolher as respostas corretas para concluir um objetivo. Por exemplo: imagine que o jogador é um espião que deve convencer um segurança a deixa-lo passar por uma porta que ele não deveria ter acesso. Nesse caso, o segurança faz uma pergunta como "Preciso da sua identificação, por favor", e algumas opções de ação são apresentadas ao jogador

Console.WriteLine("Você está em uma porta, e o segurança está falando: Preciso da sua identificação, por favor");
Console.WriteLine("A) - Apresentar identificação falsa...");
Console.WriteLine("B) - Você sabe com quem está falando?");
Console.WriteLine("C) - Golpear o segurança");
Console.WriteLine("D) - Preciso falar com a Srta Sandiego");

Console.Write("Digite a opção: ");
string option = Console.ReadLine().ToUpper();

if (option == "A")
{
    Console.WriteLine("Segurança: Hmm... Esse crachá parece diferente. De qual setor você é?");
    Console.WriteLine("A) - Setor de Financeiro");
    Console.WriteLine("B) - Setor de Produção");
    Console.WriteLine("C) - A Srta Sandiego me deu esse crachá!");
    Console.WriteLine("D) - Setor de Marketing");
    Console.Write("Digite a opção: ");

    string option2 = Console.ReadLine().ToUpper();
    if (option2 == "A")
    {
        Console.WriteLine("Segurança: Você é do setor de financeiro? Não parece ser você. Você pode sair.");
        Console.WriteLine("FIM DE JOGO");
    }
    else if (option2 == "B")
    {
        Console.WriteLine("Segurança: Você é do setor de produção? Não parece ser você. Você pode sair.");
        Console.WriteLine("FIM DE JOGO");
    }
    else if (option2 == "C")
    {
        Console.WriteLine("Segurança: A ok, eu confio na Srta Sandiego!");
        Console.WriteLine("Você passou pela porta. MISSÃO CONCLUÍDA!");
    }
    else if (option2 == "D")
    {
        Console.WriteLine("Segurança: Você é do setor de marketing? Não parece ser você. Você pode sair.");
        Console.WriteLine("FIM DE JOGO");
    }
}
else if (option == "B")
{
    Console.WriteLine("Segurança: Não sou pago para saber com quem estou falando. Saia já daqui!");
    Console.WriteLine("FIM DE JOGO");
}
else if (option == "C")
{
    Console.WriteLine("Segurança: Você acha que pode me derrubar com esse golpe?! Está muito enganado. Saia já daqui!");
    Console.WriteLine("FIM DE JOGO");
}
else if (option == "D")
{
    Console.WriteLine("Segurança: A Srta Sandiego está de folga, volte outro dia!");
    Console.WriteLine("FIM DE JOGO");
}