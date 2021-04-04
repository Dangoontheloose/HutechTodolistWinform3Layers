using System;
using System.Collections.Generic;

namespace DTO
{
    public class TaskView
    {
        public int TaskID { get; set; }
        public string Taskname { get; set; }
        public int AssigneeID { get; set; }
        public string Assignee { get; set; }
        public string Progress { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? FinishDate { get; set; }

    }
}
