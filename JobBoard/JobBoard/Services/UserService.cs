using JobBoard.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobBoard.Services
{
    public class UserService
    {
        public static UserDomain GetUser1()
        {
            UserDomain user = new UserDomain
            {
                UserId = 1,
                Name = "PEDRO RAMIREZ",
                Skills = new List<SkillDomain>()
            };

            user.Skills.Add(SkillService.GetCs(50));
            user.Skills.Add(SkillService.GetAngular(25));
            user.Skills.Add(SkillService.GetSQL(55));

            return user;
        }
    }
}