
using System.ComponentModel.DataAnnotations;

namespace Digisoft.Portal.Model.Models.Request;

public class ResetPasswordModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "New password required", AllowEmptyStrings = false)]
    [DataType(DataType.Password)]
    public string NewPassword { get; set; }

    [DataType(DataType.Password)]
    [Compare("NewPassword", ErrorMessage = "New password and confirm password does not match")]
    public string ConfirmPassword { get; set; }

    [Required]
    public string ResetCode { get; set; }

}
