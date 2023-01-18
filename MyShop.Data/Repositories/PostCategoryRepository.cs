using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop.Data.Infrastructure;
using MyShop.Data.Infrastructure.Interfaces;
using MyShop.Data.Repositories.Interfaces;
using MyShop.Model.Models;

namespace MyShop.Data.Repositories
{
    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
