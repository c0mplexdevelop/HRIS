using System.ComponentModel.DataAnnotations;
using HRIS.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

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

        [Required(ErrorMessage = "Access code is required!")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Access code must be 6 characters!")]
        public string AccessCode { get; set; }
    }

    public required UserInput Model = new UserInput {
        Username = "",
        Password = "",
        AccessCode = ""
    };

    [Inject]
    private ILogger<LoginLayout> Logger { get; set; }

    [Inject]
    private IDbContextFactory<ApplicationDbContext> contextFactory { get; set; }

    private void HandleValidSubmit(EditContext editContext) {
        Logger.LogInformation("Form submitted!");
        Logger.LogInformation($"Username: {Model.Username}");

        using var context = contextFactory.CreateDbContext();

        if(context.GetUser(Model.Username, Model.Password) is null) {
            Logger.LogWarning("User not found!");
        } else {
            Logger.LogInformation("User found!");
        }
    }

    private void HandleInvalidSubmit(EditContext editContext) {
        Logger.LogWarning("Form invalid!");
    }
}