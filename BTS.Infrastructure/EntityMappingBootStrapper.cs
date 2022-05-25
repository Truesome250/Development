using BTS.Infrastructure.EntityMapping.KnowledgeBase;
using BTS.Models.Domain.KnowledgeBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS.Infrastructure
{
    public class EntityMappingBootStrapper
    {
        public static void OnModelCreating(ModelBuilder builder)
        {
            new ArticleEntityMapping(builder.Entity<TArticle>());
            new TArticleCategoryEntityMapping(builder.Entity<TArticleCategory>());
            new TArticleSettingEntityMapping(builder.Entity<TArticleSetting>());
            new TArticleTagEntityMapping(builder.Entity<TArticleTag>());
            new TTagEntityMapping(builder.Entity<TTag>());
        }
    }
}
