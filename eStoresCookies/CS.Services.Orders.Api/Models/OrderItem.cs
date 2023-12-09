using System.ComponentModel.DataAnnotations;

namespace CS.Services.Orders.Api.Models;

public class OrderItem
{
    [Required]
    public string? ProductCode { get; set; }

    public int Quantity { get; set; }
}
