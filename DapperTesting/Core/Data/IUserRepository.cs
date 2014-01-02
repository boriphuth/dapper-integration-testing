﻿using System.Collections.Generic;
using DapperTesting.Core.Model;

namespace DapperTesting.Core.Data
{
    public interface IUserRepository
    {
        void Create(User user);
        void Delete(User user);
        User Get(int id);
        User Get(string email);
        List<User> GetAll(); 
        void Update(User user);
    }
}