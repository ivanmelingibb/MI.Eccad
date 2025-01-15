namespace MI.Eccad.Models.DTO.DominicalSchool;

public class Semester : NamedEntity
{
    public virtual ICollection<DominicalSchoolProduct> Products { get; set; }
}
