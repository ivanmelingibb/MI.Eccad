namespace MI.Eccad.Models.DTO.Orders;

public class Client : NamedEntity
{
    public string Phone { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
    public virtual ICollection<Payment> Payments { get; set; }
}
