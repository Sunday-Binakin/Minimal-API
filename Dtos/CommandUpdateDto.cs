using System.ComponentModel.DataAnnotations;

namespace SixminApi.Dtos

{
    public class CommandUpdateDto
    {
        // [Key]
        // public int Id { get; set; }
        [Required]
        public string? HowTo { get; set; }
        [Required]
        public string? CommandLine { get; set; }
        [Required]
        [MaxLength(5)]
        public string? Platform { get; set; }

    }
}
