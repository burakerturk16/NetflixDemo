﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();

        IDataResult<User> GetById(int userId);
        IResult Add(User user);

        IResult Delete(User user);

        IResult Update(User user);

        List<OperationClaim> GetClaims(User user);

        User GetByEmail(string email);

        IDataResult<User> GetUserByEmail(string email);
    }
}