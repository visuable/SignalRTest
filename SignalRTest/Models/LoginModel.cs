using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRTest.Models
{
    public class LoginModel
    {
        [Key]
        public string Login{ get; set; }
        public string Password { get; set; }
    }
}
