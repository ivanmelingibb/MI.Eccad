using MI.Eccad.Models.DTO.Products;

namespace MI.Eccad.Models.DTO.DominicalSchool;

public class DominicalSchoolProduct : Product
{
    public virtual Semester Semester { get; set; }
    public virtual Generation Generation { get; set; }
    public DominicalSchoolProductType Type { get; set; }
}

public enum DominicalSchoolProductType
{
    Teacher = 1,
    Student = 2
}
