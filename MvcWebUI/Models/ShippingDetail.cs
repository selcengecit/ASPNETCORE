using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Models
{
    public class ShippingDetail
    {
       // [Required(ErrorMessage ="İsim zorunludur.")]
        public string FirstName { get; set; }
       // [Required(ErrorMessage = "Soyisim zorunludur.")]
        public string LastName { get; set; }
       // [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string City { get; set; }
       // [MinLength(10,ErrorMessage ="Minumum 10 karakter olmalı.")]
        public string Address { get; set; }
       // [Range(18,65)]
        public int Age { get; set; }
    }
}
