using MI.Eccad.Models.API.Responses.Products;
using MI.Eccad.Models.DTO.DominicalSchool;

namespace MI.Eccad.Models.API.Responses.DominicalSchool;

public class DominicalSchoolProductResponse : ProductResponse
{
    public SemesterResponse Semester { get; set; }
    public GenerationResponse Generation { get; set; }
    public DominicalSchoolProductType Type { get; set; }
}
