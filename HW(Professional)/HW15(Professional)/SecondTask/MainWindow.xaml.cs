using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

/*Создайте WPF приложение, разместите в окне TextBox и две кнопки. При нажатии на первую
кнопку в TextBox выводится сообщение «Подключен к базе данных» при этом в обработчике
установите задержку в 3-5 сек для имитации подключения к БД, также данная кнопка запускает
таймер, который с периодичностью в несколько секунд выводит в TextBox сообщение «Данные
получены». При нажатии на вторую кнопку по аналогии с первой отключаемся от базы (с
задержкой), выводим сообщение и останавливаем таймер.*/

namespace SecondTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool connected = false;

        CancellationTokenSource cancelTokenSource;

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Connection
        private void ConnectToDB()
        {
            Thread.Sleep(3000);
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate () { StateBlock.Text = "Connected"; });
        }

        private async Task ConnectToDBAsync()
        {
            await Task.Run(() => { ConnectToDB(); });
        }

        private async void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            if (connected)
            {
                return;
            }
            else
            {
                connected = true;
                cancelTokenSource = new CancellationTokenSource();
            }
            await ConnectToDBAsync();
            GettingDataAsync(cancelTokenSource.Token);
        }

        #endregion

        #region Getting data
        private void GettingData(CancellationToken cancellationToken)
        {
            int i = 0;
            //bool state = true;
            /*cancellationToken.Register(() =>
            {
                state = false;
            });*/
            while (true)
            {
                var t = WaitAsync();
                while (!t.IsCompleted)
                {
                    if (/*state == false*/cancellationToken.IsCancellationRequested)
                    {
                        t.Wait();
                        return;
                    }
                }
                this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate () { StateBlock.Text = "Getting data " + i++; });
            }
        }

        private async Task WaitAsync()
        {
            await Task.Run(() => { Thread.Sleep(2000); });
        }

        private async void GettingDataAsync(CancellationToken cancellationToken)
        {
            await Task.Run(() => { GettingData(cancellationToken); });
        }
        #endregion

        #region Disconnect
        private void Disconnect()
        {
            Thread.Sleep(3000);
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate () { StateBlock.Text = "Disconnected"; });
        }

        private async void DisconnectAsync()
        {
            await Task.Run(() => { Disconnect(); });
        }

        private void DisconnectButton_Click(object sender, RoutedEventArgs e)
        {
            if (!connected)
            {
                return;
            }
            else
            {
                connected = false;
            }
            cancelTokenSource.Cancel();
           
            DisconnectAsync();
        }
        #endregion
    }
}
