using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTS.Models.Domain.KnowledgeBase;

namespace BTS.Infrastructure.EntityMapping.KnowledgeBase
{
    public class ArticleEntityMapping
    {
        public ArticleEntityMapping(EntityTypeBuilder<TArticle> entity)
        {
            entity.HasKey(e => e.ArticleId);

            entity.ToTable("t_article");

            entity.Property(e => e.ArticleId).HasColumnName("article_id");

            entity.Property(e => e.Author).HasColumnName("author");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");

            entity.Property(e => e.Content).HasColumnName("content");

            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("created_by")
                .HasComment("The creator of the country into the database");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date")
                .HasDefaultValueSql("(getdate())")
                .HasComment("The date country was created into the database");

            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasColumnName("is_active")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.IsDraft).HasColumnName("is_draft");

            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("last_modified");

            entity.Property(e => e.Likes).HasColumnName("likes");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(255)
                .HasColumnName("modified_by");

            entity.Property(e => e.PublishEndDate)
                .HasColumnType("datetime")
                .HasColumnName("publish_end_date");

            entity.Property(e => e.PublishStartDate)
                .HasColumnType("datetime")
                .HasColumnName("publish_start_date");

            entity.Property(e => e.SelfName)
                .HasMaxLength(500)
                .HasColumnName("self_name");

            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("title");

            entity.Property(e => e.Views).HasColumnName("views");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.TArticles)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_t_article_t_article_category");
        }
    }
    public class TArticleCategoryEntityMapping
    {
        public TArticleCategoryEntityMapping(EntityTypeBuilder<TArticleCategory> entity)
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("t_article_category");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");

            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("created_by")
                .HasComment("The creator of the country into the database");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date")
                .HasDefaultValueSql("(getdate())")
                .HasComment("The date country was created into the database");

            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");

            entity.Property(e => e.Icon)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("icon");

            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasColumnName("is_active")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.IsHot).HasColumnName("is_hot");

            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("last_modified");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(255)
                .HasColumnName("modified_by");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.Property(e => e.Parent).HasColumnName("parent");

            entity.Property(e => e.SefName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("sef_name");

            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
        }
    }
    public class TArticleSettingEntityMapping
    {
        public TArticleSettingEntityMapping(EntityTypeBuilder<TArticleSetting> entity)
        {
            entity.HasKey(e => e.SettingId);

            entity.ToTable("t_article_setting");

            entity.Property(e => e.SettingId).HasColumnName("setting_id");

            entity.Property(e => e.ArticlePrefix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("article_prefix");

            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("created_by")
                .HasComment("The creator of the country into the database");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date")
                .HasDefaultValueSql("(getdate())")
                .HasComment("The date country was created into the database");

            entity.Property(e => e.DisqusShortName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("disqus_short_name");

            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasColumnName("is_active")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("last_modified");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(255)
                .HasColumnName("modified_by");

            entity.Property(e => e.TagLine)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("tag_line");
        }
    }
    public class TArticleTagEntityMapping
    {
        public TArticleTagEntityMapping(EntityTypeBuilder<TArticleTag> entity)
        {
            entity.HasKey(e => e.ArticleTagId);

            entity.ToTable("t_article_tag");

            entity.Property(e => e.ArticleTagId).HasColumnName("article_tag_id");

            entity.Property(e => e.ArticleId).HasColumnName("article_id");

            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("created_by");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");

            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasColumnName("is_active")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("last_modified");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(255)
                .HasColumnName("modified_by");

            entity.Property(e => e.TagId).HasColumnName("tag_id");

            entity.Property(e => e.TenantId).HasColumnName("tenant_id");

            entity.HasOne(d => d.Article)
                .WithMany(p => p.TArticleTags)
                .HasForeignKey(d => d.ArticleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_article_tag_t_article");

            entity.HasOne(d => d.Tag)
                .WithMany(p => p.TArticleTags)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_article_tag_t_tag");
        }
    }
    public class TTagEntityMapping
    {
        public TTagEntityMapping(EntityTypeBuilder<TTag> entity)
        {
            entity.HasKey(e => e.TagId);

            entity.ToTable("t_tag");

            entity.Property(e => e.TagId).HasColumnName("tag_id");

            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("created_by");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");

            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasColumnName("is_active")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("last_modified");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(255)
                .HasColumnName("modified_by");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
        }
    }
    public class TArticleAttachmentEntityMapping
    {
        public TArticleAttachmentEntityMapping(EntityTypeBuilder<TArticleAttachment> entity)
        {
            entity.HasKey(e => e.AttachmentId);

            entity.ToTable("t_article_attachment");

            entity.Property(e => e.AttachmentId).HasColumnName("attachment_id");

            entity.Property(e => e.ArticleId).HasColumnName("article_id");

            entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("created_by")
                .HasComment("The creator of the country into the database");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date")
                .HasDefaultValueSql("(getdate())")
                .HasComment("The date country was created into the database");

            entity.Property(e => e.Downloads).HasColumnName("downloads");

            entity.Property(e => e.Extenstion)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("extenstion");

            entity.Property(e => e.Filename)
                .IsRequired()
                .HasMaxLength(2048)
                .HasColumnName("filename");

            entity.Property(e => e.Hash)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("hash");

            entity.Property(e => e.HashTime)
                .HasColumnType("datetime")
                .HasColumnName("hash_time");

            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasColumnName("is_active")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.LastModified)
                .HasColumnType("datetime")
                .HasColumnName("last_modified");

            entity.Property(e => e.MimeType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mime_type");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(255)
                .HasColumnName("modified_by");

            entity.Property(e => e.Path)
                .IsRequired()
                .HasMaxLength(2048)
                .HasColumnName("path");

            entity.Property(e => e.TenantId).HasColumnName("tenant_id");

            entity.HasOne(d => d.Article)
                .WithMany(p => p.TArticleAttachments)
                .HasForeignKey(d => d.ArticleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_article_attachment_t_article");
        }
    }
}
