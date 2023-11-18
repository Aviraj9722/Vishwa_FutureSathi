using FutureSathi.IServices;
using FutureSathi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutureSathi.Services
{
    public class UserRepo : IUser
    {
        FutureSathiEntities ctx = new FutureSathiEntities();
        public bool Login(tblUser obj)
        {
            return true;
        }

     

        public bool Signin(UserClass obj)
        {
            if (obj != null)
            {
                try
                {
                    tblUser U = new tblUser();
                    U.First_Name = obj.First_Name;
                    U.Last_Name = obj.Last_Name;
                    U.Gender_id = obj.Gender_id;
                    U.Contact = obj.Mobile_No;
                    U.Email = obj.Email;
                    U.Password = obj.Password;


                    ctx.tblUsers.Add(U);
                    ctx.SaveChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false; 

                }
            }

            return false;
        }
    }
}