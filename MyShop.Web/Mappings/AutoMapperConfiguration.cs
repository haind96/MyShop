using AutoMapper;
using MyShop.Web.App_Start;

namespace MyShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration Configure()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<Post, PostViewModel>();
                //cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                //cfg.CreateMap<Tag, TagViewModel>();
                cfg.AddProfile<MappingProfile>();
            });

            config.AssertConfigurationIsValid();

            return config;
        }
    }
}