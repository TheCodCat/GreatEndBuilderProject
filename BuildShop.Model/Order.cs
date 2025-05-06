using System.ComponentModel.DataAnnotations;

namespace BuildShop.Model;

public class Order
{
    [Key] public int Id { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Addres { get; set; }
}