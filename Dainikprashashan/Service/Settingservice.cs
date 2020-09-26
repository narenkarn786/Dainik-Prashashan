using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dainikprashashan.Service
{
    public class Settingservice
    {
        //saving karyalaya
        public string SaveKaryalaya(Karyalaya k)
        {
            var message = "";
            using (var context = new Entities1())
            {
                var user = new Karyalaya()
                {
                    Karyalaya1 = k.Karyalaya1
                    
                };
                context.Karyalayas.Add(user);

                context.SaveChanges();
                message = "save successfull";
            }
            return message;
        }
    }
}