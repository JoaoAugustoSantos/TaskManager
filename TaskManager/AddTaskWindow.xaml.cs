using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TaskManager.Models;
using TaskManager.Models.Enumerates;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for AddTaskWindow.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        private TaskListManager taskManager;
        public AddTaskWindow(TaskListManager manager)
        {
            InitializeComponent();
            this.taskManager = manager;

            foreach (var priority in Enum.GetValues(typeof(TaskPriority)))
            {
                PriorityComboBox.Items.Add(priority);
            }

            PriorityComboBox.SelectedItem = TaskPriority.Low;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string newTaskName = TaskName.Text;
            TaskPriority selectedPriority = (TaskPriority)PriorityComboBox.SelectedItem;
            TaskItem newTask = new TaskItem(newTaskName, selectedPriority);
            taskManager.AddTask(newTask);
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
