using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobBoard.Models.Domain
{
    public class ProfileDomain
    {
        public int UserId { get; set; }
        public string Location { get; set; }
        public string Biogrphy { get; set; }
        public string Experience { get; set; }
        public string Education { get; set; }
        public string Username { get; set; }
        public string MemberSince { get; set; }
        public string PageUrl { get; set; }
        public List<string> CodeSamples { get; set; }

    }
}