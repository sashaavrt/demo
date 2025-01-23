using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace demoexam.Models;

public partial class AverinaAContext : DbContext
{
    public AverinaAContext()
    {
    }

    public AverinaAContext(DbContextOptions<AverinaAContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<Guest> Guests { get; set; }

    public virtual DbSet<Integration> Integrations { get; set; }

    public virtual DbSet<Rent> Rents { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomAccess> RoomAccesses { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<Statistic> Statistics { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=KP11MSSQL-S1.OUIIT.LOCAL;Database=averina_a;Encrypt=True;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bill>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GuestId).HasColumnName("guest_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.RentId).HasColumnName("rent_id");
            entity.Property(e => e.ServiceId).HasColumnName("service_id");
            entity.Property(e => e.Sum).HasColumnName("sum");

            entity.HasOne(d => d.Guest).WithMany(p => p.Bills)
                .HasForeignKey(d => d.GuestId)
                .HasConstraintName("FK_Bills_Guests");

            entity.HasOne(d => d.Rent).WithMany(p => p.Bills)
                .HasForeignKey(d => d.RentId)
                .HasConstraintName("FK_Bills_Rents");

            entity.HasOne(d => d.Service).WithMany(p => p.Bills)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("FK_Bills_Services");
        });

        modelBuilder.Entity<Guest>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Passport).HasColumnName("passport");
            entity.Property(e => e.Patronym).HasColumnName("patronym");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Surname).HasColumnName("surname");
        });

        modelBuilder.Entity<Integration>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IntegrationDetails)
                .HasMaxLength(50)
                .HasColumnName("integration_details");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Rent>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Checkin).HasColumnName("checkin");
            entity.Property(e => e.Checkout).HasColumnName("checkout");
            entity.Property(e => e.GuestId).HasColumnName("guest_id");
            entity.Property(e => e.RoomId).HasColumnName("room_id");

            entity.HasOne(d => d.Guest).WithMany(p => p.Rents)
                .HasForeignKey(d => d.GuestId)
                .HasConstraintName("FK_Rents_Guests");

            entity.HasOne(d => d.Room).WithMany(p => p.Rents)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_Rents_Rooms");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Floor).HasColumnName("floor");
            entity.Property(e => e.Room1).HasColumnName("room");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<RoomAccess>(entity =>
        {
            entity.ToTable("Room_Access");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.GuestId).HasColumnName("guest_id");
            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");

            entity.HasOne(d => d.Guest).WithMany(p => p.RoomAccesses)
                .HasForeignKey(d => d.GuestId)
                .HasConstraintName("FK_Room_Access_Guests");

            entity.HasOne(d => d.Room).WithMany(p => p.RoomAccesses)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_Room_Access_Rooms");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cleaner).HasColumnName("cleaner");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.RoomId).HasColumnName("room_id");

            entity.HasOne(d => d.Room).WithMany(p => p.Shifts)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK_Shifts_Rooms");
        });

        modelBuilder.Entity<Statistic>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Adr)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("adr");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.OccupancyRate)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("occupancy_rate");
            entity.Property(e => e.Revenue)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("revenue");
            entity.Property(e => e.Revpar)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("revpar");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FalledLoginAttempts)
                .HasDefaultValue(0)
                .HasColumnName("falledLoginAttempts");
            entity.Property(e => e.IsFirstLogin).HasColumnName("isFirstLogin");
            entity.Property(e => e.IsLocked)
                .HasDefaultValue(false)
                .HasColumnName("isLocked");
            entity.Property(e => e.LastLoginDate)
                .HasColumnType("datetime")
                .HasColumnName("lastLoginDate");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Role).HasColumnName("role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
