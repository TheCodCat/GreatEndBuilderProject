using System.ComponentModel.DataAnnotations;

namespace BuildShop.Model;

public class Delivery
{
    [Key] public int Id { get; set; }
    public DataType DayOfOrder { get; set; }
}