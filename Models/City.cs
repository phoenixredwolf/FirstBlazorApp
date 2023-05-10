namespace FirstBlazorApp.Models
{
    public class City
    {
        public int? id { get; set; }
        public string? name { get; set; }
        public Coord? coord { get; set; }
        public string? country { get; set; }
        public long? population { get; set; }
        public int? timezone { get; set; }
        public long? sunrise { get; set; }
        public long? sunset { get; set; }
    }
}
