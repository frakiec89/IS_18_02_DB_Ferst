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

namespace ProectSGK.MyWindows
{
    /// <summary>
    /// Логика взаимодействия для WindowDellGroup.xaml
    /// </summary>
    public partial class WindowDellGroup : Window
    {
        public WindowDellGroup()
        {
            InitializeComponent();
        }

        private void btDellGroup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int  id = Convert.ToInt32( tbIdGroup.Text);

                DB.MyContext myContext = new DB.MyContext();
                var grDell = myContext.Groups.Find(id); // находит в  бд  по  id 

                myContext.Groups.Remove(grDell); // удаляет  объект из  бд 
                myContext.SaveChanges();

                MessageBox.Show("Группа  удалена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
