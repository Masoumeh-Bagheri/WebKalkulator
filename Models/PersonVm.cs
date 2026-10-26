using System.ComponentModel.DataAnnotations;

namespace WebKalkulator.Models
{
    public class PersonVm
    {

        [Display(Name="Id Person")]
        public int Id { get; set; }
        [Display(Name="Name Person")]
        public string FirstName { get; set; }
        [Display(Name ="Lastname Person")]
        public string Lastname { get; set; }
        //public int Age { get; set; }
    }
}

