namespace DGMokymas8_API
{
    public class WeatherForecast // Tai yra klase kuri laiko informacija, kuria naudosime veliau
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
