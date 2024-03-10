namespace HRIS.Data.Model.Accounts
{
    public class ApplicantModel : AccountModel
    {
        public string ApplicantId { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Resume { get; set; } = string.Empty;
        public ProgressType Progress { get; set; }
    }
}
