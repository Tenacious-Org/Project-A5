namespace A5.Models
{
    public class Designation
    {
        public int Id{ get; set; }
        public string?  DesignationName{ get; set; }
        public bool IsActive{ get; set; } = true;

        //Relation
        public int DepartmentId{ get; set; }
        public Department Department{ get; set; } = default!;
    }
}