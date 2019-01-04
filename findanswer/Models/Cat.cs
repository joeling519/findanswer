namespace findanswer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cat")]
    public partial class Cat
    {
        [Key]
        public int Cat_Id { get; set; }

        [StringLength(50)]
        public string Cat_Name { get; set; }

        public int Cat_Level { get; set; }

        public int Father_Id { get; set; }

        public int Hot_Flag { get; set; }

        public int Weight { get; set; }

        [StringLength(50)]
        public string Alias_Name { get; set; }
    }
}
