Console.WriteLine("Tempratura dada pelo sensor : ");
double celcius = double.Parse(Console.ReadLine());

double fahrenheit = ((celcius * 9 / 5) + 32);
Console.WriteLine($"A temperatura hoje é: {celcius}°, que em fahrenheit é: {fahrenheit:F2}°");