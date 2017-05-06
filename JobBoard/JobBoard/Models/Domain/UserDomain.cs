using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobBoard.Models.Domain
{
    public class UserDomain
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public List<SkillDomain> Skills { get; set; }
    }
}