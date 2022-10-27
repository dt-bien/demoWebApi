using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DemoApp.DatabaseContext
{
    public class UserInfo
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string UserName { get; set; }

        // khoa ngoai bang position
        public string PositionId { get; set; }
        public Position Position_FK { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }

        // khoa ngoai bang userinfo
        
        public string Supervisor_Id { get; set; }
        public UserInfo UserInfo_FK { get; set; }
        public List<UserInfo> UserInfoLst { get; set; }

    }
}