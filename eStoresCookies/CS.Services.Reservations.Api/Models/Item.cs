using System.ComponentModel.DataAnnotations;

namespace CS.Services.Reservations.Api.Models;

public class Item
{
    [Required]
    public string? SKU { get; set; }

    public int Quantity { get; set; }
}