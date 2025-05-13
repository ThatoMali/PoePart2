namespace EventEaseApp2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Venue")]
    public partial class Venue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venue()
        {
            Bookings = new HashSet<Booking>();
            Event_ = new HashSet<Event_>();
        }

        public int VenueID { get; set; }

        [Required]
        [StringLength(350)]
        public string VenueName { get; set; }

        [Required]
        [StringLength(350)]
        public string Location { get; set; }

        public int Capacity { get; set; }

        [StringLength(500)]
        public string Image_Url { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event_> Event_ { get; set; }
    }
}
