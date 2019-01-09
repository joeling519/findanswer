namespace findanswer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FindAnswerMsSqlModel : DbContext
    {
        public static string conn = "server=172.26.7.21;database=DB_FindAnswer;user=sa;pwd=Mi123456";
        public FindAnswerMsSqlModel()
            : base("name=FindAnswerMsSqlModel")
        {
        }

        //对于web.config中不存放connectstring的处理
        public FindAnswerMsSqlModel(string conStr)
            : base(conStr)
        {
        }

        public virtual DbSet<Cat> Cat { get; set; }
        public virtual DbSet<QA> QA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>()
                .Property(e => e.Cat_Name)
                .IsUnicode(false);

            modelBuilder.Entity<QA>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<QA>()
                .Property(e => e.Q_Content)
                .IsUnicode(false);

            modelBuilder.Entity<QA>()
                .Property(e => e.Q_Type)
                .IsUnicode(false);

            modelBuilder.Entity<QA>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<QA>()
                .Property(e => e.Analysis)
                .IsUnicode(false);

            modelBuilder.Entity<QA>()
                .Property(e => e.Img_Path)
                .IsUnicode(false);

            modelBuilder.Entity<QA>()
                .Property(e => e.From_Source)
                .IsUnicode(false);

            modelBuilder.Entity<QA>()
                .Property(e => e.Add_Name)
                .IsUnicode(false);

            modelBuilder.Entity<QA>()
                .Property(e => e.For_Exame)
                .IsUnicode(false);

            modelBuilder.Entity<QA>()
                .Property(e => e.Q_Md5)
                .IsUnicode(false);
        }
    }
}
