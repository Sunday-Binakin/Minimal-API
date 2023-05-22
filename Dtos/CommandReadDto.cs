using System.ComponentModel.DataAnnotations;

namespace SixminApi.Dtos

{
    public class CommandReadDto
    {
        
     
        public int Id { get; set; }
        public string? HowTo { get; set; }
        
        public string? CommandLine { get; set; }
        // [Required]
        // [MaxLength(5)]
       // public string? Platform { get; set; }

    }
}
