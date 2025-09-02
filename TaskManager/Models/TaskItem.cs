using System;
using TaskManager.Models.Enumerates;

namespace TaskManager.Models
{
    public class TaskItem
    {
        public string Name { get; private set; }
        public TaskPriority Priority { get; private set; }
        public TaskItemStatus Status { get; private set; }


        public TaskItem(string name, TaskPriority priority)
        {
            Name = name;
            Priority = priority;
            Status = TaskItemStatus.Pending;
        }

        public override string ToString()
        {
            return $"{Name} {Priority}";
        }
    }
}
