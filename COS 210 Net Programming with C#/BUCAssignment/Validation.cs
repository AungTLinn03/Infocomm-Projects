using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BUCAssignment
{
    public class Validation
    {
        [Required]
        public string UserName{get;set;}
        public string Password{get;set;}

    }
}
