public class AwardRequest
{

}
public class Award
{

}
public class Comment
{

}

public class AwardService
{
    //Request
    public bool RaiseRequest(AwardRequest request);

    //Approval
    public bool Approve(int requestId);
    public bool Reject(int requestId);

    //Publish
    public bool Publish(AwardRequest request);

    //Comment
    public void AddComment(Comment comment);
    public List<Comment> GetComments(int AwardRequestId);


//Award
    public bool CreateAward(Award award);
    public bool DisableAward(Award award);
    public bool UpdateAward(Award award);
    public List<Award> GetAllAward();

}
