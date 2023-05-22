using System.ComponentModel.DataAnnotations;

namespace Digisoft.Portal.Model.Models.Request;

public class ChangePasswordViewModel
{
    public int Id { get; set; }
    [Required]
    [DataType(DataType.Password)]

    public string CurrentPassword { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string NewPassword { get; set; }

    [DataType(DataType.Password)]
    [Compare("NewPassword", ErrorMessage =
        "The new password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
}
