using Kindi.API.Domain.Entities;
using Kindi.API.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kindi.API.Infrastructure.Data.Configurations;

public class BusinessGroupConfiguration : IEntityTypeConfiguration<BusinessGroup>
{
    public void Configure(EntityTypeBuilder<BusinessGroup> builder)
    {
        builder.ToTable("BusinessGroups");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.BusinessGroupCode)
            .HasMaxLength(30);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.Description)
            .HasMaxLength(1000);

        builder.Property(x => x.BusinessFieldName)
            .HasMaxLength(200);

        builder.Property(x => x.CoverImageUrl)
            .HasMaxLength(500);

        builder.Property(x => x.Topic)
            .HasMaxLength(200);

        builder.Property(x => x.RejectedReason)
            .HasMaxLength(500);

        builder.Property(x => x.Type)
            .HasConversion<int>()
            .HasDefaultValue(BusinessGroupType.Industry);

        builder.Property(x => x.ApprovalStatus)
            .HasConversion<int>()
            .HasDefaultValue(GroupApprovalStatus.Approved);

        builder.HasIndex(x => x.Type);
        builder.HasIndex(x => x.ApprovalStatus);

        builder.Property(x => x.RequiresApproval)
            .HasDefaultValue(true);

        builder.Property(x => x.IsActive)
            .HasDefaultValue(true);

        builder.HasIndex(x => x.BusinessGroupCode)
            .IsUnique()
            .HasFilter("\"BusinessGroupCode\" IS NOT NULL");

        builder.HasIndex(x => x.BusinessFieldId);

        builder.HasOne(x => x.BusinessField)
            .WithMany()
            .HasForeignKey(x => x.BusinessFieldId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(x => x.CreatedByUser)
            .WithMany()
            .HasForeignKey(x => x.CreatedByUserId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
