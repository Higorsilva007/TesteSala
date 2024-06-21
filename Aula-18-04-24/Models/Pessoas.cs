namespace Aula_18_04_24.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DS220807.Pessoas")]
    public partial class Pessoas
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(50)]
        public string email { get; set; }
    }
}
