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

namespace TaskManager;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private TaskListManager taskManager = new TaskListManager();
    public MainWindow()
    {
        InitializeComponent();
        TaskListBox.ItemsSource = taskManager.List;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        AddTaskWindow newWindow = new AddTaskWindow(taskManager);
        newWindow.ShowDialog();
    }
}