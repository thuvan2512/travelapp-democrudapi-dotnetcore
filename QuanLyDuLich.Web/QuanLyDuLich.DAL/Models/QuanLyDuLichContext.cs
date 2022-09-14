using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QuanLyDuLich.DAL.Models
{
    public partial class QuanLyDuLichContext : DbContext
    {
        public QuanLyDuLichContext()
        {
        }

        public QuanLyDuLichContext(DbContextOptions<QuanLyDuLichContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<DonDatTour> DonDatTours { get; set; }
        public virtual DbSet<LichTrinh> LichTrinhs { get; set; }
        public virtual DbSet<TinTuc> TinTucs { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=QuanLyDuLich;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NoiDung).IsRequired();

                entity.Property(e => e.TinTucId).HasColumnName("TinTucID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.TinTuc)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.TinTucId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comment__TinTucI__145C0A3F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comment__UserID__15502E78");
            });

            modelBuilder.Entity<DonDatTour>(entity =>
            {
                entity.ToTable("DonDatTour");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.Property(e => e.TourId).HasColumnName("TourID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.DonDatTours)
                    .HasForeignKey(d => d.TourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DonDatTou__TourI__164452B1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DonDatTours)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DonDatTou__UserI__173876EA");
            });

            modelBuilder.Entity<LichTrinh>(entity =>
            {
                entity.ToTable("LichTrinh");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NoiDung).IsRequired();

                entity.Property(e => e.TieuDe)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TourId).HasColumnName("TourID");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.LichTrinhs)
                    .HasForeignKey(d => d.TourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichTrinh__TourI__182C9B23");
            });

            modelBuilder.Entity<TinTuc>(entity =>
            {
                entity.ToTable("TinTuc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChuDe)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NoiDung).IsRequired();
            });

            modelBuilder.Entity<Tour>(entity =>
            {
                entity.ToTable("Tour");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.LoaiTour)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");

                entity.Property(e => e.NgayKhoiHanh).HasColumnType("datetime");

                entity.Property(e => e.TenTour)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
