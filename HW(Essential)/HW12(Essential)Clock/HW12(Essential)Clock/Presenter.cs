using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12_Essential_Clock
{
    internal class Presenter
    {
        private MainWindow MainWindow { get; set; }
        private Model Model { get; set; }
        System.Windows.Threading.DispatcherTimer dispatcherTimer;
        public Presenter(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            Model = new Model();
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            mainWindow.StartButtonPressed += MainWindow_StartButtonPressed;
            mainWindow.StopButtonPressed += MainWindow_StopButtonPressed;
            mainWindow.ResetButtonPressed += MainWindow_ResetButtonPressed;
        }

        private void MainWindow_ResetButtonPressed(object sender, EventArgs e)
        {
            dispatcherTimer?.Stop();           
            MainWindow.TimeDisplay.Text = Model.Timer(true).ToString(@"c");
        }

        private void MainWindow_StopButtonPressed(object sender, EventArgs e)
        {
            dispatcherTimer?.Stop();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            MainWindow.TimeDisplay.Text = Model.Timer().ToString(@"c");
        }

        private void MainWindow_StartButtonPressed(object sender, EventArgs e)
        {    
            dispatcherTimer?.Start();  
        }
    }
}
