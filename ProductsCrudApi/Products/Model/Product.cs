using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsCrudApi.Products.Model
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        // Schimbăm Price cu Age și DateOfFabrication cu DateOfBirth
        [Required]
        [Column("age")]
        public int Age { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        // Ștergem Category și adăugăm Gender
        [Required]
        [Column("gender")]
        public string Gender { get; set; }

        [Required]
        [Column("date_of_birth")] // Schimbăm DateOfFabrication cu DateOfBirth
        public DateTime DateOfBirth { get; set; }
    }
}
