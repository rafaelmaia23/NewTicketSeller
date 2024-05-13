using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewTicketSeller.Domain.Models;

public class Address
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(150, ErrorMessage ="Max characters permited: 150")]
    public string Street { get; set; } = string.Empty;
    [Required]
    [StringLength(10, ErrorMessage = "Max characters permited: 10")]
    public string Number { get; set; } = string.Empty;
    [StringLength(100, ErrorMessage = "Max characters permited: 100")]
    public string? Complement { get; set; }
    [StringLength(100, ErrorMessage = "Max characters permited: 100")]
    public string? Reference { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Max characters permited: 50")]
    public string City { get; set; } = string.Empty;
    [Required]
    [StringLength(50, ErrorMessage = "Max characters permited: 50")]
    public string State { get; set; } = string.Empty;
    [Required]
    [StringLength(8, ErrorMessage = "Max characters permited: 8")]
    [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "Invalid postcode.")]
    public string PostalCode { get; set; } = string.Empty;
    [ForeignKey("Cinema")]
    public int CinemaId { get; set; }
    public Cinema? Cinema { get; set; }
}
