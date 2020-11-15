using Microsoft.Net.Http.Headers;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DrinkStore.Models
{
    public class Product
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [JsonPropertyName("img")]

        public string Image { get; set; }

        [Column(TypeName = "decimal(8,2)")]

        public decimal Price { get; set; }

        public string Discount { get; set; }

        public string Status { get; set; }

        public string Category { get; set; }
    }
}
