using NewsFlash_edited.Models.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsFlash_edited.Models.services
{
  public class FakeArticleService : IArticleService
  {
    public static List<Article> Articles;

    public FakeArticleService()
    {
      if (Articles != null)
        return;

      Articles = new List<Article> { new Article()
            {
              Id = 1,
              Header = "Annie Lööf vill se mer blocköverskridande samarbete",
              Img = "https://w.cdn-expressen.se/images/b0/18/b01859cad44c4fc290d73a07154f2f4e/16x9/680.jpg",
              Summary = "Centerledaren Annie Lööf anser att det behövs mer blocköverskridande samarbeten den kommande mandatperioden.Det säger hon i en intervju med Dagens Nyheter: – Vi behöver vara ett parti som kan attrahera både allmänborgerliga väljare och väljare över blockgränsen. Vi är ett utpräglat mittenparti och har varit det under ganska lång tid.",
              Body = "Alliansen är splittrad kring regeringsfrågan: KD och M är beredda att ta makten med stöd av SD, men samarbete utesluts. C och L är emot att regera med stöd av SD. – Vi har en gemensam plan A: Vi vill ha en egen majoritet. Vi har en gemensam plan B: Vi vill vinna valet så att vi fyra blir större än de tre rödgröna. Men anta att alliansen fullkomligt förlorar valet. C vill då fälla Stefan Löfven och att de fyra allianspartierna för en diskussion med S och MP om hur landet ska styras. Där har vi lite olika ingångar, sa Anders W Jonsson (C), gruppledare i riksdagen, nyligen till Expressen.",
              Link = "http://www.expressen.se/nyheter/annie-loof-vill-se-mer-blockoverskridande-samarbeten/",
            },
            new Article()
            {
              Id = 2,
              Header = "Expressen",
              Img = "img",
              Summary = "summary",
              Body = "body",
              Link = "link",
            },
            new Article()
            {
              Id = 3,
              Header = "Svenska Dagbladet",
              Img = "img",
              Summary = "summary",
              Body = "body",
              Link = "link",
            },
            new Article()
            {
              Id = 4,
              Header = "Dagens Nyheter",
              Img = "img",
              Summary = "summary",
              Body = "body",
              Link = "link",
            }
       };
    }

    public void AddArticle(Article article)
    {
      Articles.Add(article);
    }

    public void AddArticle(Article article, IEnumerable<string> tags)
    {
      throw new NotImplementedException();
    }

    public Article GetArticleById(int id)
    {
      return Articles.Where(a => a.Id == id).SingleOrDefault();

    }

    public IEnumerable<Article> GetArticles()
    {
      return Articles;
    }

    public Tuple<Article, IEnumerable<string>> GetArticleWithTagsById(int id)
    {
      throw new NotImplementedException();
    }

    public void UpdateArticle(Article article)
    {
      int i = Articles.FindIndex(x => x.Id == article.Id);
      Articles[i] = article;
    }
  }
}
