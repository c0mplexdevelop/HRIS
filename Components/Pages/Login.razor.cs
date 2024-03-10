using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;
using HRIS.Data;
using HRIS.Data.Model;

namespace HRIS.Components.Pages
{
    public partial class Login
    {

        [Inject]
        private ILogger<Login> Logger { get; set; }

        [Inject]
        private ApplicationDbContext DbContext { get; set; }

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
            var segments = model.UserPassword!.Split(":");
            var accessCode = new AccessCode
            {
                DateCreated = segments[0],
                HandlerInitials = segments[1],
                TransactionCode = segments[2]
            };

            Console.WriteLine(accessCode.DateCreated);


            // q: query the database for the keyless accesscode
            var codeFromDB = DbContext.AccessCodes.Where(e => e.DateCreated == accessCode.DateCreated).AsEnumerable().ToList();

            // print the codes from codeFromDB
            Console.WriteLine("Access Codes from DB");
            Console.WriteLine(codeFromDB[0]);


        }
    }
}
