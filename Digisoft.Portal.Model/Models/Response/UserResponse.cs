using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;
public class UserResponse
{
    public Pagination? Pagination { get; set; }
    public List<User>? Users { get; set; }
}
