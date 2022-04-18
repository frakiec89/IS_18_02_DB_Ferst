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

namespace ProectSGK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btAddGroup_Click(object sender, RoutedEventArgs e)
        {
           MyWindows.WindowAddGroup windowAddGroup = new MyWindows.WindowAddGroup();
            windowAddGroup.ShowDialog();
           
        }

        private void btDellGroup_Click(object sender, RoutedEventArgs e)
        {
            MyWindows.WindowDellGroup windowDellGroup = new MyWindows.WindowDellGroup();
            windowDellGroup.ShowDialog();
        }

        private void btAddStudent_Click(object sender, RoutedEventArgs e)
        {
            MyWindows.WindowAddDStudent window = new MyWindows.WindowAddDStudent();
            window.ShowDialog();
        }
    }
}
