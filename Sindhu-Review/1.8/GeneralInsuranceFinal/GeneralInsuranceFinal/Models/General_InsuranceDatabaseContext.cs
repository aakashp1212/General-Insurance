using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GeneralInsuranceFinal.Models
{
    public partial class General_InsuranceDatabaseContext : DbContext
    {
        public General_InsuranceDatabaseContext()
        {
        }

        public General_InsuranceDatabaseContext(DbContextOptions<General_InsuranceDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Claimhistory> Claimhistory { get; set; }
        public virtual DbSet<Claimreasons> Claimreasons { get; set; }
        public virtual DbSet<CustomerRegistration> CustomerRegistration { get; set; }
        public virtual DbSet<Insuranceduration> Insuranceduration { get; set; }
        public virtual DbSet<Insuranceplantype> Insuranceplantype { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Policydetails> Policydetails { get; set; }
        public virtual DbSet<Vehiclesdetails> Vehiclesdetails { get; set; }
        public virtual DbSet<Vehicletypes> Vehicletypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-88RRGP6T;Database=General_InsuranceDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Claimhistory>(entity =>
            {
                entity.HasKey(e => e.ClaimNo)
                    .HasName("PK__claimhis__01BDA221D26CD385");

                entity.ToTable("claimhistory");

                entity.Property(e => e.ClaimNo).HasColumnName("claimNo");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ClaimId).HasColumnName("claimId");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.PolicyNumber).HasColumnName("policyNumber");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.Claimhistory)
                    .HasForeignKey(d => d.ClaimId)
                    .HasConstraintName("FK__claimhist__claim__5BE2A6F2");

                entity.HasOne(d => d.PolicyNumberNavigation)
                    .WithMany(p => p.Claimhistory)
                    .HasForeignKey(d => d.PolicyNumber)
                    .HasConstraintName("FK__claimhist__polic__5AEE82B9");
            });

            modelBuilder.Entity<Claimreasons>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PK__claimrea__01BDF9D3A64AEA62");

                entity.ToTable("claimreasons");

                entity.Property(e => e.ClaimId).HasColumnName("claimId");

                entity.Property(e => e.Claimreason)
                    .HasColumnName("claimreason")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerRegistration>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__B611CB7D43211E12");

                entity.ToTable("Customer_Registration");

                entity.HasIndex(e => e.UserId)
                    .HasName("UQ__Customer__CB9A1CFE51054B28")
                    .IsUnique();

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contactNo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userId");
            });

            modelBuilder.Entity<Insuranceduration>(entity =>
            {
                entity.HasKey(e => e.DurationId)
                    .HasName("PK__insuranc__C3432CEBDEA22B12");

                entity.ToTable("insuranceduration");

                entity.Property(e => e.DurationId).HasColumnName("durationId");

                entity.Property(e => e.DurationValue)
                    .HasColumnName("durationValue")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Insuranceplantype>(entity =>
            {
                entity.HasKey(e => e.PlanId)
                    .HasName("PK__insuranc__A2942D388E23504B");

                entity.ToTable("insuranceplantype");

                entity.Property(e => e.PlanId).HasColumnName("planId");

                entity.Property(e => e.PlanName)
                    .HasColumnName("planName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("login");

                entity.Property(e => e.LoginId).HasColumnName("loginId");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Login)
                    .HasPrincipalKey(p => p.UserId)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__login__userId__6477ECF3");
            });

            modelBuilder.Entity<Policydetails>(entity =>
            {
                entity.HasKey(e => e.PolicyNumber)
                    .HasName("PK__policyde__57AD6F2489D40AFC");

                entity.ToTable("policydetails");

                entity.Property(e => e.PolicyNumber).HasColumnName("policyNumber");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.DurationId).HasColumnName("durationId");

                entity.Property(e => e.PlanId).HasColumnName("planId");

                entity.Property(e => e.VehicletypeId).HasColumnName("vehicletypeId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Policydetails)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__policydet__vehic__5535A963");

                entity.HasOne(d => d.Duration)
                    .WithMany(p => p.Policydetails)
                    .HasForeignKey(d => d.DurationId)
                    .HasConstraintName("FK__policydet__durat__5629CD9C");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Policydetails)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK__policydet__planI__571DF1D5");

                entity.HasOne(d => d.Vehicletype)
                    .WithMany(p => p.Policydetails)
                    .HasForeignKey(d => d.VehicletypeId)
                    .HasConstraintName("FK__policydet__vehic__5812160E");
            });

            modelBuilder.Entity<Vehiclesdetails>(entity =>
            {
                entity.HasKey(e => e.RegistrationNumber)
                    .HasName("PK__vehicles__54B7BD5EA8BC98E2");

                entity.ToTable("vehiclesdetails");

                entity.Property(e => e.RegistrationNumber)
                    .HasColumnName("registrationNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChassisNumber)
                    .HasColumnName("chassisNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.DrivingLicenseNumber)
                    .HasColumnName("drivingLicenseNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EngineNumber)
                    .HasColumnName("engineNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleAge).HasColumnName("vehicleAge");

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicleTypeId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Vehiclesdetails)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__vehiclesd__custo__440B1D61");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Vehiclesdetails)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .HasConstraintName("FK__vehiclesd__vehic__44FF419A");
            });

            modelBuilder.Entity<Vehicletypes>(entity =>
            {
                entity.HasKey(e => e.VehicleTypeId)
                    .HasName("PK__vehiclet__4709A1D44A3A6D98");

                entity.ToTable("vehicletypes");

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicleTypeId");

                entity.Property(e => e.VehicleType)
                    .HasColumnName("vehicleType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
