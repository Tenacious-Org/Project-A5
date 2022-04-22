public class Award
{

}

public class Comment
{

}

public class AwardService
{
    //Request
    public bool RaiseRequest(Award award);

    //Approval
    public bool Approve(int AwardId);
    public bool Reject(int AwardId);

    //Publish
    public bool Publish(int AwardId);

    //Award
    public Award GetAward(int AwardId);
    public List<Awards> GetAwardRequest(int employeeId);
    public List<Awards> GetAwards(Employee employeeName);

    //Comment
    public void AddComment(Comment comment);
    public List<Comment> GetComments(int AwardId);




}
