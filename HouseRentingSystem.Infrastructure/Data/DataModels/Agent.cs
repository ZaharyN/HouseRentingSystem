using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.DataModels
{
    [Index(nameof(PhoneNumber), IsUnique = true)]
	public class Agent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(AgentPhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;
        public IdentityUser User { get; set; } = null!;
    }
}
