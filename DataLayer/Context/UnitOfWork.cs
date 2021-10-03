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

        private GenericRepository<Receipt> _ReceiptRepository;
        public GenericRepository<Receipt> ReceiptRepository
        {
            get
            {
                if (_ReceiptRepository == null)
                {
                    _ReceiptRepository = new GenericRepository<Receipt>(db);
                }
                return _ReceiptRepository;
            }
        }

        private GenericRepository<Payment> _PaymentRepository;
        public GenericRepository<Payment> PaymentRepository
        {
            get
            {
                if (_PaymentRepository == null)
                {
                    _PaymentRepository = new GenericRepository<Payment>(db);
                }
                return _PaymentRepository;
            }
        }

        private GenericRepository<Cardex> _CardexRepository;
        public GenericRepository<Cardex> CardexRepository
        {
            get
            {
                if (_CardexRepository == null)
                {
                    _CardexRepository = new GenericRepository<Cardex>(db);
                }
                return _CardexRepository;
            }
        }

        private GenericRepository<Inventory> _InventoryRepository;
        public GenericRepository<Inventory> InventoryRepository
        {
            get
            {
                if (_InventoryRepository == null)
                {
                    _InventoryRepository = new GenericRepository<Inventory>(db);
                }
                return _InventoryRepository;
            }
        }

        private GenericRepository<LoginTime> _LogintimeRepository;
        public GenericRepository<LoginTime> LogintimeRepository
        {
            get
            {
                if (_LogintimeRepository == null)
                {
                    _LogintimeRepository = new GenericRepository<LoginTime>(db);
                }
                return _LogintimeRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}