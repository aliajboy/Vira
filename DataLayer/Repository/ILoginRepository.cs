using System;
using System.Collections.Generic;

namespace DataLayer.Repository
{
    public interface ILoginRepository
    {
        List<Login> GetAllUsers();
        Login GetById(int id);
        Login GetByUsername(string username);
        bool AddUser(Login login);
        bool UpdateUser(Login login);
        bool DeleteUser(int id);
        void Save();
    }
}
