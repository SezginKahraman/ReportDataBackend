using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ReportDataBackend.Entity.Concrete;

namespace ReportDataBackend.Entity;

public partial class ReportDataBackendContext : DbContext
{
    public ReportDataBackendContext()
    {
    }

    public ReportDataBackendContext(DbContextOptions<ReportDataBackendContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EntraGroup> EntraGroups { get; set; }

    public virtual DbSet<EntraGroupAssignment> EntraGroupAssignments { get; set; }

    public virtual DbSet<EntraGroupModification> EntraGroupModifications { get; set; }

    public virtual DbSet<EntraPimactivation> EntraPimactivations { get; set; }

    public virtual DbSet<EntraRole> EntraRoles { get; set; }

    public virtual DbSet<EntraServicePrincipal> EntraServicePrincipals { get; set; }

    public virtual DbSet<EntraUserAccount> EntraUserAccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost,1440;Database=Identity; User=SA;Password=ReportDataBackend2024*!; Trusted_Connection=false; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EntraGroup>(entity =>
        {
            entity.HasKey(e => e.AzGroupId).HasName("PK__EntraGro__2BD512486424EA82");

            entity.Property(e => e.AzGroupId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_GroupID");
            entity.Property(e => e.AzCreatedDate)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_CreatedDate");
            entity.Property(e => e.AzGroupName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_GroupName");
            entity.Property(e => e.AzGroupsDescription)
                .IsUnicode(false)
                .HasColumnName("az_GroupsDescription");
            entity.Property(e => e.AzStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("az_Status");
            entity.Property(e => e.DbModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("db_ModifiedDate");
        });

        modelBuilder.Entity<EntraGroupAssignment>(entity =>
        {
            entity.HasKey(e => e.DbGroupAssignmentId).HasName("PK__EntraGro__4E7109E8F59436D2");

            entity.Property(e => e.DbGroupAssignmentId).HasColumnName("db_GroupAssignmentID");
            entity.Property(e => e.AzAssignmentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("az_AssignmentType");
            entity.Property(e => e.AzGroupId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_GroupID");
            entity.Property(e => e.AzRoleId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_RoleID");
            entity.Property(e => e.AzStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("az_Status");
            entity.Property(e => e.DbModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("db_ModifiedDate");

            entity.HasOne(d => d.AzGroup).WithMany(p => p.EntraGroupAssignments)
                .HasForeignKey(d => d.AzGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EntraGrou__az_Gr__4CA06362");

            entity.HasOne(d => d.AzRole).WithMany(p => p.EntraGroupAssignments)
                .HasForeignKey(d => d.AzRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EntraGrou__az_Ro__4BAC3F29");
        });

        modelBuilder.Entity<EntraGroupModification>(entity =>
        {
            entity.HasKey(e => e.DbGroupModificationId).HasName("PK__EntraGro__BC4D9906D21F4F9E");

            entity.ToTable("EntraGroupModification");

            entity.Property(e => e.DbGroupModificationId).HasColumnName("db_GroupModificationID");
            entity.Property(e => e.AzAction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("az_Action");
            entity.Property(e => e.AzGroupId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_GroupID");
            entity.Property(e => e.AzInitiatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_InitiatedBy");
            entity.Property(e => e.AzModifiedDate)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_ModifiedDate");
            entity.Property(e => e.DbUserAccountId).HasColumnName("db_UserAccountID");

            entity.HasOne(d => d.AzGroup).WithMany(p => p.EntraGroupModifications)
                .HasForeignKey(d => d.AzGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EntraGrou__az_Gr__3A81B327");

            entity.HasOne(d => d.DbUserAccount).WithMany(p => p.EntraGroupModifications)
                .HasForeignKey(d => d.DbUserAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EntraGrou__db_Us__3B75D760");
        });

        modelBuilder.Entity<EntraPimactivation>(entity =>
        {
            entity.HasKey(e => e.DbPimid).HasName("PK__EntraPIM__2AE82E5C4CE18D57");

            entity.ToTable("EntraPIMActivations");

            entity.Property(e => e.DbPimid).HasColumnName("db_PIMID");
            entity.Property(e => e.AzEndTime)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_EndTime");
            entity.Property(e => e.AzJustification)
                .IsUnicode(false)
                .HasColumnName("az_Justification");
            entity.Property(e => e.AzRoleId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_RoleID");
            entity.Property(e => e.AzStartTime)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_StartTime");
            entity.Property(e => e.AzTicketNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_TicketNumber");
            entity.Property(e => e.AzTicketSystem)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_TicketSystem");
            entity.Property(e => e.DbUserAccountId).HasColumnName("db_UserAccountID");

            entity.HasOne(d => d.AzRole).WithMany(p => p.EntraPimactivations)
                .HasForeignKey(d => d.AzRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EntraPIMA__az_Ro__3F466844");

            entity.HasOne(d => d.DbUserAccount).WithMany(p => p.EntraPimactivations)
                .HasForeignKey(d => d.DbUserAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EntraPIMA__db_Us__3E52440B");
        });

        modelBuilder.Entity<EntraRole>(entity =>
        {
            entity.HasKey(e => e.AzRoleId).HasName("PK__EntraRol__44EF1600FB955925");

            entity.Property(e => e.AzRoleId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_RoleID");
            entity.Property(e => e.AzRoleDescription)
                .IsUnicode(false)
                .HasColumnName("az_RoleDescription");
            entity.Property(e => e.AzRoleName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_RoleName");
            entity.Property(e => e.AzStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("az_Status");
            entity.Property(e => e.DbCreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("db_CreatedDate");
            entity.Property(e => e.DbModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("db_ModifiedDate");
        });

        modelBuilder.Entity<EntraServicePrincipal>(entity =>
        {
            entity.HasKey(e => e.DbSpid).HasName("PK__EntraSer__BD0FA81C795D97B1");

            entity.Property(e => e.DbSpid).HasColumnName("db_SPID");
            entity.Property(e => e.AzAssignment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_Assignment");
            entity.Property(e => e.AzEnabled)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("az_Enabled");
            entity.Property(e => e.AzGroupId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_GroupID");
            entity.Property(e => e.AzLastActivated)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_LastActivated");
            entity.Property(e => e.AzName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_Name");
            entity.Property(e => e.AzRoleId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_RoleID");
            entity.Property(e => e.AzStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("az_Status");
            entity.Property(e => e.AzType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_Type");

            entity.HasOne(d => d.AzGroup).WithMany(p => p.EntraServicePrincipals)
                .HasForeignKey(d => d.AzGroupId)
                .HasConstraintName("FK__EntraServ__az_Gr__45F365D3");

            entity.HasOne(d => d.AzRole).WithMany(p => p.EntraServicePrincipals)
                .HasForeignKey(d => d.AzRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EntraServ__az_Ro__44FF419A");
        });

        modelBuilder.Entity<EntraUserAccount>(entity =>
        {
            entity.HasKey(e => e.DbUserAccountId).HasName("PK__EntraUse__6973BC79483F2FF2");

            entity.Property(e => e.DbUserAccountId).HasColumnName("db_UserAccountID");
            entity.Property(e => e.AzAssignment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("az_Assignment");
            entity.Property(e => e.AzDisplayName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_DisplayName");
            entity.Property(e => e.AzEnabled)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("az_Enabled");
            entity.Property(e => e.AzGroupId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_GroupID");
            entity.Property(e => e.AzLastActivated)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_LastActivated");
            entity.Property(e => e.AzRoleId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_RoleID");
            entity.Property(e => e.AzStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("az_Status");
            entity.Property(e => e.AzType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_Type");
            entity.Property(e => e.AzUpn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_UPN");

            entity.HasOne(d => d.AzGroup).WithMany(p => p.EntraUserAccounts)
                .HasForeignKey(d => d.AzGroupId)
                .HasConstraintName("FK__EntraUser__az_Gr__36B12243");

            entity.HasOne(d => d.AzRole).WithMany(p => p.EntraUserAccounts)
                .HasForeignKey(d => d.AzRoleId)
                .HasConstraintName("FK__EntraUser__az_Ro__35BCFE0A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
