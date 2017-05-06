using JobBoard.Models.Domain;
using JobBoard.Models.Responses;
using JobBoard.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace JobBoard.Controllers.ApiControllers
{
    [RoutePrefix("api/jobposts")]
    public class JobPostApiController: ApiController
    {
        [Route("all"), HttpGet]
        public HttpResponseMessage GetAllJobPosts()
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            List<JobPostDomain> jobPosts = PostService.GetAllJobPosts();

            var response = new ItemsResponse<JobPostDomain> { Items = jobPosts };

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}