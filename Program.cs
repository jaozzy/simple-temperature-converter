using System;

public class ConversorTemperatura {
    public static double CelsiusParaFahrenheit(double temperaturaCelsius) {
        double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;
        return temperaturaFahrenheit;
    }

    public static double FahrenheitParaCelsius(double temperaturaFahrenheit) {
        double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;
        return temperaturaCelsius;
    }
}

internal class Program {
    public static void Main(string[] args) {

        int op;

        Console.Write("Deseja converter C° para F° ou F° para C°?\n[1] C° -> F°\n[2] F° -> C°\nR:   ");
        op = int.Parse(Console.ReadLine());

        switch (op) {
            case 1:
                Console.Write("Temperatura em C°: ");
                double celsius = double.Parse(Console.ReadLine());

                double f = ConversorTemperatura.CelsiusParaFahrenheit(celsius);

                Console.WriteLine($"{celsius}°C em F° equivale(m) a: {f}°F");
                break;

            case 2:
                Console.Write("Temperatura em F°: ");
                double fahrenheit = double.Parse(Console.ReadLine());

                double c = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);

                Console.WriteLine($"{fahrenheit}F° em C° equivale(m) a: {c}°C");
                break;

            default:
                Console.Write("Opção inválida.");
                break;
        }

        Console.Write("Pressone qualquer tecla para sair...  ");
        Console.ReadKey();

    }
}
