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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW12_Essential_Clock
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler<EventArgs> StartButtonPressed;
        public event EventHandler<EventArgs> StopButtonPressed;
        public event EventHandler<EventArgs> ResetButtonPressed;

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartButtonPressed?.Invoke(sender, e);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            StopButtonPressed?.Invoke(sender, e);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetButtonPressed?.Invoke(sender, e);
        }
    }
}
