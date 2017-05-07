using JobBoard.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobBoard.Models.ViewModels
{
    public class JobPostListVM
    {
        public List<JobPostDomain> JobPostList {get; set;}
    }
}