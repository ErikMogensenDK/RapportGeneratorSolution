using System.ComponentModel.DataAnnotations;

namespace RapportGeneratorProject.Models
{
    public class Wisc
    {
        public int Id { get; set; }

        [Required]
        public int hik { get; set; }
        [Required]
        public int vfi { get; set; }
    }
}
