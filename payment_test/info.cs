using System.ComponentModel.DataAnnotations;
namespace payment_test
{
    public class info
    {
        
        public int Id { get; set; }

        [Required]
        public string? Name {get; set; }

        [Phone]
        public int Phone { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime? Date { get; set; }

        [Range(0,99)]
        public int Age { get; set; }


        public bool Gender { get; set; }

        [StringLength(20,MinimumLength = 3,ErrorMessage ="Invalid Name" )]
        public string? Comment { get; set; }
    }
}
