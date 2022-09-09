using AspNetSample.Core.DataTransferObjects;

namespace AspNetSampleMvcApp.Models
{
    public class ArticleWithCommentsViewModel
    {
        public ArticleDto Article { get; set; }
        public List<string> Comments { get; set; }
    }
}
