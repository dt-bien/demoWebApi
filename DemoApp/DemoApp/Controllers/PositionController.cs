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
    [Route("api/position")]
    public class PositionController : ApiController
    {
        PositionDAL positionDAL;
        public PositionController()
        {
            positionDAL = new PositionDAL();
        }
        // GET: User
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                List<Position> lst = positionDAL.GetAll();
                return Request.CreateResponse<List<Position>>(HttpStatusCode.OK, lst);
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
                Position result = positionDAL.GetById(id);
                return Request.CreateResponse<Position>(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] Position data)
        {
            try
            {
                
                int result = positionDAL.Create(data);
                if (result > 0)
                {
                    return Request.CreateResponse<int>(HttpStatusCode.OK, result);
                } else
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
        public HttpResponseMessage Put(string id, [FromBody] Position data)
        {
            try
            {
                int result = positionDAL.Update(id, data);
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
                int result = positionDAL.Delete(id);
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