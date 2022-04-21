public class Department
{

}

public class DepartmentService
{
    public bool CreateDepartment(Department department);
    public bool UpdateDepartment(Department department);
    public bool DisableDepartment(int departmentId);
    public List<Department> GetAll();
}
