using System.ComponentModel.DataAnnotations;

namespace CS.Services.Orders.Api.Models;

public class Item
{
    [Required]
    public string? SKU { get; set; }

    public int Quantity { get; set; }
}