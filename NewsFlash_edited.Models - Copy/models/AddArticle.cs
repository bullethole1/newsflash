using System;
using System.Collections.Generic;
using System.Text;

namespace NewsFlash_edited.Models.models
{
    public class AddArticle
    {
    public string Header { get; set; }
    public string Summary { get; set; }
    public string Img { get; set; }
    public string Body { get; set; }
    public string Link { get; set; }
    public string Source { get; set; }
    public DateTime? Publishdate { get; set; }
    public IEnumerable<string> Tags { get; set; }
  }
}
