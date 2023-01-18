using MyShop.Data.Infrastructure.Interfaces;
using MyShop.Data.Repositories.Interfaces;
using MyShop.Model.Models;
using MyShop.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Service.Services
{
    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRepository _postCategoryRepository;
        IUnitOfWork _unitOfWork;
        public void Add(PostCategory postCategory)
        {
            throw new NotImplementedException();
        }

        public void Delete(PostCategory postCategory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public PostCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PostCategory postCategory)
        {
            throw new NotImplementedException();
        }
    }
}
