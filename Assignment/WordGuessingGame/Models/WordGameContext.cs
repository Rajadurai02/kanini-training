using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WordGuessingGame.Models
{
    public partial class WordGameContext : DbContext
    {
        public WordGameContext()
        {
        }

        public WordGameContext(DbContextOptions<WordGameContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ScoreBoard> ScoreBoards { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserWord> UserWords { get; set; }
        public virtual DbSet<Word> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data source=KANINI-LTP-474\\KANINISQLSERVER;Integrated Security=true;Initial Catalog=WordGame");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ScoreBoard>(entity =>
            {
                entity.HasKey(e => e.ScoreId)
                    .HasName("PK__ScoreBoa__7DD229D1619FCC83");

                entity.ToTable("ScoreBoard");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.ScoreBoards)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK__ScoreBoar__UserN__02FC7413");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__UserDeta__C9F284573A747672");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserWord>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserWord__1788CC4CE32671D5");

                entity.ToTable("UserWord");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Word)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.UserWords)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK__UserWord__UserNa__6FE99F9F");
            });

            modelBuilder.Entity<Word>(entity =>
            {
                entity.Property(e => e.RandomWord)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
