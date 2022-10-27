using DemoApp.BUS;
using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;


namespace DemoApp.Controllers
{
    [Route("api/relatedmember")]
    public class RelatedMemberController : ApiController
    {
        UserBUS userBus;
        public RelatedMemberController()
        {
            userBus = new UserBUS();
        }
        [HttpGet]
        public HttpResponseMessage GetById(string id)
        {
            try
            {
                RelatedMember result = userBus.GetAllRelatedMember(id);
                return Request.CreateResponse<RelatedMember>(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

    }
}