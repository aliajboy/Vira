using DataLayer.Repository;
using DataLayer.Services;
using System;

namespace DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Navik_DBEntities db = new Navik_DBEntities();

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

        private GenericRepository<Persons> _UserRepository;
        public GenericRepository<Persons> UserRepository
        {
            get
            {
                if (_UserRepository == null)
                {
                    _UserRepository = new GenericRepository<Persons>(db);
                }
                return _UserRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}