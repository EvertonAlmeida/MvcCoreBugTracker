using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcCoreBugTracker.Business.Models;

namespace MvcCoreBugTracker.Data.Mapping
{
    public class BugMapping : IEntityTypeConfiguration<Bug>
    {
        public void Configure(EntityTypeBuilder<Bug> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Number)
            .IsRequired();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Description)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasOne(b => b.Severity);

            builder.HasOne(b => b.Status);

            builder.ToTable("Bugs");
        }
    }
}
