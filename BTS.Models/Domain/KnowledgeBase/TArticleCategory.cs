using System;
using System.Collections.Generic;

#nullable disable

namespace BTS.Models.Domain.KnowledgeBase
{
    public partial class TArticleCategory :BaseObject
    {
        public TArticleCategory()
        {
            TArticles = new HashSet<TArticle>();
        }

        public long CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsHot { get; set; }
        public string SefName { get; set; }
        public string Icon { get; set; }
        public long? Parent { get; set; }
        public string Description { get; set; }
        public long TenantId { get; set; }

        public virtual ICollection<TArticle> TArticles { get; set; }
    }
}
