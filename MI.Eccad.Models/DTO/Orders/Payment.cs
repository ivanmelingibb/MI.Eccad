namespace MI.Eccad.Models.DTO.Orders;

public class Payment : BaseEntity
{
    public virtual Client Client { get; set; }
    public virtual Order Order { get; set; }
    public decimal Amount { get; set; }
}
