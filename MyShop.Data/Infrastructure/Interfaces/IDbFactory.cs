using System;
namespace MyShop.Data.Infrastructure.Interfaces
{
    public interface IDbFactory : IDisposable
    {
        MyShopDbContext Init();
    }
}