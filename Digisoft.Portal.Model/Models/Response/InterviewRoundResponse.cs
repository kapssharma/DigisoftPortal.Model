using DigisoftPortal.Model.Models.Shared;

namespace DigisoftPortal.Model.Models.Response;

public class InterviewRoundResponse
{
    public Pagination Pagination { get; set; }
    public List<InterviewRound>? InterviewRounds { get; set; }
}
