using System;

namespace DAL.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        MyDatabaseContext Init();
    }
}
