using System;
using System.Collections.Generic;

#nullable disable

namespace BTS.Models.Domain.KnowledgeBase
{
    public partial class TArticleTag : BaseObject
    {
        public long ArticleTagId { get; set; }
        public long TagId { get; set; }
        public long ArticleId { get; set; }
        public long TenantId { get; set; }

        public virtual TArticle Article { get; set; }
        public virtual TTag Tag { get; set; }
    }
}
