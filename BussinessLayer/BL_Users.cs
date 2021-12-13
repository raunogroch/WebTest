using DataLayer;
using System;

namespace BussinessLayer
{
    public class BL_Users
    {
        private DL_User usersObject = new DL_User();
        public bool authentication(string email, string password)
        {
            //bool response = false;
            return usersObject.authentication(email, password);
            /*if(email == null || password == null) { 
                response=false; 
            }
            if (email.Equals("ranr23@gmail.com") && password.Equals("admin123"))
            {
                response=true;
            }
            return response;*/
        }
    }
}
