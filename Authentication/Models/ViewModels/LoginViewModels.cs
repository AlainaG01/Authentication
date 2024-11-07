using System.ComponentModel.DataAnnotations;

namespace Authentication.Models.ViewModels;

public class LoginViewModels
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese nombre de usuario")]
    public string? UserName { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese su password")]
    public string? Password { get; set; }
}
