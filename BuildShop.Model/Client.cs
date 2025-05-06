using System.ComponentModel.DataAnnotations;

namespace BuildShop.Model;

public class Client
{
    [Key] public int Id { get; set; }
    public string NickName { get; set; }
    public string Email { get; set; }
}