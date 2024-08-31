using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ReportDataBackend.Entity.Concrete;

namespace ReportDataBackend.DataAccess.Concrete.EntityFramework;

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

    public virtual DbSet<GroupRoleMapping> GroupRoleMappings { get; set; }

    public virtual DbSet<ServicePrincipalGroupMapping> ServicePrincipalGroupMappings { get; set; }

    public virtual DbSet<ServicePrincipalRoleMapping> ServicePrincipalRoleMappings { get; set; }

    public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; }

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
        });

        modelBuilder.Entity<GroupRoleMapping>(entity =>
        {
            entity.HasKey(e => e.DbUserRoleId).HasName("PK__GroupRol__478CE56E4165F680");

            entity.Property(e => e.DbUserRoleId).HasColumnName("db_UserRoleID");
            entity.Property(e => e.AzGroupId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_GroupID");
            entity.Property(e => e.DbAssignedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("db_AssignedDate");
            entity.Property(e => e.DbUserAccountId).HasColumnName("db_UserAccountID");

            entity.HasOne(d => d.AzGroup).WithMany(p => p.EntraUserAccounts)
                .HasForeignKey(d => d.AzGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupRole__az_Gr__66603565");

            entity.HasOne(d => d.DbUserAccount).WithMany(p => p.AzGroups)
                .HasForeignKey(d => d.DbUserAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupRole__db_Us__6754599E");
        });

        modelBuilder.Entity<ServicePrincipalGroupMapping>(entity =>
        {
            entity.HasKey(e => e.DbSpgroupId).HasName("PK__ServiceP__BD0A520FF929ADD4");

            entity.ToTable("ServicePrincipalGroupMapping");

            entity.Property(e => e.DbSpgroupId).HasColumnName("db_SPGroupID");
            entity.Property(e => e.AzGroupId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_GroupID");
            entity.Property(e => e.AzSpid).HasColumnName("az_SPID");
            entity.Property(e => e.DbAssignedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("db_AssignedDate");

            entity.HasOne(d => d.AzGroup).WithMany(p => p.EntraServicePrincipals)
                .HasForeignKey(d => d.AzGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ServicePr__az_Gr__7E37BEF6");

            entity.HasOne(d => d.AzSp).WithMany(p => p.AzGroups)
                .HasForeignKey(d => d.AzSpid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ServicePr__az_SP__7F2BE32F");
        });

        modelBuilder.Entity<ServicePrincipalRoleMapping>(entity =>
        {
            entity.HasKey(e => e.DbSproleId).HasName("PK__ServiceP__F2E25C76225807C3");

            entity.ToTable("ServicePrincipalRoleMapping");

            entity.Property(e => e.DbSproleId).HasColumnName("db_SPRoleID");
            entity.Property(e => e.AzRoleId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_RoleID");
            entity.Property(e => e.AzSpid).HasColumnName("az_SPID");
            entity.Property(e => e.DbAssignedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("db_AssignedDate");

            entity.HasOne(d => d.AzRole).WithMany(p => p.EntraServicePrincipals)
                .HasForeignKey(d => d.AzRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ServicePr__az_Ro__08B54D69");

            entity.HasOne(d => d.AzSp).WithMany(p => p.AzRoles)
                .HasForeignKey(d => d.AzSpid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ServicePr__az_SP__09A971A2");
        });

        modelBuilder.Entity<UserRoleMapping>(entity =>
        {
            entity.HasKey(e => e.DbUserRoleId).HasName("PK__UserRole__478CE56E9D27E41C");

            entity.Property(e => e.DbUserRoleId).HasColumnName("db_UserRoleID");
            entity.Property(e => e.AzRoleId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("az_RoleID");
            entity.Property(e => e.DbAssignedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("db_AssignedDate");
            entity.Property(e => e.DbUserAccountId).HasColumnName("db_UserAccountID");

            entity.HasOne(d => d.AzRole).WithMany(p => p.EntraUserAccounts)
                .HasForeignKey(d => d.AzRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserRoleM__az_Ro__619B8048");

            entity.HasOne(d => d.DbUserAccount).WithMany(p => p.AzRoles)
                .HasForeignKey(d => d.DbUserAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserRoleM__db_Us__628FA481");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
