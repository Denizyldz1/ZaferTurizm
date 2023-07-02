using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZaferTurizm.DataAccess.SeedData;
using ZaferTurizm.Domain;

namespace ZaferTurizm.DataAccess.Configurations
{
    internal class BusTripConfiguration : IEntityTypeConfiguration<BusTrip>
    {
        public void Configure(EntityTypeBuilder<BusTrip> builder)
        {
            builder.ToTable(nameof(BusTrip));
            builder.HasKey(trip => trip.Id);
            builder.Property(trip => trip.Date).HasColumnType("datetime2(0)");
            builder.Property(trip => trip.Price).HasColumnType("money");

            builder.HasOne(trip => trip.Route)
                .WithMany()
                .HasForeignKey(trip => trip.RouteId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(trip => trip.Vehicle)
                .WithMany()
                .HasForeignKey(trip => trip.VehicleId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                BusTripData.Data01,
                BusTripData.Data02,
                BusTripData.Data03,
                BusTripData.Data04
                );
        }
    }
}
