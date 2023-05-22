using System.ComponentModel.DataAnnotations;

namespace SixminApi.Dtos

{
    public class CommandCreateDto
    {

        [Required]
        public string? HowTo { get; set; }
[Required]
        public string? CommandLine { get; set; }
[Required]
        public string? Platform { get; set; }

    }
}
