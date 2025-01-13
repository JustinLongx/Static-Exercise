namespace Static_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var celcius = TempConverter.FahrenheitToCelsius(54);
            Console.WriteLine($"54 fahrenheit is {celcius} degrees celsius.");

            var fahrenheit = TempConverter.CelsiusToFahreheit(celcius);
            Console.WriteLine($"It is {fahrenheit} converted back.");

        }
    }
}
