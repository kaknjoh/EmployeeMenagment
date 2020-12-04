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
                new Employee (){Id=1, Name="Harun", Department=Dept.Hr, Email="harun.kaknjo@size.ba"},
                new Employee (){Id=2, Name="Ahmet", Department=Dept.IT, Email="ahmet.durmic@size.ba"},
                new Employee (){Id=3, Name="Muhamed", Department=Dept.Payroll, Email="muhamed.malkoc@size.ba"}
            };

        }
        public Employee GetEmployee(int Id){
            return _employeeList.FirstOrDefault(e=> e.Id ==Id);

        }

        public IEnumerable<Employee>  getAllEmployees()
        {
            return _employeeList;
        }


        public Employee Add(Employee employee){
            employee.Id=_employeeList.Max(e => e.Id)+1;
            _employeeList.Add(employee);
            return employee;
        }


    }

}