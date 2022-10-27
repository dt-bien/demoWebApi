using DemoApp.DAL;
using DemoApp.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;


namespace DemoApp.Controllers
{
    [Route("api/user")]
    public class UserController : ApiController
    {
        UserDAL userDAL;
        public UserController()
        {
            userDAL = new UserDAL();
        }
        // GET: User
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                List<UserInfo> user_lst =  userDAL.GetAll();
                return Request.CreateResponse<List<UserInfo>>(HttpStatusCode.OK, user_lst);


            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
        [HttpGet]
        public HttpResponseMessage GetById(string id)
        {
            try
            {
                UserInfo result = userDAL.GetById(id);
                return Request.CreateResponse<UserInfo>(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] UserInfo data)
        {
            try
            {
                int result = userDAL.Create(data);
                if (result > 0)
                {
                    return Request.CreateResponse<int>(HttpStatusCode.OK, result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpPut]
        public HttpResponseMessage Put(string id , [FromBody] UserInfo data)
        {
            try
            {
                int result = userDAL.Update(id,data);
                if (result > 0)
                {
                    return Request.CreateResponse<int>(HttpStatusCode.OK, result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                int result = userDAL.Delete(id);
                if (result > 0)
                {
                    return Request.CreateResponse<int>(HttpStatusCode.OK, result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

    }
}