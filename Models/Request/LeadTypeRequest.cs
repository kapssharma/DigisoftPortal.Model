using System.ComponentModel.DataAnnotations;


public class LeadTypeRequest
{
   
    [MaxLength(length: 30)]
    [Required]

    public string Name { get; set; }
}
