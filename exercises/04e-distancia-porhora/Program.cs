Console.Write("Digite a distância (km): ");
float distance = Convert.ToSingle(Console.ReadLine());

Console.Write("Digite a velocidade (km/h): ");
float speed = Convert.ToSingle(Console.ReadLine());

float time = distance / speed * 60;

Console.WriteLine($"São necessários {time} minutos para percorrer {distance} km a uma velocidade de {speed} km/h");
