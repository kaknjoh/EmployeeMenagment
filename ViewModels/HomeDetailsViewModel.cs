using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMenagment.Models;

namespace EmployeeMenagment.ViewModels 
{ 

    public class HomeDetailsViewModel 
    {
        public Employee Employee { get; set; }
        public string PageTitle { get; set; }
    }
}