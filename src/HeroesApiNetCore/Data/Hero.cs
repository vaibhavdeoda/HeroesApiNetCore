using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    [Table("hero1table")]
    public class Hero
    {
        [Column("id")]
        public int Id { get; set; }
                
        [Column("name")]
        public string Name { get; set; }
        [Column("active")]
        public int Active {get; set;}
    }
}
