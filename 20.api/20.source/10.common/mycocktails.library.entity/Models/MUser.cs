using System;
using System.Collections.Generic;

#nullable disable

namespace mycocktails.library.entity.Models
{
    public partial class MUser
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public int RoleId { get; set; }
        public int? FavoCocktailId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual MCocktail FavoCocktail { get; set; }
        public virtual MRole Role { get; set; }
    }
}
