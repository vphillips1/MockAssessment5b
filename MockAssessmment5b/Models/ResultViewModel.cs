using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssessmment5b.Models
{
    public class ResultViewModel
    {
      [Display(Name = "User Number:")]
      public double Num1 { get; set; }
       [Display(Name = "User Number:")]
       public double Num2  { get; set; }

        [Display(Name= "Answer:")]
        public double Operation { get; set; }
    }
}
