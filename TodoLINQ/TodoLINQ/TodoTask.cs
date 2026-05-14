using System;
using System.Collections.Generic;

namespace TodoLINQ
{
    public class TodoTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Priority Priority { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreatedAt { get; set; }
        public TodoTask(int id, string title, Priority priority)
        {
            Id = id;
            Title = title;
            Priority = priority;
            IsDone = false;
            CreatedAt = DateTime.Now;
        }
    }
}
