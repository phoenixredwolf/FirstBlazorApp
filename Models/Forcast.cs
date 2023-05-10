﻿using Microsoft.AspNetCore.Components;

namespace FirstBlazorApp.Models
{
    public class Forcast
    {
        public long? dt { get; set; }
        public Main? main { get; set; }
        public Weather[]? weather { get; set; }
        public Clouds? clouds { get; set; }
        public Wind? wind { get; set; }
        public int? visibility { get; set; }
        public double? pop { get; set; }
        public Sys? sys { get; set; }
        public string? dt_txt { get; set; }
    }
}
