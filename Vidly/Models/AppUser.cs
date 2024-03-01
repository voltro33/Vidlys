
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class AppUser : IdentityUser
    {
        public string? ProfileImageUrl { get; set; }
        public int? GenreId { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
