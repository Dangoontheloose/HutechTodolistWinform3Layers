using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{   
    [Table("UserActivity")]
    public partial class UserActivity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        [Key]
        public int ActivityID { get; set; }
        [Required]
        public int AccID { get; set; }
        [Required]
        public DateTime Datetime { get; set; }
        [Required]
        public string Activity { get; set; }

        public virtual Account Account { get; set; }
    }
}
