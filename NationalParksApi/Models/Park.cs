using System.ComponentModel.DataAnnotations;

namespace NationalParksApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(2)]
    public string State { get; set; }

    public string Description { get; set; }

    [Required]
    [RegularExpression(@"^(?:Yes|No)$")]
    public string Visited { get; set; }

  }
}