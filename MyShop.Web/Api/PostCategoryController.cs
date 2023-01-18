using MyShop.Model.Models;
using MyShop.Service.Services.Interfaces;
using MyShop.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyShop.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiBaseController
    {
        IPostCategoryService _postCategoryService;   
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage requestMessage)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listCategory = _postCategoryService.GetAll();
                    _postCategoryService.Save();
                    response = requestMessage.CreateResponse(HttpStatusCode.OK, listCategory);
                }
                return response;
            });
        }

        public HttpResponseMessage Post(HttpRequestMessage requestMessage,PostCategory postCategory)
        {
            return CreateHttpResponse(requestMessage, () =>
             {
                 HttpResponseMessage response = null;
                 if(!ModelState.IsValid)
                 {
                     requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else
                 {
                     var category =_postCategoryService.Add(postCategory);
                     _postCategoryService.Save();
                     response=requestMessage.CreateResponse(HttpStatusCode.Created,category);
                 }
                 return response;
             });
        }

        public HttpResponseMessage Put(HttpRequestMessage requestMessage, PostCategory postCategory)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Update(postCategory);
                    _postCategoryService.Save();
                    response = requestMessage.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage requestMessage, int id)
        {
            return CreateHttpResponse(requestMessage, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.Save();
                    response = requestMessage.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
    }
}