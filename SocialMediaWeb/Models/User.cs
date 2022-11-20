using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMediaWeb.Models
{
    public class User 
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string? Image { get; set; }
        public DateTime? Date { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
