namespace findanswer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QA")]
    public partial class QA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(899)]
        public string Question { get; set; }

        public string Q_Content { get; set; }

        [Required]
        [StringLength(20)]
        public string Q_Type { get; set; }

        [Column(TypeName = "text")]
        public string Answer { get; set; }

        [Column(TypeName = "text")]
        public string Analysis { get; set; }

        public int Cat_Id { get; set; }

        public DateTime Add_Time { get; set; }

        [StringLength(40)]
        public string Img_Path { get; set; }

        public int Flag { get; set; }

        public int Weight { get; set; }

        [StringLength(20)]
        public string From_Source { get; set; }

        [StringLength(20)]
        public string Add_Name { get; set; }

        [StringLength(50)]
        public string For_Exame { get; set; }

        [StringLength(16)]
        public string Q_Md5 { get; set; }
    }
}
