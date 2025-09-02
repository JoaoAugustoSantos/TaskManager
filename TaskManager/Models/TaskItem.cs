using System;
using System.ComponentModel;
using TaskManager.Models.Enumerates;

namespace TaskManager.Models
{
    public class TaskItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; private set; }
        public TaskPriority Priority { get; private set; }
        private bool _isCompleted;
        public bool IsCompleted
        {
            get { return _isCompleted; }
            set
            {
                _isCompleted = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsCompleted"));
            }
        }


        public TaskItem(string name, TaskPriority priority)
        {
            Name = name;
            Priority = priority;
        }

        public override string ToString()
        {
            return $"{Name} {Priority}";
        }
    }
}
