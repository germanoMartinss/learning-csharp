int healthPoints = 100;
int firstAttack = 10;
int secondAttack = 30;

healthPoints -= firstAttack;
Console.WriteLine($"Primeiro ataque!! você perdeu {firstAttack}, mas ainda tem {healthPoints} de vida!!");

healthPoints -= secondAttack;
Console.WriteLine($"DAAAM!! Esse ataque foi brutal, você perdeu {secondAttack}, você só tem mais {healthPoints} de vida!!");