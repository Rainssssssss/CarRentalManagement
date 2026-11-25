using CarRentalManagement.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configuration.Entities
{
    public class ModelSeed : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            var date = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            builder.HasData(
                new Model { Id = 1, Name = "i4", DateCreated = date, DateUpdated = date, CreatedBy = "System", UpdatedBy = "System" },
                new Model { Id = 2, Name = "X5", DateCreated = date, DateUpdated = date, CreatedBy = "System", UpdatedBy = "System" },
                new Model { Id = 3, Name = "Prius", DateCreated = date, DateUpdated = date, CreatedBy = "System", UpdatedBy = "System" },
                new Model { Id = 4, Name = "C-HR", DateCreated = date, DateUpdated = date, CreatedBy = "System", UpdatedBy = "System" }
            );
        }
    }
}