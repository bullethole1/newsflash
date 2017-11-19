using NewsFlash_edited.Models.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsFlash_edited.Models.services
{
  public interface ITagService
  {
    IEnumerable<Tag> GetTags();

    Tag GetTagsById(int id);

    void AddTag(Tag tag);

    void UpdateTag(Tag tag);

  }
}
