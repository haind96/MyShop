using AutoMapper;
using MyShop.Model.Models;
using MyShop.Service.Services.Interfaces;
using MyShop.Web.Infrastructure.Core;
using MyShop.Web.Mappings;
using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyShop.Web.Infrastructure.Extentions;

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
                var mapper = AutoMapperConfiguration.Configure().CreateMapper();
                var listCategory = _postCategoryService.GetAll();

                //var listPostCategoryVm = Mapper.Map<List<PostCategoryViewModel>>(listCategory);

                var listPostCategoryVm = listCategory.Select
                            (
                              emp => mapper.Map<PostCategory, PostCategoryViewModel>(emp)
                            );
                HttpResponseMessage response = requestMessage.CreateResponse(HttpStatusCode.OK, listCategory);

                return response;
            });
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage requestMessage, PostCategoryViewModel postCategoryVm)
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
                     PostCategory postCategory = new PostCategory();
                     postCategory.UpdatePostCategory(postCategoryVm);
                     var category = _postCategoryService.Add(postCategory);
                     _postCategoryService.Save();
                     response = requestMessage.CreateResponse(HttpStatusCode.Created, category);
                 }
                 return response;
             });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage requestMessage, PostCategoryViewModel postCategoryVm)
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
                    var postCategoryDb = _postCategoryService.GetById(postCategoryVm.ID);
                    postCategoryDb.UpdatePostCategory(postCategoryVm);
                    _postCategoryService.Update(postCategoryDb);
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