Console.Write("Digite a distância (km): ");
float distance = Convert.ToSingle(Console.ReadLine());

Console.Write("Digite a velocidade (km/h): ");
float speed = Convert.ToSingle(Console.ReadLine());

float hours = distance / speed;
float minutes = hours * 60;

Console.WriteLine($"Para percorrer {distance} km a {speed} km/h, são necessários {minutes} minutos.");
