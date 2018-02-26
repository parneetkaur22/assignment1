namespace Assignment1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table2
    {
        [Required]
        [StringLength(50)]
        public string phone { get; set; }

        public int customerID { get; set; }

        [Key]
        [Column("contactno.")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int contactno_ { get; set; }
    }
}
