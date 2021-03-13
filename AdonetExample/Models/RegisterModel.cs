using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdonetExample.Models
{
    public class RegisterModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="UserName is Cannot be Empty")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is Cannot be Empty")]

        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Pwd and Cpwd Cannot be Empty")]
        public string ConfirmPassword { get; set; }
        [Range(19,29, ErrorMessage = "Age Should btw 19-29")]
        public int Age { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Email id  invalid /not in correct format")]
        public string EmailId { get; set; }
        [StringLength(10,ErrorMessage ="More then 10 Not Allowed")]
        public string Address { get; set; }
    }
}