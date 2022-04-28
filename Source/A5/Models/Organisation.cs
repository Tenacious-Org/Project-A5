namespace A5.Models
{
    public class Organisation
    {
        public int OrganisationId{ get; set; }
        public string? OrganisationName{ get; set; }
        public bool IsActive{ get; set; } = true;
    }
}