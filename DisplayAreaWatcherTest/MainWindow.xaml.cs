using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using System.Diagnostics;

namespace DisplayAreaWatcherTest
{
    public sealed partial class MainWindow : Window
    {
        private DisplayAreaWatcher displayAreaWatcher = DisplayArea.CreateWatcher();

        public MainWindow()
        {
            this.InitializeComponent();

            displayAreaWatcher.Added += OnDisplayAreaAdded;
            displayAreaWatcher.Removed += OnDisplayAreaRemoved;
            displayAreaWatcher.Updated += OnDisplayAreaUpdated;
            displayAreaWatcher.Stopped += DisplayAreaWatcher_Stopped;
            displayAreaWatcher.EnumerationCompleted += DisplayAreaWatcher_EnumerationCompleted;
            displayAreaWatcher.Start();
        }

        private void DisplayAreaWatcher_EnumerationCompleted(DisplayAreaWatcher sender, object args)
        {
            Debug.WriteLine($"Display area enumeration completed");
        }

        private void DisplayAreaWatcher_Stopped(DisplayAreaWatcher sender, object args)
        {
            Debug.WriteLine("Display watcher stopped");
        }

        private void OnDisplayAreaAdded(DisplayAreaWatcher watcher, DisplayArea displayArea)
        {
            Debug.WriteLine("Display area added");
        }

        private void OnDisplayAreaRemoved(DisplayAreaWatcher watcher, DisplayArea displayArea)
        {
            Debug.WriteLine("Display area removed");
        }
        private void OnDisplayAreaUpdated(DisplayAreaWatcher watcher, DisplayArea displayArea)
        {
            Debug.WriteLine("Display area updated");
        }


        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
        }
    }
}
