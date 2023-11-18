using FutureSathi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutureSathi.IServices
{
    public interface IUser
    {
        bool Signin(UserClass obj);
        bool Login(tblUser obj);

    }
}