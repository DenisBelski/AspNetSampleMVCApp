﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetSampleMvcApp.Models
{
    public class CreateArticleModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string Category { get; set; }

        public string ShortSummary { get; set; }

        public string Text { get; set; }

        public DateTime PublicationDate { get; set; }

        public List<SelectListItem> Sources { get; set; }
    }
}
