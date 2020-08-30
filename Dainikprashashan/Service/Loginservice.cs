using Dainikprashashan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Dainikprashashan.Service
{
    public class Loginservice
    {
        //Register
        public string SaveRegister(Login ml)
        {
            var message = "";
            using (var Context = new Entities())
            {
                var user = new Login()
                {
                    Username = ml.Username,
                    Password = ml.Password,
                    Confirm_Password = ml.Confirm_Password
                };
                Context.Logins.Add(user);

                Context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }

        //Login
        public Tuple<string, int> SaveLogin(Login ll)
        {
            var message = "";
            using (var Context=new Entities())
            {
                var loginData = Context.Logins
                          .Where(lg => lg.Username == ll.Username && lg.Password == ll.Password)
                          .FirstOrDefault<Login>();
                if (loginData.Username != "")
                {
                    message = "true";
                }
                else
                {
                    message = "false";
                }
                return Tuple.Create(message, Convert.ToInt32(loginData.UserId));
            }
        }
    }
}


