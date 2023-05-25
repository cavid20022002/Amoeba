using Microsoft.Build.Framework;

namespace AmoebaTemplate.Models
{
    public class CustomService
    {
        public int Id { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
