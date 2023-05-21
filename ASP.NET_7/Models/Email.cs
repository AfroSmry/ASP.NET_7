using System.ComponentModel.DataAnnotations;

namespace ASP.NET_7.Models
{
    public class Email
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string? MessageTheme{ get; set; }
        [Required]
        [StringLength(500)]
        public string? MessageBody { get; set; }
        [Required]
        [StringLength(50)]
        public string? SenderEmail { get; set; }
    }
}
