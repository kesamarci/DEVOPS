using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndEndpoint.Models
{
    public class Wines : Helpers.IIdEntity
    {
        [Key]
        public string Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [StringLength(100)]
        public string Type { get; set; } = string.Empty;
        public int Year { get; set; }
        public int Price { get; set; }
        public Wines()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
