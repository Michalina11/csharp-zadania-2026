using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoLINQ
{
    public class TodoManager
    {
        private List<TodoTask> tasks = new List<TodoTask>();
        public void AddTask(TodoTask task)
        {
            tasks.Add(task);
        }
        public void FinishTask(int id)
        {
            TodoTask task = tasks.FirstOrDefault(t => t.Id == id);

            if (task != null)
            {
                task.IsDone = true;
            }
        }
        public List<TodoTask> GetPending()
        {
            return tasks
                .Where(t => !t.IsDone)
                .OrderByDescending(t => t.Priority)
                .ToList();
        }
        public List<TodoTask> GetByPriority(Priority priority)
        {
            return tasks
                .Where(t => t.Priority == priority)
                .ToList();
        }
        public IEnumerable<IGrouping<Priority, TodoTask>> GetGrouped()
        {
            return tasks.GroupBy(t => t.Priority);
        }
        public int CountDone()
        {
            return tasks.Count(t => t.IsDone);
        }
        public List<TodoTask> GetAll()
        {
            return tasks;
        }
    }
}
