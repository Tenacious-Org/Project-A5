namespace A5API.Models
{
    public class Employee
    {
        public int Id{ get; init; }
        public string? ACEId{ get; init;}
        public string? Fname{ get; init;}
        public string? Lname{get; init;}
        public string? Email{ get; init; }
        public int OrganisationId{ get; init; }
        public int DepartmentId{ get; init; }
        public int DesignationId{ get; init; }
        public int ReportingPersonId{ get; init; }
        public int HRId{ get; init; }
        public string? Password{ get; init;}

    }
}
