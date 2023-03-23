using System.ComponentModel.DataAnnotations;


public class DocumentRequest
    {
        [DataType("nvarchar(100)")]
        [Required]
        public string? Name { get; set; }

        [DataType("nvarchar(250)")]
        public string? Icon { get; set; }
    }

