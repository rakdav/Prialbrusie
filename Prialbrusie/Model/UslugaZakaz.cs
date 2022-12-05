namespace Prialbrusie.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UslugaZakaz")]
    public partial class UslugaZakaz
    {
        public int id { get; set; }

        public int id_zakaz { get; set; }

        public int id_usluga { get; set; }

        public virtual Service Service { get; set; }

        public virtual Zakaz Zakaz { get; set; }
    }
}
