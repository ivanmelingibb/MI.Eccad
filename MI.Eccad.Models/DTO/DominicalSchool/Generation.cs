namespace MI.Eccad.Models.DTO.DominicalSchool;

public class Generation : NamedEntity
{
    public string Description { get; set; }
    public virtual ICollection<DominicalSchoolProduct> Products { get; set; }
}