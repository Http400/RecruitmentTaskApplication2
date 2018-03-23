namespace DAL.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        MyDatabaseContext dbContext;

        public MyDatabaseContext Init()
        {
            return dbContext ?? (dbContext = new MyDatabaseContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
