using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsFlash_edited.Models.services;
using NewsFlash_edited.Models.models;

namespace NewsFlash_edited.Controllers
{
  [Route("api/[controller]")]
  public class ArticlesController : Controller
  {
    IArticleService articleService;

    public ArticlesController(IArticleService articleService)
    {
      this.articleService = articleService;
    }

    [HttpGet]
    public IEnumerable<Article> Get()
    {
      return articleService.GetArticles();
    }

    [HttpGet("{id}")]
    public AddArticle Get(int id)
    {
      var a = articleService.GetArticleWithTagsById(id);
      var x = new AddArticle()
      {
        Header = a.Item1.Header,
        Body = a.Item1.Body,
        Img = a.Item1.Img,
        Link = a.Item1.Link,
        Source = a.Item1.Source,
        Summary = a.Item1.Summary,
        Publishdate = a.Item1.Publishdate,
        Tags = a.Item2
      };
      return x;
    }

    [HttpPost]
    public void Post([FromBody]AddArticle value)
    {

      var article = new Article();
      article.Header = value.Header;
      article.Summary = value.Summary;
      article.Img = value.Img;
      article.Body = value.Body;
      article.Link = value.Link;
      article.Source = value.Source;
      article.Publishdate = value.Publishdate;
      articleService.AddArticle(article, value.Tags);
      
    }

    [HttpPut]
    public void Put([FromBody]Article value)
    {
      articleService.UpdateArticle(value);
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
