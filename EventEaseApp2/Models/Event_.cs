namespace EventEaseApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event_()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        public int EventID { get; set; }

        [Required]
        [StringLength(350)]
        public string EventName { get; set; }

        [Column(TypeName = "date")]
        public DateTime EventDate { get; set; }

        public string Description { get; set; }

        public int? VenueID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual Venue Venue { get; set; }
    }
}
