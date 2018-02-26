namespace Assignment1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerID { get; set; }

        [Required]
        [StringLength(50)]
        public string companyname { get; set; }

        [Required]
        [StringLength(50)]
        public string contactname { get; set; }
    }
}
