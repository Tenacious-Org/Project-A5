public class Award
{

}
public class Comment
{

}

public class AwardService
{
    //Request
    public bool RaiseRequest();

    //Approval
    public void Accept();
    public void Reject();

    //Publish
    public bool Publish();

    //Comment
    public void AddComment();
    public List<Comment> GetAll();


//Award
    public bool CreateAward();
    public bool DisableAward();
    public bool UpdateAward();
    public List<Award> GetAllAward();

}
