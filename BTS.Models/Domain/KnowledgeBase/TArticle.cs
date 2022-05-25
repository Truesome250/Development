using System;
using System.Collections.Generic;

#nullable disable

namespace BTS.Models.Domain.KnowledgeBase
{
    public partial class TArticle
    {
        public TArticle()
        {
            TArticleTags = new HashSet<TArticleTag>();
            TArticleAttachments = new HashSet<TArticleAttachment>();
        }

        public long ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? Views { get; set; }
        public int? Likes { get; set; }
        public bool? IsDraft { get; set; }
        public DateTime? PublishStartDate { get; set; }
        public DateTime? PublishEndDate { get; set; }
        public long Author { get; set; }
        public long? CategoryId { get; set; }
        public string SelfName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public bool? IsActive { get; set; }

        public virtual TArticleCategory Category { get; set; }
        public virtual ICollection<TArticleTag> TArticleTags { get; set; }
        public virtual ICollection<TArticleAttachment> TArticleAttachments { get; set; }
    }
}
