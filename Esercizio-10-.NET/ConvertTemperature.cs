
namespace Esercizio_10_.NET
{
    public class ConvertTemperature
    {
        public double Temperature { get; set;}

        public double ConvertToFahrenheit(double tempeCelsius)
        {
            double converter = (tempeCelsius * 1.8) + 32;
            return converter;
        }

        public double ConvertToCelsius(double tempeFaharenheit)
        {
            double convert = (tempeFaharenheit - 32) * 0.5556;
            return convert; 
        }
    }
}
