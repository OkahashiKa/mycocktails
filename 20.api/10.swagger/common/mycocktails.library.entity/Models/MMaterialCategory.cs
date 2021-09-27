using System;
using System.Collections.Generic;

#nullable disable

namespace mycocktails.library.entity.Models
{
    public partial class MMaterialCategory
    {
        public MMaterialCategory()
        {
            MMaterials = new HashSet<MMaterial>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<MMaterial> MMaterials { get; set; }
    }
}
