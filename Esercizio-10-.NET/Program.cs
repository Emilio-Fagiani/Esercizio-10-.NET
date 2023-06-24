using Esercizio_10_.NET;
Console.WriteLine("Please insert the number ");
string number = Console.ReadLine();
double num = int.Parse(number);

Console.WriteLine("Do you want convert in Celsius(1) or Fahrenheit(2) ? Insert 1 or 2 ");
string input = Console.ReadLine(); 

switch(input)
{
    case "1":
        ConvertTemperature ct = new ConvertTemperature();
        Console.WriteLine(ct.ConvertToCelsius(num));
        break;
    
    case "2":
        ConvertTemperature ct2 = new ConvertTemperature();
        Console.WriteLine(ct2.ConvertToFahrenheit(num));
        break;

    default:
        Console.WriteLine("Insert no valid");
        break; 

}