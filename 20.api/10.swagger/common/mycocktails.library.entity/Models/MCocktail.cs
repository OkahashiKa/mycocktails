using System;
using System.Collections.Generic;

#nullable disable

namespace mycocktails.library.entity.Models
{
    public partial class MCocktail
    {
        public MCocktail()
        {
            MCocktailRecipis = new HashSet<MCocktailRecipi>();
            MUsers = new HashSet<MUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public byte[] Image { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<MCocktailRecipi> MCocktailRecipis { get; set; }
        public virtual ICollection<MUser> MUsers { get; set; }
    }
}
