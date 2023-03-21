using Newtonsoft.Json;

namespace DigisoftPortal.Model;

public class GenericColumns
{
    public int Id { get; set; }
    [JsonIgnore]
    public bool IsActive { get; set; }
    [JsonIgnore]
    public int CreatedBy { get; set; }
    [JsonIgnore]
    public DateTime CreatedOn { get; set; }
    [JsonIgnore]
    public DateTime UpdatedOn { get; set; }
    [JsonIgnore]
    public int UpdatedBy { get; set; }
}
