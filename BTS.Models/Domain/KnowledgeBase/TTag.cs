using System;
using System.Collections.Generic;

#nullable disable

namespace BTS.Models.Domain.KnowledgeBase
{
    public partial class TTag : BaseObject
    {
        public TTag()
        {
            TArticleTags = new HashSet<TArticleTag>();
        }

        public long TagId { get; set; }
        public string Name { get; set; }
        public long? TenantId { get; set; }

        public virtual ICollection<TArticleTag> TArticleTags { get; set; }
    }
}
