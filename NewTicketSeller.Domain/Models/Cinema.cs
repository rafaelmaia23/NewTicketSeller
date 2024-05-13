using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewTicketSeller.Domain.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(100, ErrorMessage = "Max characters permited: 100")]
    public string Name { get; set; }
    [Required]
    [ForeignKey("Address")]
    public int AddressId { get; set; }
    public Address Address { get; set; }
}
