using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobBoard.Models.Domain
{
    public class JobPostDomain
    {
        public int JobPostId { get; set; }
        public DateTime PostingDate { get; set; }
        public string Title { get; set; }
        public  string Description { get; set; }
        public List<string> Skills { get; set; }
        public List<UserDomain> Applicants { get; set; }
    }
}