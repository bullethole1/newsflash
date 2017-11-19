using Microsoft.EntityFrameworkCore;
using NewsFlash_edited.Models.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsFlash_edited.Models.services
{
    public class ArticleDbContext : DbContext
    {
        public ArticleDbContext(DbContextOptions<ArticleDbContext> options) : base(options) { }

        public DbSet<Article> Article { get; set; }
        public DbSet<Tag> Tag { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArticleTag>()
            .HasKey(t => new { t.ArticleId, t.TagId });

        modelBuilder.Entity<ArticleTag>()
            .HasOne(pt => pt.Article)
            .WithMany(p => p.ArticleTag)
            .HasForeignKey(pt => pt.ArticleId);

        modelBuilder.Entity<ArticleTag>()
            .HasOne(pt => pt.Tag)
            .WithMany(t => t.ArticleTag)
            .HasForeignKey(pt => pt.TagId);
    }


    }
}
