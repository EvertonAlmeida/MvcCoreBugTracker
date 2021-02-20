using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcCoreBugTracker.Business.Models;

namespace MvcCoreBugTracker.Data.Mapping
{
    public class SeverityMapping : IEntityTypeConfiguration<Severity>
    {
        public void Configure(EntityTypeBuilder<Severity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.ToTable("Severities");
        }
    }
}
