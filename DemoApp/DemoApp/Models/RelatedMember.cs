using DemoApp.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.Models
{
    public class RelatedMember
    {
        public List<UserInfo> Supervisor { get; set; }
        public List<UserInfo> Member { get; set; }
    }
}