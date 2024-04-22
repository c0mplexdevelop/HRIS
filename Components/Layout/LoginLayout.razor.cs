namespace HRIS.Components.Layout;

public partial class LoginLayout {
    public class UserInput {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required int AccessCode { get; set; }
    }

    public required UserInput Model { get; set; }
}