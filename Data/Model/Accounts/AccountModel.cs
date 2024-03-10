namespace HRIS.Data.Model.Accounts;

public abstract class AccountModel : ApplicationUser
{
    public string AccountId { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public RoleType Role { get; set; }

}
