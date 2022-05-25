using System;
using System.Collections.Generic;

#nullable disable

namespace BTS.Models.Domain.KnowledgeBase
{
    public partial class TArticleAttachment : BaseObject
    {
        public long AttachmentId { get; set; }
        public string Path { get; set; }
        public string Filename { get; set; }
        public string Extenstion { get; set; }
        public int Downloads { get; set; }
        public string Hash { get; set; }
        public DateTime? HashTime { get; set; }
        public string MimeType { get; set; }
        public long TenantId { get; set; }
        public long ArticleId { get; set; }

        public virtual TArticle Article { get; set; }
    }
}
