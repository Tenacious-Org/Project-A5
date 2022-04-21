public class Employee
{

}



public class EmployeeService
{
    public bool CreateEmployee(Employee employee);
    public bool UpdateEmployee(Employee employee);
    public bool DisableEmployee(Employee employee);
    public List<Employee> GetEmployeeById(Employee employeeId);
    public List<Employee> GetAllEmployee(Employee allemployee);
}

