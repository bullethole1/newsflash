using Microsoft.EntityFrameworkCore;
using NewsFlash_edited.Models.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace NewsFlash_edited.Models.services
{
  public class DbArticleService : IArticleService
  {

    private readonly ArticleDbContext context;

    public DbArticleService(ArticleDbContext _context)
    {
      this.context = _context;
    }

    public void AddArticle(Article article, IEnumerable<string> tags)
    {
      article.ArticleTag = new List<ArticleTag>();

      foreach (var tagName in tags)
      {
        var x = context.Tag.Where(z => z.Name.ToLower() == tagName.ToLower()).SingleOrDefault();
        if (x == null)
        {
          var tag = new Tag();
          tag.Name = tagName;
          var atag = new ArticleTag();
          atag.Tag = tag;
          article.ArticleTag.Add(atag);
          context.Tag.Add(tag);
        }
        else
        {
          var atag = new ArticleTag();
          atag.Tag = x;
          article.ArticleTag.Add(atag);
          context.Tag.Add(x);
        }
      }
      context.Article.Add(article);
      context.SaveChanges();
    }

    public Article GetArticleById(int id)
    {
      return context.Article.Where(a => a.Id == id).SingleOrDefault();
    }

    public IEnumerable<Article> GetArticles()
    {

      List<Article> resultsList = new List<Article>();
      resultsList = context.Article.ToList();
      return resultsList;
    }

    public Tuple<Article, IEnumerable<string>> GetArticleWithTagsById(int id)
    {
      List<string> tagList = new List<string>();

      return Tuple.Create(context.Article.Where(a => a.Id == id).SingleOrDefault(), tagList.AsEnumerable());
    }

    public void UpdateArticle(Article article)
    {
      try
      {
        context.Entry(article).State = EntityState.Modified;

        context.SaveChanges();
      }
      catch (Exception ex)
      {

        Debug.WriteLine(ex.Message);
        throw ex;
      }
    }
  }
}
