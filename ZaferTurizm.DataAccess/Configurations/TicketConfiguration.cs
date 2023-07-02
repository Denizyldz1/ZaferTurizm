using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZaferTurizm.DataAccess.SeedData;
using ZaferTurizm.Domain;

namespace ZaferTurizm.DataAccess.Configurations
{
    internal class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable(nameof(Ticket));
            builder.HasKey(ticket => ticket.Id);
            builder.Property(ticket => ticket.Price).HasColumnType("money");

            builder.HasOne(ticket => ticket.Passenger)
                .WithMany()
                .HasForeignKey(ticket => ticket.PassengerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ticket => ticket.BusTrip)
                .WithMany()
                .HasForeignKey(ticket => ticket.BusTripId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasData(
                TicketData.Data01,
                TicketData.Data02,
                TicketData.Data03
                );
        }
    }
}
