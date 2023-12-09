using System.ComponentModel.DataAnnotations;

namespace CS.Services.Orders.Api.Models;

public class Order
{
    public DateTime Date { get; set; }

    public Guid Id { get; set; }

    public string? CustomerCode { get; set; }

    [Required]
    public List<OrderItem>? Items { get; set; }
}