using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BackEndEndpoint.Models
{
    public class Wines : Helpers.IIdEntity
    {
        [Key]
        public string Id { get; set; }
        [StringLength(100)]
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        [StringLength(100)]
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
        [JsonPropertyName("year")]
        public int Year { get; set; }
        [JsonPropertyName("price")]
        public int Price { get; set; }
        public Wines()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
