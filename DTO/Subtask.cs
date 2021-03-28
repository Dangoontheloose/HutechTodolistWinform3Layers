namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subtask")]
    public partial class Subtask
    {
        public int SubtaskID { get; set; }

        [StringLength(200)]
        public string SubtaskName { get; set; }

        public bool? State { get; set; }

        public int? TaskID { get; set; }

        public virtual TodoTask TodoTask { get; set; }
    }
}
