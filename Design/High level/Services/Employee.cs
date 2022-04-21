public class Employee
{

}



public class EmployeeService
{
    public bool CreateEmployee(Employee employee);
    public bool UpdateEmployee(Employee employee);
    public bool DisableEmployee(int employeeId);
    public Employee GetEmployee(int employeeId);
    public List<Employee> GetAllEmployee();
}

