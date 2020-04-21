using StardewValleyAPI.Entities;
using StardewValleyAPI.Entities.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StardewValleyAPI.API.Entities
{
    public class Weapon
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Location { get; set; }

        [Required]
        [MaxLength(5)]
        public string CriticalStrikeChance { get; set; }

        [Required]
        public string Type { get; set; }


        public string Stats { get; set; }

        public string Image { get; set; }

        [Required]
        public string Damage { get; set; }
        public int SellPrice { get; set; }
        public int PurchasePrice { get; internal set; }
    }
}
