using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class LoginRepository 
    {
        private Navik_DBEntities db;
        public LoginRepository(Navik_DBEntities context)
        {
            db = context;
        }
        //public bool AddUser(Login login)
        //{
        //    try
        //    {
        //        db.Logins.Add(login);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool DeleteUser(int id)
        //{
        //    try
        //    {
        //        db.Logins.Remove(GetById(id));
        //        return true;
        //    }
        //    catch
        //    {

        //        return false;
        //    }
        //}

        public List<Login> GetAllUsers()
        {
            return db.Logins.ToList();
        }

        //public Login GetById(int id)
        //{
        //    return db.Logins.Find(id);
        //}

        public Login GetByUsername(string username)
        {
            return db.Logins.Find(username);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool UpdateUser(Login login)
        {
            try
            {
                db.Entry(login).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}
