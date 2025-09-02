using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TaskManager.Models.Enumerates;
using System.IO;

namespace TaskManager.Models
{
    public class TaskListManager
    {
        public ObservableCollection<TaskItem> List { get; private set; } = new ObservableCollection<TaskItem> { };
        private readonly string filePath = "tasks.json";

        public void AddTask(TaskItem newTask)
        {
            List.Add(newTask);
            SaveToFile();
        }

        public void RemoveTask(TaskItem newTask)
        {
            List.Remove(newTask);
            SaveToFile();
        }

        public void SaveToFile()
        {
            string json = JsonSerializer.Serialize(List);
            File.WriteAllText(filePath, json);
        }

        public void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var loadedTasks = JsonSerializer.Deserialize<ObservableCollection<TaskItem>>(json);
                if (loadedTasks != null)
                {
                    List = loadedTasks;
                }
            }
        }
    }
}
