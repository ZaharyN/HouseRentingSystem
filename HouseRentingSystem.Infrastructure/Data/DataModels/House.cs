using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.DataModels
{
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerMonth { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int AgentId { get; set; }

        [Required]
        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;

        public string? RenterId { get; set; }
    }
}

//•	Id – a unique integer, Primary Key
//•	Title – a string with min length 10 and max length 50 (required)
//•	Address – a string with min length 30 and max length 150 (required)
//•	Description – a string with min length 50 and max length 500 (required)
//•	ImageUrl – a string (required)
//•	PricePerMonth – a decimal with min value 0 and max value 2000 (required)
//•	CategoryId – an integer (required)
//•	Category – a Category object
//•	AgentId – an integer (required)
//•	Agent – an Agent object
//•	RenterId – a string
