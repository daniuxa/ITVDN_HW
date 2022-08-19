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

namespace EFCore_HW1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
/*Используя Visual Studio, создайте проект по шаблону Windows Forms Application.
Требуется:
Создайте пустую базу данных Database First.
Создайте EDM (Entity Data Model) используя технику Model First/DataBase First.
Добавьте на форму DataGridView и Button.
Реализуйте возможность вывода на экран информации в DataGridView по нажатию на Button.*/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string Msg = "";

            InitializeComponent();

            using (Model2Container model2Container = new Model2Container())
            {
                model2Container.MyTable2Set.Add(new MyTable2 { SomeName = "fst"});
                model2Container.MyTable2Set.Add(new MyTable2 { SomeName = "snd" });
                model2Container.MyTable2Set.Add(new MyTable2 { SomeName = "trd" });
                model2Container.SaveChanges();

                var list2 = model2Container.MyTable2Set.ToList();
                foreach (var item in list2)
                {
                    Msg += $"{item.Id} - {item.SomeName}\n";
                }    
                MessageBox.Show(Msg);
            }

            Test1Entities1 test1Entities1 = new Test1Entities1();
            var list = test1Entities1.MyTables.ToList();
            MyDataGridView.ItemsSource = list;
        }

    }
}
