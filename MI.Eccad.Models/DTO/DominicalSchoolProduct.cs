namespace MI.Eccad.Models.DTO;

public class DominicalSchoolProduct : Product
{
    public Semester Semester { get; set; }
    public Generation Generation { get; set; }
    public DominicalSchoolProductType Type { get; set; }
}

public enum DominicalSchoolProductType
{
    Teacher,
    Student
}
