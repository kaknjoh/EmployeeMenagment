using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace EmployeeMenagment.Models 
{ 
    public class MockEmployeeRepository: IEmployeeRepository 
    { 
        private List<Employee> _employeeList;
        public MockEmployeeRepository(){
            _employeeList=new List<Employee>(){
                new Employee (){Id=1, Name="Harun", Department="HR", Email="harun.kaknjo@size.ba"},
                new Employee (){Id=2, Name="Ahmet", Department="IT", Email="ahmet.durmic@size.ba"},
                new Employee (){Id=3, Name="Muhamed", Department="IT", Email="muhamed.malkoc@size.ba"}
            };

        }
        public Employee GetEmployee(int Id){
            return _employeeList.FirstOrDefault(e=> e.Id ==Id);

        }


    }

}