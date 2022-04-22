public class AwardType
{

}

public class AwardService
{
    //Award Type
    public bool CreateAward(AwardType award);
    public bool DisableAward(int awardId);
    public bool UpdateAward(AwardType award);
    public AwardType GetAwardType(int awardId);
    public List<AwardType> GetAllAwardType();
}