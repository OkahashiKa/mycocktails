using System;
using System.Collections.Generic;

#nullable disable

namespace mycocktails.library.entity.Models
{
    public partial class MCocktail
    {
        public MCocktail()
        {
            MCocktailMaterials = new HashSet<MCocktailMaterial>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual ICollection<MCocktailMaterial> MCocktailMaterials { get; set; }
    }
}
