public class Organisation
{
    
}
public class Department
{

}
public class Designation
{
    
}


public class  OrganisationService
{
    //Organisation
    public bool CreateOrganisation(Organisation organisation);
    public bool UpdateOrganisation(Organisation organisation);
    public bool DisableOrganisation(int organisationId);
    public Organisation GetOrganisation(int organisationId);
    public List<Organisation> GetAll();

    //Department
    public bool CreateDepartment(Department department);
    public bool UpdateDepartment(Department department);
    public bool DisableDepartment(int departmentId);
    public Department GetDepartment(int departmentId);
    public List<Department> GetAll(int organisationId);

    //Designation
    public bool CreateDesignation(Designation designation);
    public bool UpdateDesignation(Designation designation);
    public bool DisableDesignation(int designationId);
    public Designation GetDesignation(int designationId);
    public List<Designation> GetAll(int departmentId);
}




