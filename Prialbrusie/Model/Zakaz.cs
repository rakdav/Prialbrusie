namespace Prialbrusie.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zakaz")]
    public partial class Zakaz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zakaz()
        {
            UslugaZakaz = new HashSet<UslugaZakaz>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string Kode { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateStart { get; set; }

        public TimeSpan TimeStart { get; set; }

        public int id_client { get; set; }

        public int id_status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateFinish { get; set; }

        public int Period { get; set; }

        public virtual Client Client { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UslugaZakaz> UslugaZakaz { get; set; }
    }
}
