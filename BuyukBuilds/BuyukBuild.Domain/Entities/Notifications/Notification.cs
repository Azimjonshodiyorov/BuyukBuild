using BuyukBuild.Domain.Entities.Auth;
using BuyukBuild.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Entities.Notifications
{
    [Table("notification", Schema = "Notifications")]
    public class Notification : AuditableBaseEntity<long>
    {
        [Column("message")]
        public string Message { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("user_id") , ForeignKey(nameof(User))]
        public long UserId { get; set; }

        [Column("receiver_or_not")]
        public bool ReceivedOrNot { get; set; }
        [Column("read_or_not")]
        public bool ReadOrNot { get; set; }

    }
}
