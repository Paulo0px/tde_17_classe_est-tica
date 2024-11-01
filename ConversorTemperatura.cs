using System.Security.Cryptography.X509Certificates;

public static class ConversorTemperatura
{
    public static double CelsiusParaFahrenheit(double Celsius)
    {
        return (Celsius * 9/5) + 32;
    }

    public static double FahrenheitParaCelsius (double Fahrenheit)
    {
        return (Fahrenheit -32) * 5/9;
    }
}