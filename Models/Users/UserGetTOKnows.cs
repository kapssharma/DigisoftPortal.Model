namespace DigisoftPortal.Model;
public class UserGetTOKnows
{
    public int UserGetToKnowsId { get; set; }
    public int QuestionId { get; set; }
    public string? Answer { get; set; }
    public bool AllowMultipleSelection { get; set; }
}