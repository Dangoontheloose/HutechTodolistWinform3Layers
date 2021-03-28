namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TodoTask")]
    public partial class TodoTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TodoTask()
        {
            Subtasks = new HashSet<Subtask>();
        }

        [Key]
        public int TaskID { get; set; }

        [Required]
        [StringLength(200)]
        public string Taskname { get; set; }

        [StringLength(200)]
        public string TaskDescription { get; set; }

        public int Progress { get; set; }

        public int PriID { get; set; }

        public DateTime DueDate { get; set; }
        public DateTime? FinishDate { get; set; }

        public int StateID { get; set; }

        public int AccID { get; set; }

        public virtual Account Account { get; set; }

        public virtual Priority Priority { get; set; }

        public virtual State State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subtask> Subtasks { get; set; }
    }
}
