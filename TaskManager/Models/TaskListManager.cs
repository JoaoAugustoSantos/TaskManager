using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models.Enumerates;

namespace TaskManager.Models
{
    public class TaskListManager
    {
        public ObservableCollection<TaskItem> List { get; private set; } = new ObservableCollection<TaskItem> { };

        public void AddTask(TaskItem newTask)
        {
            //newTask = new TaskItem("Tarefa 1", TaskPriority.Medium);
            List.Add(newTask);
        }

    }
}
