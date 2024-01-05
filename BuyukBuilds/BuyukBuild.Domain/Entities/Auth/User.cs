using BuyukBuild.Domain.Entities.Auth.AuthMethods;
using BuyukBuild.Domain.Entities.Cards;
using BuyukBuild.Domain.Entities.Carts;
using BuyukBuild.Domain.Entities.Comments;
using BuyukBuild.Domain.Entities.Common;
using BuyukBuild.Domain.Entities.Orders;
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
    public long CardId { get; set; }
    [Column("is_bloked")] 
    public bool IsBlocked { get; set; } = false;

    public virtual Structure Structure { get; set; }
    [Column("structure_id")] public long StructureId { get; set; }

    public virtual ICollection<Cart> Carts { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
    public virtual ICollection<Comment> Comments { get; set; }
    public virtual Card Card { get; set; }
    public virtual ICollection<AuthMethodBase> AuthMethods { get; set; }
}