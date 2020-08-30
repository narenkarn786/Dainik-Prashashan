using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dainikprashashan.Models
{
    public class Login
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }
    }
}