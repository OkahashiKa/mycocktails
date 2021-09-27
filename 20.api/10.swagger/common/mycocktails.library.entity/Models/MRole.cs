using System;
using System.Collections.Generic;

#nullable disable

namespace mycocktails.library.entity.Models
{
    public partial class MRole
    {
        public MRole()
        {
            MUsers = new HashSet<MUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<MUser> MUsers { get; set; }
    }
}
