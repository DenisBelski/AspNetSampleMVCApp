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
                    Text = "Curabitur congue ligula et mollis dapibus. Etiam sit amet sagittis ex, non malesuada diam. Donec ac vestibulum magna. Donec id dui sit amet libero ultrices vulputate. Vestibulum euismod eros urna, eget varius ligula dapibus eu. Proin aliquam malesuada velit, et mollis mauris dignissim sit amet. Aenean ut elit eu erat rutrum pulvinar at a neque.",
                },

                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                    Text = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec vitae mauris ut justo porta condimentum. Quisque convallis malesuada tellus, eget tincidunt urna sodales eget. Nam ut est ultricies, elementum dui nec, egestas ante. Proin mi nibh, ornare ut augue nec, convallis dignissim magna. Sed egestas eleifend lacus in malesuada. Maecenas sagittis augue vel enim tempus imperdiet.",
                },

                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                    Text = "Etiam dictum, justo id fringilla blandit, purus ante dapibus lacus, ac rhoncus libero lorem ut elit. Sed non neque nulla. Phasellus volutpat vestibulum risus ut semper. Interdum et malesuada fames ac ante ipsum primis in faucibus. Sed ex enim, porta quis suscipit a, dignissim vulputate nibh. Aenean laoreet feugiat dapibus. Nam in dui a sem vehicula sagittis.",
                },

                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                    Text = "In risus nibh, semper quis lacus quis, gravida aliquam urna. Nullam vel mauris nec erat rutrum porttitor et id turpis. Duis malesuada finibus eros, vel tristique diam scelerisque in. Fusce bibendum vitae turpis sed congue. Cras ultricies elit eu pretium facilisis. Quisque bibendum, est eget ultricies semper, arcu ante dignissim urna, non fermentum metus tortor at lectus.",
                },

                new ArticleDto()
                {
                    Id = Guid.NewGuid(),
                    Title = "Lorem ipsum dolor sit amet",
                    PublicationDate = DateTime.Now,
                    Category = "News",
                    ShortSummary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eu efficitur felis, ac faucibus tortor. Sed convallis ipsum non ligula porttitor mollis. In elit purus, tempus eu aliquam et, imperdiet sed nibh. Vivamus placerat nunc fermentum ante aliquam, eget ornare lectus varius. Cras lectus arcu, venenatis at turpis in, rutrum hendrerit eros. Phasellus volutpat mattis lacus, id lobortis quam. Morbi mi orci, hendrerit vel lorem non, tincidunt fringilla nisi. Donec congue leo ac efficitur facilisis. Aenean sed semper purus, quis efficitur libero. Maecenas euismod lorem ut dolor suscipit iaculis.",
                    Text = "Cras eleifend lacus quis blandit ultrices. Maecenas nisi sapien, euismod id malesuada eu, vehicula vel quam. Vestibulum consequat vehicula tincidunt. Nunc ac felis quis ipsum volutpat scelerisque ac eu justo. Vivamus quis cursus lorem, ac feugiat lectus.",
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
