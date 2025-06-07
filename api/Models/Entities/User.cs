using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AvianApi.Models.Entities
{
    public class User
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [JsonIgnore] 
        public string PasswordHash { get; set; }

        [MaxLength(100)]
        public string CertificateCode { get; set; }

        [Phone]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string Role { get; set; }
    }
}
