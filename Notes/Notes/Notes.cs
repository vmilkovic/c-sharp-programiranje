namespace Notes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notes")]
    public partial class Notes
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Column(TypeName = "text")]
        public string text { get; set; }

        public override string ToString() {
            return string.Format("{0}", name);
        }
    }
}
