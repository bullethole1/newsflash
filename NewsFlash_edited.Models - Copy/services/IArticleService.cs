using NewsFlash_edited.Models.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NewsFlash_edited.Models.services
{
  public interface IArticleService
  {
    IEnumerable<Article> GetArticles();

    Article GetArticleById(int id);

    Tuple<Article, IEnumerable<string>> GetArticleWithTagsById(int id);

    void AddArticle(Article article, IEnumerable<string> tags);

    void UpdateArticle(Article article);

  }
}
