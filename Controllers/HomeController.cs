using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeMenagment.Models;
using EmployeeMenagment.ViewModels;

namespace EmployeeMenagment.Controllers 
{
    public class HomeController : Controller{
        private  readonly IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository=employeeRepository;
        }
        public ViewResult Index(){
                var model= _employeeRepository.getAllEmployees();
                return View(model);
        }   

        public ViewResult Details(){
                Employee model= _employeeRepository.GetEmployee(1);
                HomeDetailsViewModel homeDetailsViewModel=new HomeDetailsViewModel();
                homeDetailsViewModel.Employee=model;
                homeDetailsViewModel.PageTitle="Employee Details";
                return View(homeDetailsViewModel);
        }
    }


}