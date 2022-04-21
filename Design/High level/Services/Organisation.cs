public class Organisation
{
    
}


public class  OrganisationService
{
    public bool CreateOrganisation(Organisation organisation);
    public bool UpdateOrganisation(Organisation organisation);
    public bool DisableOrganisation(int organisationId);
    public List<Organisation> GetAll();
}




