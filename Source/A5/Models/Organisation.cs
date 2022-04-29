using A5.Data.Base;

namespace A5.Models
{
    public class Organisation : IEntityBase
    {
        public int Id{ get; set; }
        public string? OrganisationName{ get; set; }
        public bool IsActive{ get; set; } = true;
        public int CreatedBy {get;set;}
        public DateTime CreatedOn {get;set;}
        public int UpdatedBy {get;set;}
        public DateTime UpdatedOn {get;set;}
    }
}