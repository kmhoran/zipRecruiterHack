using JobBoard.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobBoard.Services
{
    public class SkillService
    {
        public static SkillDomain GetCs(int level)
        {
            SkillDomain skill = new SkillDomain { Skill = "C#", Level = level };

            return skill;
        }

        public static SkillDomain GetHtml(int level)
        {
            SkillDomain skill = new SkillDomain { Skill = "HTML", Level = level };

            return skill;
        }

        public static SkillDomain GetJS(int level)
        {
            SkillDomain skill = new SkillDomain { Skill = "JavaScript", Level = level };

            return skill;
        }

        public static SkillDomain GetCSS(int level)
        {
            SkillDomain skill = new SkillDomain { Skill = "CSS", Level = level };

            return skill;
        }

        public static SkillDomain GetAngular(int level)
        {
            SkillDomain skill = new SkillDomain { Skill = "AngularJS", Level = level };

            return skill;
        }


        public static SkillDomain GetSQL(int level)
        {
            SkillDomain skill = new SkillDomain { Skill = "SQL", Level = level };

            return skill;
        }
    }
}