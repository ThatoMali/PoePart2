using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EventEaseApp2.Models
{
    public partial class EventEaseDBContext : DbContext
    {
        public EventEaseDBContext()
            : base("name=EventEaseDBContext")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Event_> Event_ { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event_>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<Event_>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Event_>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Event_)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.VenueName)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.Image_Url)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Venue)
                .WillCascadeOnDelete(false);
        }
    }
}
