using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRTest.ViewModels
{
    public class ViewLoginModel
    {
        [Required(ErrorMessage = "Заполните поле.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Заполните поле.")]
        public string Password { get; set; }
    }
}
