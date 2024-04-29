using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;
using HRIS.Data;

namespace HRIS.Components.Pages;

public partial class Login
{
    public class UserInput
    {

        [Inject]
        private ILogger<Login> Logger { get; set; }

        [Inject]
        private ApplicationDbContext DbContext { get; set; }
    }
}

