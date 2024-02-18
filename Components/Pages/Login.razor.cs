using System.ComponentModel.DataAnnotations;

namespace HRIS.Components.Pages
{
    public partial class Login
    {
        public class UserInput
        {
            [Required]
            [DataType(DataType.Password)]
            public string? UserPassword { get; set; }
        }

        public UserInput model = new UserInput();
        

        public void Submit()
        {
            Logger.LogInformation($"{model!.UserPassword}");
        }
    }
}
