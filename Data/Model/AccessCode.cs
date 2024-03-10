using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Data.Model;

[Keyless]
public class AccessCode
{
    public string DateCreated { get; set; } // MYSQL and DateOnly does not match (Mysql format is yyyy-MM-dd, DateOnly format is yyyy/MM/dd)
    public string HandlerInitials { get; set; } = null!;
    public string TransactionCode { get; set; } = null!;

    public override string ToString()
    {
        return $"{DateCreated}:{HandlerInitials}:{TransactionCode}";
    }
}
