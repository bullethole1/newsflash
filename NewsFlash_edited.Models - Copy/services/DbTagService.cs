using System;
using System.Collections.Generic;
using System.Text;
using NewsFlash_edited.Models.models;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NewsFlash_edited.Models.services
{
  public class DbTagService : ITagService
  {

    private readonly ArticleDbContext context;

    public DbTagService(ArticleDbContext _context)
    {

      this.context = _context;

    }

    public void AddTag(Tag tag)
    {
      try
      {
        context.Tag.Add(tag);
        context.SaveChanges();
      }
      catch (Exception ex)
      {
        Debug.WriteLine(ex.Message);
        throw ex;
      }
    }

    public IEnumerable<Tag> GetTags()
    {
      List<Tag> tagList = new List<Tag>();
      tagList = context.Tag.ToList();
      return tagList;
    }

    public Tag GetTagsById(int id)
    {
      return context.Tag.Find(id);
    }

    public void UpdateTag(Tag tag)
    {
      try
      {
        context.Entry(tag).State = EntityState.Modified;
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
