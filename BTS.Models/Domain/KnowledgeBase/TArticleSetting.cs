using System;
using System.Collections.Generic;

#nullable disable

namespace BTS.Models.Domain.KnowledgeBase
{
    public partial class TArticleSetting : BaseObject
    {
        public long SettingId { get; set; }
        public string DisqusShortName { get; set; }
        public string ArticlePrefix { get; set; }
        public string TagLine { get; set; }
        public long TenantId { get; set; }
    }
}
