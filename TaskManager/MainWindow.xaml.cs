using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaskManager.Models;
using System.ComponentModel;

namespace TaskManager;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private TaskListManager taskManager = new TaskListManager();
    private CollectionViewSource collectionView = new CollectionViewSource();
    public MainWindow()
    {
        InitializeComponent();
        taskManager.LoadFromFile();
        collectionView.Source = taskManager.List;
        collectionView.SortDescriptions.Add(new SortDescription(nameof(TaskItem.Priority), ListSortDirection.Descending));
        TaskListBox.ItemsSource = collectionView.View;
        
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        AddTaskWindow newWindow = new AddTaskWindow(taskManager);
        newWindow.ShowDialog();
    }

    private void RemoveTask_Click(object sender, RoutedEventArgs e)
    {
        Button clickedButton = (Button)sender;
        TaskItem taskToRemove = (TaskItem)clickedButton.DataContext;
        if (taskToRemove != null)
        {
            taskManager.RemoveTask(taskToRemove);
        }
    }
}