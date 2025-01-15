namespace MI.Eccad.Models.DTO;

public class Payment : BaseEntity
{
    public Client Client { get; set; }
    public Order Order { get; set; }
    public decimal Amount { get; set; }
}
