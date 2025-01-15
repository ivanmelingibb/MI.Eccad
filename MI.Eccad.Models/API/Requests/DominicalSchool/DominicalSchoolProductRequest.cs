using MI.Eccad.Models.API.Requests.Products;
using MI.Eccad.Models.DTO.DominicalSchool;

namespace MI.Eccad.Models.API.Requests.DominicalSchool;

public class DominicalSchoolProductRequest : ProductRequest
{
    public int SemesterId { get; set; }
    public int GenerationId { get; set; }
    public DominicalSchoolProductType Type { get; set; }
}
