using AspNetSample.DataBase.Entities;

namespace AspNetSample.Core.DataTransferObjects
{
    public class ArticleDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string ShortSummary { get; set; }
        public string Text { get; set; }

        public DateTime PublicationDate { get; set; }

        //public ArticleDto(Article article)
        //{
        //    Id = article.Id;
        //    Title = article.Title;
        //    Category = "Default";
        //    Text = article.FullText;
        //    PublicationDate = article.PublicationDate;
        //    ShortSummary = article.ShortDescription;
        //}
    }
}
