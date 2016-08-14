using Keligula.Data;
using KellyProject.Models.Requests;
using KellyProject.Models.Responses;
using KellyProject.Services.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KellyProject.Domain;
using System.Data;

namespace KellyProject.Controllers.ApiControllers
{

    [RoutePrefix("api/yoga")]
    public class YogaApiController : ApiController
    {

        private IYogaService _yogaService { get; set; }

        public YogaApiController(IYogaService yogaService)

        {
            _yogaService = yogaService;
        }


        // POST: Add new practice to database
        [Route("practices"), HttpPost]
        public HttpResponseMessage InsertPractice(YogaPracticeRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            ItemResponse<int> response = new ItemResponse<int>();

            response.Item = _yogaService.AddYogaPractice(model);

            return Request.CreateResponse(response);

        }


        // GET: List All Practices Index
        [Route, HttpGet]
        public HttpResponseMessage List()

        {

            ItemsResponse<Domain.YogaPractice> response = new ItemsResponse<Domain.YogaPractice>();

            response.Items = _yogaService.List();

            return Request.CreateResponse(response);

        }


        // GET: List Practices by YogiId
        [Route("{YogiId:int}"), HttpGet]
        public HttpResponseMessage GetPracticesByYogiId(int YogiId)

        {

            ItemsResponse<Domain.YogaPractice> response = new ItemsResponse<Domain.YogaPractice>();

            response.Items = _yogaService.GetPracticesByYogiId(YogiId);

            return Request.CreateResponse(response);

        }


        // PUT: Update Practice by PracticeId
        [Route("{PracticeId:int}"), HttpPut]
        public HttpResponseMessage UpdatePracticeById(YogaPracticeRequestModel model, int PracticeId)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            SuccessResponse response = new SuccessResponse();

            _yogaService.UpdatePracticeById(model, PracticeId);      

            return Request.CreateResponse(response);

        }


        // DELETE: Practice by Practice Id
        [Route("{PracticeId:int}"), HttpDelete]
        public HttpResponseMessage DeletePagesById(int PracticeId)
        {
            SuccessResponse response = new SuccessResponse();

            _yogaService.DeletePracticeById(PracticeId);

            return Request.CreateResponse(response);

        }


    }
}
