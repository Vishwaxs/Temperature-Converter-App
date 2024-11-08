using System;

class TemperatureConverter
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9.0 / 5.0) + 32.0;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32.0) * 5.0 / 9.0;
    }

    static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    static double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.WriteLine("3. Celsius to Kelvin");
        Console.WriteLine("4. Kelvin to Celsius");
        Console.Write("Enter your choice (1-4): ");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Console.Write("Enter the temperature: ");
        double temperature;
        if (!double.TryParse(Console.ReadLine(), out temperature))
        {
            Console.WriteLine("Invalid temperature input.");
            return;
        }

        double convertedTemperature;

        switch (choice)
        {
            case 1:
                convertedTemperature = CelsiusToFahrenheit(temperature);
                break;
            case 2:
                convertedTemperature = FahrenheitToCelsius(temperature);
                break;
            case 3:
                convertedTemperature = CelsiusToKelvin(temperature);
                break;
            case 4:
                convertedTemperature = KelvinToCelsius(temperature);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine("Converted Temperature: " + convertedTemperature);
    }
}
