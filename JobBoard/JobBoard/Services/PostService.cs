using JobBoard.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobBoard.Services
{
    public class PostService
    {
        /*
         public int JobPostId { get; set; }
        public string Title { get; set; }
        public  string Description { get; set; }
        public List<string> Skills { get; set; }
        public List<UserDomain> Applicants { get; set; }

         */

        
        public static JobPostDomain JP1 = new JobPostDomain
        {
            JobPostId = 1,
            Title = "Full-stack Developer",
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            Skills = new List<string> { "C#", "HTML", "CSS", "JavaScript"},

        };
        public static JobPostDomain JP2 = new JobPostDomain
        {
            JobPostId = 1,
            Title = "Jr Dev Wanted Immediately",
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            Skills = new List<string> { "C#", "HTML", "CSS", "JavaScript" },

        };
        public static JobPostDomain JP3 = new JobPostDomain
        {
            JobPostId = 1,
            Title = "Interactive Developer",
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
            Skills = new List<string> { "C#", "HTML", "CSS", "JavaScript" },

        };

        public static List<JobPostDomain> GetAllJobPosts ()
        {
            List<JobPostDomain> postingList = new List<JobPostDomain>();
            postingList.Add(JP1);
            postingList.Add(JP2);
            postingList.Add(JP3);

            return postingList;
        }
    }

}