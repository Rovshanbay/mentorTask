using System.ComponentModel.DataAnnotations;

namespace mentorTask.Models
{
    public class Offer
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
    }
}
