public class Department
{

}

public class DepartmentService
{
    public bool CreateDepartment(Department department);
    public bool UpdateDepartment(Department department);
    public bool DisableDepartment(Department department);
    public List<Department> GetAll(Department allDepartment);
}
