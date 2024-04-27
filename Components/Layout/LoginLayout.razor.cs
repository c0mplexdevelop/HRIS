using System.ComponentModel.DataAnnotations;

namespace HRIS.Components.Layout;

public partial class LoginLayout {
    public class UserInput {
        [Required(ErrorMessage = "Username is required!")]
        [StringLength(50, MinimumLength = 7, ErrorMessage = "Username must be between 7 and 50 characters!")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string AccessCode { get; set; }
    }

    public required UserInput Model { get; set; }
}