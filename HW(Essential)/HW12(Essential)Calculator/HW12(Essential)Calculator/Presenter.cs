using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12_Essential_Calculator
{
    internal class Presenter
    {
        MainWindow MainWindow { get; set; }
        Model Model { get; set; }
        public Presenter(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            Model = new Model();
            MainWindow.CalculateBtnPressed += MainWindow_CalculateBtnPressed;
        }

        private void MainWindow_CalculateBtnPressed(object sender, EventArgs e)
        {
            try
            {
                MainWindow.ResultBlock.Text = "= " + Model.Calculate(MainWindow.TextBoxField.Text);
            }
            catch (Exception ex)
            {
                MainWindow.ErrorMsg(ex.Message);
            }
        }
    }
}
