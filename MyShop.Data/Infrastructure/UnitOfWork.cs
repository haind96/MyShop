using MyShop.Data.Infrastructure.Interfaces;

namespace MyShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private MyShopDbContext _dbContext;
        private IDbFactory dbFactory;

        public UnitOfWork(DbFactory dbFactory)
        {
            this._dbFactory = dbFactory;
        }

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public MyShopDbContext DbContext
        {
            get { return _dbContext ?? (_dbContext = _dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}