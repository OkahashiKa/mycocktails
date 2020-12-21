using System;
using System.Collections.Generic;

#nullable disable

namespace mycocktails.library.entity.Models
{
    public partial class MCocktailMaterial
    {
        public int CocktailId { get; set; }
        public int MaterialId { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual MCocktail Cocktail { get; set; }
        public virtual MMaterial Material { get; set; }
    }
}
