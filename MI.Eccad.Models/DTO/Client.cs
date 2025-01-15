namespace MI.Eccad.Models.DTO;

public class Client : NamedEntity
{
    public string Phone { get; set; }
    public List<Order> Orders { get; set; }
    public List<Payment> Payments { get; set; }
}
