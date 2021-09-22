using DataLayer.Repository;
using DataLayer.Services;
using System;

namespace DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Navik_DBEntities db = new Navik_DBEntities();

        //private ILoginRepository _loginRepository;
        //public ILoginRepository loginRepository
        //{
        //    get
        //    {
        //        if (_loginRepository == null)
        //        {
        //            _loginRepository = new LoginRepository(db);
        //        }
        //        return _loginRepository;
        //    }
        //}
        private GenericRepository<Login> _LoginRepository;
        public GenericRepository<Login> LoginRepository
        {
            get
            {
                if (_LoginRepository == null)
                {
                    _LoginRepository = new GenericRepository<Login>(db);
                }
                return _LoginRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}