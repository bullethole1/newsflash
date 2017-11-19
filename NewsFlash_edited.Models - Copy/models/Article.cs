using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NewsFlash_edited.Models.models
{
  public class Article
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Header { get; set; }
    public string Summary { get; set; }
    public string Img { get; set; }
    public string Body { get; set; }
    public string Link { get; set; }
    public string Source { get; set; }
    public DateTime? Publishdate { get; set; }
    public virtual ICollection<ArticleTag> ArticleTag { get; set; }

    //public bool IsPublished { get { return this.Publishdate.HasValue; } }
  }

}
