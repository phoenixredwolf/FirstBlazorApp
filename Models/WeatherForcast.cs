namespace FirstBlazorApp.Models
{
    public class WeatherForcast
    {
        public string? cod { get; set; }
        public int? message { get; set; }
        public int? cnt { get; set; }
        public Forcast[]? list { get; set; }
        public City? city { get; set; }
    }
}
