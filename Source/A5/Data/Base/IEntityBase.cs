namespace A5.Data.Base
{
    public interface IEntityBase
    {
        int Id{ get; set;}
        bool IsActive{ get; set; }
        int CreatedBy {get;set;}
        DateTime CreatedOn {get;set;}
        int UpdatedBy {get;set;}
        DateTime UpdatedOn {get;set;}
    }
}