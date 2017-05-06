using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobBoard.Models.Domain
{
    public class SkillDomain
    {
        public string Skill { get; set; }
        public int Level { get; set; }
    }
}