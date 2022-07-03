using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo.API.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // None, Identity, Computed

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }

        [ForeignKey("CityId")]
        public City? city { get; set; } //relationship
        public int CityId { get; set; }

        public PointOfInterest(string? name)
        {
            Name = name;
        }

    }
}
