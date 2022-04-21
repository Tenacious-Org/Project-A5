public class Designation
{

}

public class DesignationService
{
    public bool CreateDesignation(Designation designation);
    public bool UpdateDesignation(Designation designation);
    public bool DisableDesignation(Designation designation);
    public List<Designation> GetAll();
}
