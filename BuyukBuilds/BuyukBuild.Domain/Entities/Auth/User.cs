using BuyukBuild.Domain.Entities.Common;
using BuyukBuild.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuyukBuild.Domain.Entities.Auth;

[Table("user" , Schema = "buyukbuild")]
public class User : AuditableBaseEntity<long>
{
    [Column("first_name")] 
    public string FirstName { get; set; }
    [Column("last_name")] 
    public string? LastName { get; set; }
    [Column("date_of_brith")] 
    public DateTimeOffset DateOfBrith { get; set; }
    [Column("phone_number")] 
    public string PhoneNumber { get; set; }
    [Column("user_role")]
    public UserRole UserRole { get; set; }
    [Column("email")] 
    public string Email { get; set; }

    [Column("card_id")]
    public string CardId { get; set; }
    [Column("is_bloked")] 
    public bool IsBlocked { get; set; } = false;
}