using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyFood.com.Entity
{
    public class Menu
    {
        public int ID { get; set; }
        public string? Image { get; set; }
        public string? ImageURL { get; set; }
        public string? Star1 { get; set; }
        public string? Star2 { get; set; }
        public string? Star3 { get; set; }
        public string? Star4 { get; set; }
        public string? Star5 { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
       
        [Range(1, 100)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Discount { get; set; }

        [ForeignKey("Category")]
        public int? Category_ID { get; set; }
        public Category? Category { get; set; }


    }
}
