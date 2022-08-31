using AspNetSample.Core.DataTransferObjects;

namespace AspNetSample.Core
{
    public class ArticlesStorage
    {
        public readonly List<ArticleDto> ArticlesList;
        
        public ArticlesStorage()
        {
            ArticlesList = new List<ArticleDto>()
            {
                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                },

                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                },

                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                },

                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                },

                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                },

                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                },

                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                },

                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                },
            };
        }
    }
}
