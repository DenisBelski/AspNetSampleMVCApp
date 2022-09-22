using AspNetSample.Core;
using System.ComponentModel.DataAnnotations;

namespace AspNetSampleMvcApp.Models
{
    public class CreateSourceModel
    {
        //[Remote("url")] -> create request on server, and will be wait answer
        public string Name { get; set; }

        [Required]
        [Url]
        //[EmailAddress]
        //[CreditCard]
        public string Url { get; set; }

        public SourceType SourceType { get; set; }
    }
}
