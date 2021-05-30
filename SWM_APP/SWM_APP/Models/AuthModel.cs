using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWM_APP.Models
{
    public class AuthModel
    {
        public string Password { get; set; }
        public bool ChecAdmin()
        {
            return (this.Password == "123");
        }
    }
}
