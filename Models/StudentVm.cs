using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace WebKalkulator.Models
{
    public class StudentVm
    {
        [Display (Name="Id Person")]
        public int IdPerson { get; set; }
        [Display(Name = "Id Student")]
        public int IdStudent { get; set; }

        [Display (Name ="Fach: ")]
        public string Fach {  get; set; }
    }
}
